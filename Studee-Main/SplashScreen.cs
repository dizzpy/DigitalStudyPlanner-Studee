using System;
using System.Windows.Forms;
using Studee_Main.Views.Authentication;

namespace Studee_Main
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Stop();
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
