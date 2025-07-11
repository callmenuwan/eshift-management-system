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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 98);
            label1.Name = "label1";
            label1.Size = new Size(70, 36);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(245, 314);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(278, 60);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginRole
            // 
            loginRole.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginRole.FormattingEnabled = true;
            loginRole.Items.AddRange(new object[] { "Admin", "Customer" });
            loginRole.Location = new Point(245, 231);
            loginRole.Name = "loginRole";
            loginRole.Size = new Size(278, 44);
            loginRole.TabIndex = 2;
            // 
            // loginEmail
            // 
            loginEmail.BorderStyle = BorderStyle.FixedSingle;
            loginEmail.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginEmail.Location = new Point(245, 96);
            loginEmail.Name = "loginEmail";
            loginEmail.Size = new Size(278, 37);
            loginEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 168);
            label2.Name = "label2";
            label2.Size = new Size(111, 36);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(121, 239);
            label3.Name = "label3";
            label3.Size = new Size(57, 36);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // loginPassword
            // 
            loginPassword.BorderStyle = BorderStyle.FixedSingle;
            loginPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPassword.Location = new Point(245, 166);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(278, 37);
            loginPassword.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loginEmail);
            Controls.Add(loginRole);
            Controls.Add(loginBtn);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
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
    }
}