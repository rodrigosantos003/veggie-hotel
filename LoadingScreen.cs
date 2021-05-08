using System;
using System.Windows.Forms;

namespace VeggieHotel
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            if (loadingProgress.Value < 100)
                loadingProgress.Value += 5;
            else
            {
                loadingTimer.Stop();
                new Login().Show();
                this.Hide();
            }
        }
    }
}
