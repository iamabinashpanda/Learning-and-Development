using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Application
{
    public partial class SplashScreenForm : Form
    {
        private Timer timer;
        public SplashScreenForm()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                SplashScreenProgressBar.Value = i;
                if (i == 100)
                    break;
            }

            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
            //Application.Exit();
            

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            // Close the splash screen
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
