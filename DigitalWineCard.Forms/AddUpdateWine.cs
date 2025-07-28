using DigitalWineCard.Core.AccessLayers;
using DigitalWineCard.Data.Entities;

namespace DigitalWineCard.Forms
{
    public partial class AddUpdateWine : Form
    {
        private readonly WineAccessLayer _wineAccessLayer = new();

        private readonly string _processName;
        private readonly int _selectedWineId;

        public AddUpdateWine(string processName, int selectedWineId)
        {
            InitializeComponent();
            CenterToParent();

            _processName = processName;
            _selectedWineId = selectedWineId;
        }

        private void AddUpdateWine_Load(object sender, EventArgs e)
        {
            buttonAddUpdate.Text = _processName;
            Text = $"{_processName} Wine";
            groupBoxAddUpdateWine.Text = $"{_processName} Process";

            if (_processName == "Update")
            {
               DisplaySelectedWine(_wineAccessLayer.GetById(_selectedWineId));
            }
        }

        private void buttonAddUpdate_Click(object sender, EventArgs e)
        {
            var wine = new Wine
            {
                Name = textBoxName.Text,
                Type = textBoxType.Text,
                Description = textBoxDescription.Text,
                CountryOfOrigin = textBoxOriginCountry.Text,
                Year = Convert.ToInt16(textBoxYear.Text),
                LiterPriceInEuro = Convert.ToDouble(textBoxPrice.Text),
                IsActive = checkBoxActive.Checked
            };

            if (_processName == "Update")
            {
                _wineAccessLayer.Update(_selectedWineId, wine);
            }
            else if (_processName == "Add")
            {
                if (_wineAccessLayer.GetActiveWinesAmount() >= 10)
                {
                    MessageBox.Show("The maximum wines limit of 10 wines has been exceeded. Wines can not be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                _wineAccessLayer.Add(wine);
            }

            Close(); //back to winecard
        }

        private void DisplaySelectedWine(Wine wine)
        {
            textBoxName.Text = wine.Name;
            textBoxType.Text = wine.Type;
            textBoxDescription.Text = wine.Description;
            textBoxOriginCountry.Text = wine.CountryOfOrigin;
            textBoxYear.Text = wine.Year.ToString();
            textBoxPrice.Text = wine.LiterPriceInEuro.ToString();
            checkBoxActive.Checked = wine.IsActive;
        }
    }
}
