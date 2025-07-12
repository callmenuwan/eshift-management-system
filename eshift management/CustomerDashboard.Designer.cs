namespace eshift_management
{
    partial class CustomerDashboard
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
            jobFormBtn = new Button();
            SuspendLayout();
            // 
            // jobFormBtn
            // 
            jobFormBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobFormBtn.Location = new Point(261, 195);
            jobFormBtn.Name = "jobFormBtn";
            jobFormBtn.Size = new Size(278, 60);
            jobFormBtn.TabIndex = 3;
            jobFormBtn.Text = "Add Job";
            jobFormBtn.UseVisualStyleBackColor = true;
            jobFormBtn.Click += jobFormBtn_Click;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(jobFormBtn);
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button jobFormBtn;
    }
}