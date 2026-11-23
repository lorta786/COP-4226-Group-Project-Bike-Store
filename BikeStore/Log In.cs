namespace BikeStore
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnForgotUser_Click(object sender, EventArgs e)
        {
            ForgotUserName forgotUserName = new ForgotUserName();
            forgotUserName.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            BikeStore bikeStore = new BikeStore();
            bikeStore.Show();
        }
    }
}
