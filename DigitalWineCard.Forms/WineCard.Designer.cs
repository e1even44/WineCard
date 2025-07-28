namespace DigitalWineCard.Forms
{
    partial class WineCard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxWineCard = new GroupBox();
            groupBoxCsvImport = new GroupBox();
            groupBoxSearch = new GroupBox();
            textBoxSearch = new TextBox();
            label2 = new Label();
            buttonImport = new Button();
            buttonOpenFromFileExplorer = new Button();
            label1 = new Label();
            textBoxFilePath = new TextBox();
            dataGridView = new DataGridView();
            buttonLogin = new Button();
            groupBoxManageWines = new GroupBox();
            buttonHide = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonInsert = new Button();
            menuStripAdvancedAdmin = new MenuStrip();
            importsToolStripMenuItem = new ToolStripMenuItem();
            showImportLogMenuItem = new ToolStripMenuItem();
            wineCardToolStripMenuItem = new ToolStripMenuItem();
            showAllWinesMenuItem = new ToolStripMenuItem();
            showOnlyActiveMenuItem = new ToolStripMenuItem();
            groupBoxWineCard.SuspendLayout();
            groupBoxCsvImport.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBoxManageWines.SuspendLayout();
            menuStripAdvancedAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxWineCard
            // 
            groupBoxWineCard.Controls.Add(groupBoxSearch);
            groupBoxWineCard.Controls.Add(groupBoxCsvImport);
            groupBoxWineCard.Controls.Add(dataGridView);
            groupBoxWineCard.Location = new Point(14, 49);
            groupBoxWineCard.Margin = new Padding(3, 4, 3, 4);
            groupBoxWineCard.Name = "groupBoxWineCard";
            groupBoxWineCard.Padding = new Padding(3, 4, 3, 4);
            groupBoxWineCard.Size = new Size(1147, 804);
            groupBoxWineCard.TabIndex = 0;
            groupBoxWineCard.TabStop = false;
            groupBoxWineCard.Text = "Wines";
            // 
            // groupBoxCsvImport
            // 
            groupBoxCsvImport.BackColor = SystemColors.ButtonFace;
            groupBoxCsvImport.Controls.Add(buttonImport);
            groupBoxCsvImport.Controls.Add(buttonOpenFromFileExplorer);
            groupBoxCsvImport.Controls.Add(label1);
            groupBoxCsvImport.Controls.Add(textBoxFilePath);
            groupBoxCsvImport.ForeColor = SystemColors.ControlText;
            groupBoxCsvImport.Location = new Point(24, 57);
            groupBoxCsvImport.Margin = new Padding(3, 4, 3, 4);
            groupBoxCsvImport.Name = "groupBoxCsvImport";
            groupBoxCsvImport.Padding = new Padding(3, 4, 3, 4);
            groupBoxCsvImport.Size = new Size(1098, 133);
            groupBoxCsvImport.TabIndex = 5;
            groupBoxCsvImport.TabStop = false;
            groupBoxCsvImport.Text = "CSV Import";
            groupBoxCsvImport.Visible = false;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.BackColor = SystemColors.ButtonFace;
            groupBoxSearch.Controls.Add(textBoxSearch);
            groupBoxSearch.Controls.Add(label2);
            groupBoxSearch.ForeColor = SystemColors.ControlText;
            groupBoxSearch.Location = new Point(24, 57);
            groupBoxSearch.Margin = new Padding(3, 4, 3, 4);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Padding = new Padding(3, 4, 3, 4);
            groupBoxSearch.Size = new Size(1098, 133);
            groupBoxSearch.TabIndex = 6;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            groupBoxSearch.Visible = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(312, 51);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "e.g. Red Wine";
            textBoxSearch.Size = new Size(769, 27);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 61);
            label2.Name = "label2";
            label2.Size = new Size(285, 20);
            label2.TabIndex = 1;
            label2.Text = "Search for Type, Country of Origin or Year:";
            // 
            // buttonImport
            // 
            buttonImport.Enabled = false;
            buttonImport.Location = new Point(918, 68);
            buttonImport.Margin = new Padding(3, 4, 3, 4);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(163, 31);
            buttonImport.TabIndex = 4;
            buttonImport.Text = "Import";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonOpenFromFileExplorer
            // 
            buttonOpenFromFileExplorer.Location = new Point(918, 29);
            buttonOpenFromFileExplorer.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFromFileExplorer.Name = "buttonOpenFromFileExplorer";
            buttonOpenFromFileExplorer.Size = new Size(163, 31);
            buttonOpenFromFileExplorer.TabIndex = 3;
            buttonOpenFromFileExplorer.Text = "Open from File Explorer";
            buttonOpenFromFileExplorer.UseVisualStyleBackColor = true;
            buttonOpenFromFileExplorer.Click += buttonOpenFromFileExplorer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 60);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "File Path:";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(128, 56);
            textBoxFilePath.Margin = new Padding(3, 4, 3, 4);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.PlaceholderText = "C:\\example_folder\\example_file";
            textBoxFilePath.Size = new Size(756, 27);
            textBoxFilePath.TabIndex = 2;
            textBoxFilePath.TextChanged += textBoxFilePath_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(24, 216);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1098, 560);
            dataGridView.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(1075, 11);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(86, 31);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // groupBoxManageWines
            // 
            groupBoxManageWines.BackColor = SystemColors.ButtonFace;
            groupBoxManageWines.Controls.Add(buttonHide);
            groupBoxManageWines.Controls.Add(buttonDelete);
            groupBoxManageWines.Controls.Add(buttonEdit);
            groupBoxManageWines.Controls.Add(buttonInsert);
            groupBoxManageWines.ForeColor = SystemColors.ControlText;
            groupBoxManageWines.Location = new Point(632, 861);
            groupBoxManageWines.Margin = new Padding(3, 4, 3, 4);
            groupBoxManageWines.Name = "groupBoxManageWines";
            groupBoxManageWines.Padding = new Padding(3, 4, 3, 4);
            groupBoxManageWines.Size = new Size(529, 92);
            groupBoxManageWines.TabIndex = 6;
            groupBoxManageWines.TabStop = false;
            groupBoxManageWines.Text = "Manage Wines";
            groupBoxManageWines.Visible = false;
            // 
            // buttonHide
            // 
            buttonHide.Location = new Point(387, 29);
            buttonHide.Margin = new Padding(3, 4, 3, 4);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(120, 31);
            buttonHide.TabIndex = 3;
            buttonHide.Text = "Hide";
            buttonHide.UseVisualStyleBackColor = true;
            buttonHide.Click += buttonHide_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(261, 29);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 31);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(134, 29);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(120, 31);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonInsertEdit_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(7, 29);
            buttonInsert.Margin = new Padding(3, 4, 3, 4);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(120, 31);
            buttonInsert.TabIndex = 0;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsertEdit_Click;
            // 
            // menuStripAdvancedAdmin
            // 
            menuStripAdvancedAdmin.ImageScalingSize = new Size(20, 20);
            menuStripAdvancedAdmin.Items.AddRange(new ToolStripItem[] { importsToolStripMenuItem, wineCardToolStripMenuItem });
            menuStripAdvancedAdmin.Location = new Point(0, 0);
            menuStripAdvancedAdmin.Name = "menuStripAdvancedAdmin";
            menuStripAdvancedAdmin.Padding = new Padding(7, 3, 0, 3);
            menuStripAdvancedAdmin.Size = new Size(1173, 30);
            menuStripAdvancedAdmin.TabIndex = 7;
            menuStripAdvancedAdmin.Text = "menuStrip1";
            // 
            // importsToolStripMenuItem
            // 
            importsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showImportLogMenuItem });
            importsToolStripMenuItem.Name = "importsToolStripMenuItem";
            importsToolStripMenuItem.Size = new Size(74, 24);
            importsToolStripMenuItem.Text = "Imports";
            // 
            // showImportLogMenuItem
            // 
            showImportLogMenuItem.Name = "showImportLogMenuItem";
            showImportLogMenuItem.Size = new Size(206, 26);
            showImportLogMenuItem.Text = "Show Import Log";
            showImportLogMenuItem.Click += showImportLogMenuItem_Click;
            // 
            // wineCardToolStripMenuItem
            // 
            wineCardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAllWinesMenuItem, showOnlyActiveMenuItem });
            wineCardToolStripMenuItem.Name = "wineCardToolStripMenuItem";
            wineCardToolStripMenuItem.Size = new Size(92, 24);
            wineCardToolStripMenuItem.Text = "Wine Card";
            // 
            // showAllWinesMenuItem
            // 
            showAllWinesMenuItem.Name = "showAllWinesMenuItem";
            showAllWinesMenuItem.Size = new Size(207, 26);
            showAllWinesMenuItem.Text = "Show All";
            showAllWinesMenuItem.Click += showAllWinesMenuItem_Click;
            // 
            // showOnlyActiveMenuItem
            // 
            showOnlyActiveMenuItem.Name = "showOnlyActiveMenuItem";
            showOnlyActiveMenuItem.Size = new Size(207, 26);
            showOnlyActiveMenuItem.Text = "Show Only Active";
            showOnlyActiveMenuItem.Click += showOnlyActiveMenuItem_Click;
            // 
            // WineCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 957);
            Controls.Add(groupBoxManageWines);
            Controls.Add(buttonLogin);
            Controls.Add(groupBoxWineCard);
            Controls.Add(menuStripAdvancedAdmin);
            MainMenuStrip = menuStripAdvancedAdmin;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1191, 1004);
            MinimumSize = new Size(1191, 1004);
            Name = "WineCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wine Card";
            WindowState = FormWindowState.Maximized;
            Load += WineCard_Load;
            groupBoxWineCard.ResumeLayout(false);
            groupBoxCsvImport.ResumeLayout(false);
            groupBoxCsvImport.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBoxManageWines.ResumeLayout(false);
            menuStripAdvancedAdmin.ResumeLayout(false);
            menuStripAdvancedAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxWineCard;
        private Button buttonOpenFromFileExplorer;
        private TextBox textBoxFilePath;
        private Label label1;
        private DataGridView dataGridView;
        private Button buttonImport;
        private Button buttonLogin;
        private GroupBox groupBoxCsvImport;
        private GroupBox groupBoxManageWines;
        private Button buttonHide;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonInsert;
        private GroupBox groupBoxSearch;
        private Label label2;
        private TextBox textBoxSearch;
        private MenuStrip menuStripAdvancedAdmin;
        private ToolStripMenuItem importsToolStripMenuItem;
        private ToolStripMenuItem showImportLogMenuItem;
        private ToolStripMenuItem wineCardToolStripMenuItem;
        private ToolStripMenuItem showAllWinesMenuItem;
        private ToolStripMenuItem showOnlyActiveMenuItem;
    }
}
