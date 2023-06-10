using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 513) 
            {
                SplashScreenTimer.Stop();
                Main dashboard = new Main();
                dashboard.Show();
                this.Hide();
            }
        }
    }
}
