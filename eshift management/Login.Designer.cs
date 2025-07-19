namespace eshift_management
{
    partial class Login
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
            label1 = new Label();
            loginBtn = new Button();
            loginRole = new ComboBox();
            loginEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            loginPassword = new TextBox();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(194, 85);
            label1.Name = "label1";
            label1.Size = new Size(70, 36);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.None;
            loginBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(194, 298);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(402, 60);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginRole
            // 
            loginRole.Anchor = AnchorStyles.None;
            loginRole.FlatStyle = FlatStyle.Flat;
            loginRole.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginRole.FormattingEnabled = true;
            loginRole.Items.AddRange(new object[] { "Admin", "Customer" });
            loginRole.Location = new Point(318, 220);
            loginRole.Name = "loginRole";
            loginRole.Size = new Size(278, 44);
            loginRole.TabIndex = 2;
            // 
            // loginEmail
            // 
            loginEmail.Anchor = AnchorStyles.None;
            loginEmail.BorderStyle = BorderStyle.None;
            loginEmail.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginEmail.Location = new Point(318, 85);
            loginEmail.Name = "loginEmail";
            loginEmail.Size = new Size(278, 30);
            loginEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(194, 155);
            label2.Name = "label2";
            label2.Size = new Size(111, 36);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(194, 220);
            label3.Name = "label3";
            label3.Size = new Size(57, 36);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // loginPassword
            // 
            loginPassword.Anchor = AnchorStyles.None;
            loginPassword.BorderStyle = BorderStyle.None;
            loginPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPassword.Location = new Point(318, 155);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(278, 30);
            loginPassword.TabIndex = 6;
            // 
            // closeBtn
            // 
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.Location = new Point(769, 2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(30, 30);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(loginPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loginEmail);
            Controls.Add(loginRole);
            Controls.Add(loginBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button loginBtn;
        private ComboBox loginRole;
        private TextBox loginEmail;
        private Label label2;
        private Label label3;
        private TextBox loginPassword;
        private Button closeBtn;
    }
}