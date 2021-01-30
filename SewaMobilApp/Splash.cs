using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SewaMobilApp
{
    public partial class Splash : Form
    {
        int loading;
        public Splash()
        {
            InitializeComponent();
            panelLoading.Width = 0;
            timer.Start();
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            loading += 3;
            panelLoading.Width += loading;

            if ( panelLoading.Width >= 600 )
            {
                timer.Stop();
                Login login = new Login();
                await Task.Delay(250);
                login.Show();
                this.Hide();
            }
            else
            {

            }
        }
    }
}
