using DigitalWineCard.Core.AccessLayers;
using DigitalWineCard.Data.Entities;
using DigitalWineCard.Data.UI.UIMappers;

namespace DigitalWineCard.Forms
{
    public partial class WineCard : Form
    {
        //access layers
        private readonly WineAccessLayer _wineAccessLayer = new();
        private readonly ImportLogAccessLayer _importLogAccessLayer = new();
        private readonly AdminAccessLayer _adminAccessLayer = new();

        //admin related fields
        private bool _isAdmin = false;
        private Admin? _admin = new();

        public WineCard(bool isAdmin, string? adminUserName)
        {
            InitializeComponent();
            CenterToScreen();

            _isAdmin = isAdmin;

            if (isAdmin)
            {
                _admin = _adminAccessLayer.GetByUsername(adminUserName);
            }
        }

        private void WineCard_Load(object sender, EventArgs e)
        {
            UpdateWindow();
        }

        private void UpdateWindow()
        {
            groupBoxManageWines.Visible = _isAdmin;
            groupBoxCsvImport.Visible = _isAdmin;
            menuStripAdvancedAdmin.Visible = _isAdmin;

            groupBoxSearch.Visible = (!_isAdmin);

            buttonLogin.Text = _isAdmin ? "Logout" : "Login";

            if (_isAdmin)
            {
                RefreshDataGridActiveWinesAdmin();
            }
            else
            {
                RefreshDataGridActiveWines();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (buttonLogin.Text == "Login")
            {
                var login = new Login();
                login.ShowDialog();
                Hide();
            }
            else if (buttonLogin.Text == "Logout")
            {
                _isAdmin = false;
                UpdateWindow();
            }
        }

        private void buttonOpenFromFileExplorer_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog.FileName;
            }

            buttonImport.Enabled = string.IsNullOrEmpty(textBoxFilePath.Text) ? false : true;
        }

        private void textBoxFilePath_TextChanged(object sender, EventArgs e)
        {
            buttonImport.Enabled = string.IsNullOrEmpty(textBoxFilePath.Text) ? false : true;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (_wineAccessLayer.GetActiveWinesAmount() >= 10)
            {
                MessageBox.Show("The maximum wines limit of 10 wines has been exceeded. Wines can not be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                var csvListWines = Core.Managers.CsvManager.ReadWineCsv(textBoxFilePath.Text);

                foreach (var wine in csvListWines)
                {
                    if (_wineAccessLayer.WineAlreadyExists(wine))
                    {
                        MessageBox.Show("At least one wine from the import file already exists. Please check for duplicates and try again.", "No duplicate values allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                Core.Managers.CsvManager.ImportWinesFromCsv(textBoxFilePath.Text);
                RefreshDataGridActiveWines();

                // creating new import log for from csv imported data
                var importLog = new ImportLog
                {
                    AdminId = _admin.AdminId,
                    ImportDate = DateTime.Now,
                    FileName = textBoxFilePath.Text,
                    ImportedWinesAmount = csvListWines.Count
                };
                _importLogAccessLayer.Add(importLog);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = WineUiMapper.ToDto(_wineAccessLayer.GetByFilters(textBoxSearch.Text));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedWine = dataGridView.SelectedRows[0];
            var wineId = (int)selectedWine.Cells["WineId"].Value;

            _wineAccessLayer.Delete(wineId);
            RefreshDataGridActiveWines();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            var selectedWine = dataGridView.SelectedRows[0];
            var wineId = (int)selectedWine.Cells[nameof(Wine.WineId)].Value;

            _wineAccessLayer.DeactivateWine(wineId);
            RefreshDataGridActiveWines();
        }

        private void showImportLogMenuItem_Click(object sender, EventArgs e)
        {
            RefreshImportLog();
        }

        private void showAllWinesMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDataGridAllWinesAdmin();
        }

        private void showOnlyActiveMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDataGridActiveWinesAdmin();
        }

        //uses wine dto instead of wine entity to display only restricted columns to customer (active wines only)
        private void RefreshDataGridActiveWines()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = WineUiMapper.ToDto(_wineAccessLayer.GetOnlyActive());
        }

        //uses wine entity to display all columns in datagridview for the admin (active wines only)
        private void RefreshDataGridActiveWinesAdmin()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _wineAccessLayer.GetOnlyActive();
        }

        //uses wine entity to display all columns in datagridview for the admin (active and inactive wines)
        private void RefreshDataGridAllWinesAdmin()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _wineAccessLayer.GetAll();
        }

        private void RefreshImportLog()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _importLogAccessLayer.GetAll();
        }

        private void buttonInsertEdit_Click(object sender, EventArgs e)
        {
            string processName = Text == "Insert" ? "Add" : "Update";

            var selectedWine = dataGridView.SelectedRows[0];
            var wineId = (int)selectedWine.Cells[nameof(Wine.WineId)].Value;

            var addUpdateForm = new AddUpdateWine(processName, wineId);
            addUpdateForm.ShowDialog();
            this.Hide();

            if (_isAdmin)
            {
                RefreshDataGridActiveWinesAdmin();
            }
            else
            {
                RefreshDataGridActiveWines();
            }
        }
    }
}
