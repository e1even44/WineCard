using DigitalWineCard.Core.AccessLayers;
using DigitalWineCard.Core.Managers;

namespace DigitalWineCard.Forms
{
    public partial class Login : Form
    {
        private readonly AdminAccessLayer _adminAccessLayer = new();

        private int _adminId;
       
        public Login()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!_adminAccessLayer.AdminsExist())
            {
                AdminManager.InitializeAdmins();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var enteredUsername = textBoxUsername.Text;
            var enteredPassword = textBoxPassword.Text;

            var admin = new Data.Entities.Admin();

            if (_adminAccessLayer.UsernameExists(enteredUsername))
            {
                admin = _adminAccessLayer.GetByUsername(enteredUsername);
                _adminId = admin.AdminId;
            }

            if (PasswordManager.VerifyPassword(enteredPassword, admin.Password, admin.Salt))
            {
                var wineCard = new WineCard(true, admin.Username);
                wineCard.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
