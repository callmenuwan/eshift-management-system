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
            dgvCusJobs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCusJobs).BeginInit();
            SuspendLayout();
            // 
            // jobFormBtn
            // 
            jobFormBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobFormBtn.Location = new Point(387, 328);
            jobFormBtn.Name = "jobFormBtn";
            jobFormBtn.Size = new Size(278, 60);
            jobFormBtn.TabIndex = 3;
            jobFormBtn.Text = "Add Job";
            jobFormBtn.UseVisualStyleBackColor = true;
            jobFormBtn.Click += jobFormBtn_Click;
            // 
            // dgvCusJobs
            // 
            dgvCusJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCusJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCusJobs.Dock = DockStyle.Top;
            dgvCusJobs.Location = new Point(0, 0);
            dgvCusJobs.Name = "dgvCusJobs";
            dgvCusJobs.RowHeadersWidth = 51;
            dgvCusJobs.Size = new Size(800, 293);
            dgvCusJobs.TabIndex = 4;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCusJobs);
            Controls.Add(jobFormBtn);
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            Load += CustomerDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCusJobs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button jobFormBtn;
        private DataGridView dgvCusJobs;
    }
}