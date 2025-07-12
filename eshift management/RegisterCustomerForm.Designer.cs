namespace eshift_management
{
    partial class RegisterCustomerForm
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
            cusRegName = new TextBox();
            Namex = new Label();
            cusRegBtn = new Button();
            cusRegEmail = new TextBox();
            cusRegPassword = new TextBox();
            Passwordx = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cusRegName
            // 
            cusRegName.BorderStyle = BorderStyle.FixedSingle;
            cusRegName.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusRegName.Location = new Point(280, 115);
            cusRegName.Name = "cusRegName";
            cusRegName.Size = new Size(278, 37);
            cusRegName.TabIndex = 4;
            // 
            // Namex
            // 
            Namex.AutoSize = true;
            Namex.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Namex.Location = new Point(144, 117);
            Namex.Name = "Namex";
            Namex.Size = new Size(76, 36);
            Namex.TabIndex = 5;
            Namex.Text = "Name";
            // 
            // cusRegBtn
            // 
            cusRegBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusRegBtn.Location = new Point(280, 327);
            cusRegBtn.Name = "cusRegBtn";
            cusRegBtn.Size = new Size(278, 60);
            cusRegBtn.TabIndex = 6;
            cusRegBtn.Text = "Register";
            cusRegBtn.UseVisualStyleBackColor = true;
            cusRegBtn.Click += cusRegBtn_Click;
            // 
            // cusRegEmail
            // 
            cusRegEmail.BorderStyle = BorderStyle.FixedSingle;
            cusRegEmail.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusRegEmail.Location = new Point(280, 174);
            cusRegEmail.Name = "cusRegEmail";
            cusRegEmail.Size = new Size(278, 37);
            cusRegEmail.TabIndex = 7;
            // 
            // cusRegPassword
            // 
            cusRegPassword.BorderStyle = BorderStyle.FixedSingle;
            cusRegPassword.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusRegPassword.Location = new Point(280, 245);
            cusRegPassword.Name = "cusRegPassword";
            cusRegPassword.Size = new Size(278, 37);
            cusRegPassword.TabIndex = 8;
            // 
            // Passwordx
            // 
            Passwordx.AutoSize = true;
            Passwordx.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passwordx.Location = new Point(144, 247);
            Passwordx.Name = "Passwordx";
            Passwordx.Size = new Size(111, 36);
            Passwordx.TabIndex = 9;
            Passwordx.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 176);
            label3.Name = "label3";
            label3.Size = new Size(70, 36);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // RegisterCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Passwordx);
            Controls.Add(cusRegPassword);
            Controls.Add(cusRegEmail);
            Controls.Add(cusRegBtn);
            Controls.Add(Namex);
            Controls.Add(cusRegName);
            Name = "RegisterCustomerForm";
            Text = "RegisterCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cusRegName;
        private Label Namex;
        private Button cusRegBtn;
        private TextBox cusRegEmail;
        private TextBox cusRegPassword;
        private Label Passwordx;
        private Label label3;
    }
}