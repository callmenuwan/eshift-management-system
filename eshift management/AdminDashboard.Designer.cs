namespace eshift_management
{
    partial class AdminDashboard
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
            cusRegFormBtn = new Button();
            untiAssignFormBtn = new Button();
            SuspendLayout();
            // 
            // cusRegFormBtn
            // 
            cusRegFormBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusRegFormBtn.Location = new Point(148, 198);
            cusRegFormBtn.Name = "cusRegFormBtn";
            cusRegFormBtn.Size = new Size(278, 60);
            cusRegFormBtn.TabIndex = 2;
            cusRegFormBtn.Text = "Customer Register";
            cusRegFormBtn.UseVisualStyleBackColor = true;
            cusRegFormBtn.Click += cusRegFormBtn_Click;
            // 
            // untiAssignFormBtn
            // 
            untiAssignFormBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            untiAssignFormBtn.Location = new Point(148, 314);
            untiAssignFormBtn.Name = "untiAssignFormBtn";
            untiAssignFormBtn.Size = new Size(278, 60);
            untiAssignFormBtn.TabIndex = 3;
            untiAssignFormBtn.Text = "Assign Transport Unit";
            untiAssignFormBtn.UseVisualStyleBackColor = true;
            untiAssignFormBtn.Click += untiAssignFormBtn_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(untiAssignFormBtn);
            Controls.Add(cusRegFormBtn);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button cusRegFormBtn;
        private Button untiAssignFormBtn;
    }
}