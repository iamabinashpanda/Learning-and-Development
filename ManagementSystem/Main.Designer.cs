namespace ManagementSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ContactUsButton = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DesignationLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FormLoaderPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.FooterCopyrightsLabel = new System.Windows.Forms.Label();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NavTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.NavPanel);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.ContactUsButton);
            this.panel1.Controls.Add(this.CalendarButton);
            this.panel1.Controls.Add(this.EmployeeButton);
            this.panel1.Controls.Add(this.DashboardButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 710);
            this.panel1.TabIndex = 0;
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NavPanel.Location = new System.Drawing.Point(0, 238);
            this.NavPanel.Margin = new System.Windows.Forms.Padding(4);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(4, 123);
            this.NavPanel.TabIndex = 3;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LogOutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.Image")));
            this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOutButton.Location = new System.Drawing.Point(0, 650);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.LogOutButton.Size = new System.Drawing.Size(248, 60);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            this.LogOutButton.Leave += new System.EventHandler(this.LogOutButton_Leave);
            // 
            // ContactUsButton
            // 
            this.ContactUsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactUsButton.FlatAppearance.BorderSize = 0;
            this.ContactUsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactUsButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactUsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ContactUsButton.Image = ((System.Drawing.Image)(resources.GetObject("ContactUsButton.Image")));
            this.ContactUsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ContactUsButton.Location = new System.Drawing.Point(0, 351);
            this.ContactUsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ContactUsButton.Name = "ContactUsButton";
            this.ContactUsButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.ContactUsButton.Size = new System.Drawing.Size(248, 65);
            this.ContactUsButton.TabIndex = 1;
            this.ContactUsButton.Text = "Contact Us";
            this.ContactUsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactUsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ContactUsButton.UseVisualStyleBackColor = true;
            this.ContactUsButton.Click += new System.EventHandler(this.ContactUsButton_Click);
            this.ContactUsButton.Leave += new System.EventHandler(this.ContactUsButton_Leave);
            // 
            // CalendarButton
            // 
            this.CalendarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendarButton.FlatAppearance.BorderSize = 0;
            this.CalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CalendarButton.Image = ((System.Drawing.Image)(resources.GetObject("CalendarButton.Image")));
            this.CalendarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CalendarButton.Location = new System.Drawing.Point(0, 286);
            this.CalendarButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.CalendarButton.Size = new System.Drawing.Size(248, 65);
            this.CalendarButton.TabIndex = 1;
            this.CalendarButton.Text = "Calendar";
            this.CalendarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalendarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CalendarButton.UseVisualStyleBackColor = true;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            this.CalendarButton.Leave += new System.EventHandler(this.CalendarButton_Leave);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeButton.FlatAppearance.BorderSize = 0;
            this.EmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.EmployeeButton.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeButton.Image")));
            this.EmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmployeeButton.Location = new System.Drawing.Point(0, 221);
            this.EmployeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.EmployeeButton.Size = new System.Drawing.Size(248, 65);
            this.EmployeeButton.TabIndex = 1;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            this.EmployeeButton.Leave += new System.EventHandler(this.EmployeeButton_Leave);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.DashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardButton.Image")));
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardButton.Location = new System.Drawing.Point(0, 145);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(4);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.DashboardButton.Size = new System.Drawing.Size(248, 76);
            this.DashboardButton.TabIndex = 1;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            this.DashboardButton.Leave += new System.EventHandler(this.DashboardButton_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LastNameLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.DesignationLabel);
            this.panel2.Controls.Add(this.FirstNameLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 145);
            this.panel2.TabIndex = 0;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LastNameLabel.Location = new System.Drawing.Point(13, 95);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(92, 24);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(93, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // DesignationLabel
            // 
            this.DesignationLabel.AutoSize = true;
            this.DesignationLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.DesignationLabel.Location = new System.Drawing.Point(14, 122);
            this.DesignationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DesignationLabel.Name = "DesignationLabel";
            this.DesignationLabel.Size = new System.Drawing.Size(109, 17);
            this.DesignationLabel.TabIndex = 2;
            this.DesignationLabel.Text = "Designation here";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 70);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(95, 24);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "FirstName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FormLoaderPanel);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 710);
            this.panel3.TabIndex = 1;
            // 
            // FormLoaderPanel
            // 
            this.FormLoaderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FormLoaderPanel.Location = new System.Drawing.Point(0, 80);
            this.FormLoaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FormLoaderPanel.Name = "FormLoaderPanel";
            this.FormLoaderPanel.Size = new System.Drawing.Size(1020, 597);
            this.FormLoaderPanel.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.FooterCopyrightsLabel);
            this.panel7.Controls.Add(this.DateTimeLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 677);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1020, 33);
            this.panel7.TabIndex = 6;
            // 
            // FooterCopyrightsLabel
            // 
            this.FooterCopyrightsLabel.AutoSize = true;
            this.FooterCopyrightsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.FooterCopyrightsLabel.Location = new System.Drawing.Point(404, 6);
            this.FooterCopyrightsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FooterCopyrightsLabel.Name = "FooterCopyrightsLabel";
            this.FooterCopyrightsLabel.Size = new System.Drawing.Size(256, 16);
            this.FooterCopyrightsLabel.TabIndex = 8;
            this.FooterCopyrightsLabel.Text = "Copyrights (C) iamabinashpanda.github.io";
            this.FooterCopyrightsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.DateTimeLabel.Location = new System.Drawing.Point(4, 6);
            this.DateTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(67, 16);
            this.DateTimeLabel.TabIndex = 7;
            this.DateTimeLabel.Text = "DateTime";
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(957, 13);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 55);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dashboard";
            // 
            // NavTimer
            // 
            this.NavTimer.Enabled = true;
            this.NavTimer.Tick += new System.EventHandler(this.NavTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1268, 710);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ContactUsButton;
        private System.Windows.Forms.Button CalendarButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DesignationLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Timer NavTimer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Label FooterCopyrightsLabel;
        private System.Windows.Forms.Panel FormLoaderPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LastNameLabel;
    }
}