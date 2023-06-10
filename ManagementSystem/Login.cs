using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(SelectRoleComboBox.Text.ToLower()=="admin")
            {

            }
            else if(SelectRoleComboBox.Text.ToLower() =="user")
            {

            }
            else 
            {
                MessageBox.Show("Invalid User or Admin.");
            }
        }
    }
}
