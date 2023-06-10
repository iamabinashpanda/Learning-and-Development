using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ManagementSystem
{
    public partial class Main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthRect,
            int nHeightRect
            );
        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            NavPanel.Height = DashboardButton.Height;
            NavPanel.Top = DashboardButton.Top;
            NavPanel.Left = DashboardButton.Left;
            DashboardButton.BackColor = Color.FromArgb(46, 51, 73);
            NavTimer.Start();

            label3.Text = DashboardButton.Text;
            this.FormLoaderPanel.Controls.Clear();
            Dashboard dashboard = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.FormLoaderPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            NavPanel.Height = DashboardButton.Height;
            NavPanel.Top = DashboardButton.Top;
            NavPanel.Left = DashboardButton.Left;
            DashboardButton.BackColor = Color.FromArgb(46, 51, 73);
            
            label3.Text = DashboardButton.Text;
            this.FormLoaderPanel.Controls.Clear();
            Dashboard dashboard = new Dashboard() { Dock = DockStyle.Fill, TopLevel=false, TopMost=true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.FormLoaderPanel.Controls.Add( dashboard );
            dashboard.Show();

        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            NavPanel.Height = EmployeeButton.Height;
            NavPanel.Top = EmployeeButton.Top;
            NavPanel.Left = EmployeeButton.Left;
            EmployeeButton.BackColor = Color.FromArgb(46, 51, 73);

            label3.Text = EmployeeButton.Text;
            this.FormLoaderPanel.Controls.Clear();
            Employee employee = new Employee() { Dock = DockStyle.None, TopLevel=false, TopMost=true };
            employee.FormBorderStyle = FormBorderStyle.None;
            this.FormLoaderPanel.Controls.Add(employee); 
            employee.Show();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            NavPanel.Height = CalendarButton.Height;
            NavPanel.Top = CalendarButton.Top;
            NavPanel.Left = CalendarButton.Left;
            CalendarButton.BackColor = Color.FromArgb(46, 51, 73);
            
            label3.Text = CalendarButton.Text;
            this.FormLoaderPanel.Controls.Clear();
            Calendar calendar = new Calendar() { Dock = DockStyle.None, TopLevel = false, TopMost = true };
            calendar.FormBorderStyle = FormBorderStyle.None;
            this.FormLoaderPanel.Controls.Add(calendar);
            calendar.Show();
        }
        private void ContactUsButton_Click(object sender, EventArgs e)
        {
            NavPanel.Height = ContactUsButton.Height;
            NavPanel.Top = ContactUsButton.Top;
            NavPanel.Left = ContactUsButton.Left;
            ContactUsButton.BackColor = Color.FromArgb(46, 51, 73);

            label3.Text = ContactUsButton.Text;
            this.FormLoaderPanel.Controls.Clear();
            ContactUs contactUs = new ContactUs() { Dock = DockStyle.None, TopLevel = false, TopMost = true };
            contactUs.FormBorderStyle = FormBorderStyle.None;
            this.FormLoaderPanel.Controls.Add(contactUs);
            contactUs.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            NavPanel.Height = LogOutButton.Height;
            NavPanel.Top = LogOutButton.Top;
            NavPanel.Left = LogOutButton.Left;
            LogOutButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void DashboardButton_Leave(object sender, EventArgs e)
        {
            DashboardButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void EmployeeButton_Leave(object sender, EventArgs e)
        {
            EmployeeButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void CalendarButton_Leave(object sender, EventArgs e)
        {
            CalendarButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ContactUsButton_Leave(object sender, EventArgs e)
        {
            ContactUsButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void LogOutButton_Leave(object sender, EventArgs e)
        {
            LogOutButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void NavTimer_Tick(object sender, EventArgs e)
        {
            DateTimeLabel.Text = DateTime.Now.ToString("dd-MMMM, yyyy hh:mm:ss tt");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
