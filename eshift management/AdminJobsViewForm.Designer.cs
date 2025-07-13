namespace eshift_management
{
    partial class AdminJobsViewForm
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
            dgvJobs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // dgvJobs
            // 
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Dock = DockStyle.Fill;
            dgvJobs.Location = new Point(0, 0);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.Size = new Size(998, 544);
            dgvJobs.TabIndex = 0;
            dgvJobs.CellContentClick += dgvJobs_CellContentClick;
            // 
            // AdminJobsViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 544);
            Controls.Add(dgvJobs);
            Name = "AdminJobsViewForm";
            Text = "AdminJobsViewForm";
            Load += AdminJobsViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJobs;
    }
}