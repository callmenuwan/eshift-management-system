namespace eshift_management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Panel();
            userNameLabel = new Label();
            cusAddJobViewBtn = new Button();
            viewCusDashboardBtn = new Button();
            viewJobEditBtn = new Button();
            viewCustomersBtn = new Button();
            viewCusAddBtn = new Button();
            viewAdminJobsBtn = new Button();
            viewAdminDashboardBtn = new Button();
            closeBtn = new Button();
            panelMain = new Panel();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.Highlight;
            sidePanel.Controls.Add(userNameLabel);
            sidePanel.Controls.Add(cusAddJobViewBtn);
            sidePanel.Controls.Add(viewCusDashboardBtn);
            sidePanel.Controls.Add(viewJobEditBtn);
            sidePanel.Controls.Add(viewCustomersBtn);
            sidePanel.Controls.Add(viewCusAddBtn);
            sidePanel.Controls.Add(viewAdminJobsBtn);
            sidePanel.Controls.Add(viewAdminDashboardBtn);
            sidePanel.Controls.Add(closeBtn);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(226, 729);
            sidePanel.TabIndex = 0;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(12, 629);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(70, 31);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "Name";
            userNameLabel.Click += userNameLabel_Click;
            // 
            // cusAddJobViewBtn
            // 
            cusAddJobViewBtn.Anchor = AnchorStyles.None;
            cusAddJobViewBtn.BackColor = Color.DeepSkyBlue;
            cusAddJobViewBtn.FlatAppearance.BorderSize = 0;
            cusAddJobViewBtn.FlatStyle = FlatStyle.Flat;
            cusAddJobViewBtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cusAddJobViewBtn.ForeColor = Color.White;
            cusAddJobViewBtn.Location = new Point(12, 161);
            cusAddJobViewBtn.Name = "cusAddJobViewBtn";
            cusAddJobViewBtn.Size = new Size(196, 38);
            cusAddJobViewBtn.TabIndex = 8;
            cusAddJobViewBtn.Text = "Add Job";
            cusAddJobViewBtn.UseVisualStyleBackColor = false;
            cusAddJobViewBtn.Click += cusAddJobViewBtn_Click;
            // 
            // viewCusDashboardBtn
            // 
            viewCusDashboardBtn.Anchor = AnchorStyles.None;
            viewCusDashboardBtn.BackColor = Color.DeepSkyBlue;
            viewCusDashboardBtn.FlatAppearance.BorderSize = 0;
            viewCusDashboardBtn.FlatStyle = FlatStyle.Flat;
            viewCusDashboardBtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewCusDashboardBtn.ForeColor = Color.White;
            viewCusDashboardBtn.Location = new Point(12, 117);
            viewCusDashboardBtn.Name = "viewCusDashboardBtn";
            viewCusDashboardBtn.Size = new Size(196, 38);
            viewCusDashboardBtn.TabIndex = 7;
            viewCusDashboardBtn.Text = "Dashboard";
            viewCusDashboardBtn.UseVisualStyleBackColor = false;
            viewCusDashboardBtn.Click += viewCusDashboardBtn_Click;
            // 
            // viewJobEditBtn
            // 
            viewJobEditBtn.Anchor = AnchorStyles.None;
            viewJobEditBtn.BackColor = Color.DeepSkyBlue;
            viewJobEditBtn.FlatAppearance.BorderSize = 0;
            viewJobEditBtn.FlatStyle = FlatStyle.Flat;
            viewJobEditBtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewJobEditBtn.ForeColor = Color.White;
            viewJobEditBtn.Location = new Point(12, 205);
            viewJobEditBtn.Name = "viewJobEditBtn";
            viewJobEditBtn.Size = new Size(196, 38);
            viewJobEditBtn.TabIndex = 6;
            viewJobEditBtn.Text = "Edit Job";
            viewJobEditBtn.UseVisualStyleBackColor = false;
            // 
            // viewCustomersBtn
            // 
            viewCustomersBtn.Anchor = AnchorStyles.None;
            viewCustomersBtn.BackColor = Color.DeepSkyBlue;
            viewCustomersBtn.FlatAppearance.BorderSize = 0;
            viewCustomersBtn.FlatStyle = FlatStyle.Flat;
            viewCustomersBtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewCustomersBtn.ForeColor = Color.White;
            viewCustomersBtn.Location = new Point(12, 249);
            viewCustomersBtn.Name = "viewCustomersBtn";
            viewCustomersBtn.Size = new Size(196, 38);
            viewCustomersBtn.TabIndex = 5;
            viewCustomersBtn.Text = "Customers";
            viewCustomersBtn.UseVisualStyleBackColor = false;
            // 
            // viewCusAddBtn
            // 
            viewCusAddBtn.Anchor = AnchorStyles.None;
            viewCusAddBtn.BackColor = Color.DeepSkyBlue;
            viewCusAddBtn.FlatAppearance.BorderSize = 0;
            viewCusAddBtn.FlatStyle = FlatStyle.Flat;
            viewCusAddBtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewCusAddBtn.ForeColor = Color.White;
            viewCusAddBtn.Location = new Point(12, 293);
            viewCusAddBtn.Name = "viewCusAddBtn";
            viewCusAddBtn.Size = new Size(196, 38);
            viewCusAddBtn.TabIndex = 4;
            viewCusAddBtn.Text = "Add Customer";
            viewCusAddBtn.UseVisualStyleBackColor = false;
            viewCusAddBtn.Click += viewCusAddBtn_Click;
            // 
            // viewAdminJobsBtn
            // 
            viewAdminJobsBtn.Anchor = AnchorStyles.None;
            viewAdminJobsBtn.BackColor = Color.DeepSkyBlue;
            viewAdminJobsBtn.FlatAppearance.BorderSize = 0;
            viewAdminJobsBtn.FlatStyle = FlatStyle.Flat;
            viewAdminJobsBtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAdminJobsBtn.ForeColor = Color.White;
            viewAdminJobsBtn.Location = new Point(12, 161);
            viewAdminJobsBtn.Name = "viewAdminJobsBtn";
            viewAdminJobsBtn.Size = new Size(196, 38);
            viewAdminJobsBtn.TabIndex = 3;
            viewAdminJobsBtn.Text = "Jobs";
            viewAdminJobsBtn.UseVisualStyleBackColor = false;
            viewAdminJobsBtn.Click += viewAdminJobsBtn_Click;
            // 
            // viewAdminDashboardBtn
            // 
            viewAdminDashboardBtn.Anchor = AnchorStyles.None;
            viewAdminDashboardBtn.BackColor = Color.DeepSkyBlue;
            viewAdminDashboardBtn.FlatAppearance.BorderSize = 0;
            viewAdminDashboardBtn.FlatStyle = FlatStyle.Flat;
            viewAdminDashboardBtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAdminDashboardBtn.ForeColor = Color.White;
            viewAdminDashboardBtn.Location = new Point(12, 117);
            viewAdminDashboardBtn.Name = "viewAdminDashboardBtn";
            viewAdminDashboardBtn.Size = new Size(196, 38);
            viewAdminDashboardBtn.TabIndex = 2;
            viewAdminDashboardBtn.Text = "Dashboard";
            viewAdminDashboardBtn.UseVisualStyleBackColor = false;
            viewAdminDashboardBtn.Click += viewAdminDashboardBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.None;
            closeBtn.BackColor = Color.White;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.ForeColor = SystemColors.ActiveCaptionText;
            closeBtn.Location = new Point(12, 681);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(196, 38);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "Logout";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Transparent;
            panelMain.Location = new Point(246, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1094, 705);
            panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            BackColor = Color.Azure;
            ClientSize = new Size(1352, 729);
            Controls.Add(panelMain);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox loginRole;
        private Button loginBtn;
        private TextBox loginPassword;
        private Panel sidePanel;
        private Button closeBtn;
        private Panel panelMain;
        private Button viewAdminDashboardBtn;
        private Button viewCusAddBtn;
        private Button viewAdminJobsBtn;
        private Button viewCustomersBtn;
        private Button viewJobEditBtn;
        private Button viewCusDashboardBtn;
        private Button cusAddJobViewBtn;
        private Label userNameLabel;
    }
}
