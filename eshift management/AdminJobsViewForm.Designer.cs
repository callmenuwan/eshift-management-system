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
            dgvAllJobs = new DataGridView();
            cmbStatusFilter = new ComboBox();
            filterBtn = new Button();
            label4 = new Label();
            createLoadsBtn = new Button();
            delineBtn = new Button();
            assignUnitsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllJobs).BeginInit();
            SuspendLayout();
            // 
            // dgvAllJobs
            // 
            dgvAllJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllJobs.BackgroundColor = Color.Azure;
            dgvAllJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllJobs.Location = new Point(12, 77);
            dgvAllJobs.MultiSelect = false;
            dgvAllJobs.Name = "dgvAllJobs";
            dgvAllJobs.ReadOnly = true;
            dgvAllJobs.RowHeadersWidth = 51;
            dgvAllJobs.Size = new Size(986, 299);
            dgvAllJobs.TabIndex = 1;
            dgvAllJobs.SelectionChanged += dgvAllJobs_SelectionChanged;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbStatusFilter.Location = new Point(183, 6);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(278, 44);
            cmbStatusFilter.TabIndex = 3;
            // 
            // filterBtn
            // 
            filterBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBtn.Location = new Point(467, 5);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(165, 44);
            filterBtn.TabIndex = 21;
            filterBtn.Text = "Apply Filter";
            filterBtn.UseVisualStyleBackColor = true;
            filterBtn.Click += filterBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(165, 36);
            label4.TabIndex = 22;
            label4.Text = "Filter by Status:";
            // 
            // createLoadsBtn
            // 
            createLoadsBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createLoadsBtn.Location = new Point(12, 416);
            createLoadsBtn.Name = "createLoadsBtn";
            createLoadsBtn.Size = new Size(165, 60);
            createLoadsBtn.TabIndex = 23;
            createLoadsBtn.Text = "Create Loads";
            createLoadsBtn.UseVisualStyleBackColor = true;
            createLoadsBtn.Click += createLoadsBtn_Click;
            // 
            // delineBtn
            // 
            delineBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delineBtn.Location = new Point(354, 416);
            delineBtn.Name = "delineBtn";
            delineBtn.Size = new Size(165, 60);
            delineBtn.TabIndex = 24;
            delineBtn.Text = "Decline Job";
            delineBtn.UseVisualStyleBackColor = true;
            delineBtn.Click += delineBtn_Click;
            // 
            // assignUnitsBtn
            // 
            assignUnitsBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignUnitsBtn.Location = new Point(183, 416);
            assignUnitsBtn.Name = "assignUnitsBtn";
            assignUnitsBtn.Size = new Size(165, 60);
            assignUnitsBtn.TabIndex = 25;
            assignUnitsBtn.Text = "Assign Units";
            assignUnitsBtn.UseVisualStyleBackColor = true;
            assignUnitsBtn.Click += assignUnitsBtn_Click;
            // 
            // AdminJobsViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1013, 496);
            Controls.Add(assignUnitsBtn);
            Controls.Add(delineBtn);
            Controls.Add(createLoadsBtn);
            Controls.Add(label4);
            Controls.Add(filterBtn);
            Controls.Add(cmbStatusFilter);
            Controls.Add(dgvAllJobs);
            Name = "AdminJobsViewForm";
            Text = "AdminJobsViewForm";
            Load += AdminJobsViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvAllJobs;
        private ComboBox cmbStatusFilter;
        private Button filterBtn;
        private Label label4;
        private Button createLoadsBtn;
        private Button delineBtn;
        private Button assignUnitsBtn;
    }
}