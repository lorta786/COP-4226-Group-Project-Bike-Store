namespace BikeStore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnForgotUser_Click(object sender, EventArgs e)
        {
            frmForgotUserName forgotUserName = new frmForgotUserName();
            forgotUserName.ShowDialog();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword forgotPassword = new frmForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount createAccount = new frmCreateAccount();
            createAccount.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Hide();
            using frmBikeStore mainForm = new();
            mainForm.ShowDialog();
            Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
