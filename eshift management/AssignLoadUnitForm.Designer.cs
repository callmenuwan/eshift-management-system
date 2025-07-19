namespace eshift_management
{
    partial class AssignLoadUnitForm
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            jobDatePicker = new DateTimePicker();
            curStatus = new TextBox();
            JobID = new TextBox();
            dgvLoadAssignments = new DataGridView();
            LoadID = new DataGridViewTextBoxColumn();
            DriverColumn = new DataGridViewComboBoxColumn();
            AssistantColumn = new DataGridViewComboBoxColumn();
            LorryColumn = new DataGridViewComboBoxColumn();
            ContainerColumn = new DataGridViewComboBoxColumn();
            assignUnitsbtn = new Button();
            dgvNext7DaysAvailability = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLoadAssignments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNext7DaysAvailability).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(553, 28);
            label8.Name = "label8";
            label8.Size = new Size(186, 36);
            label8.TabIndex = 27;
            label8.Text = "Job Current Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(279, 28);
            label7.Name = "label7";
            label7.Size = new Size(78, 36);
            label7.TabIndex = 26;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(96, 28);
            label6.Name = "label6";
            label6.Size = new Size(78, 36);
            label6.TabIndex = 25;
            label6.Text = "Job ID";
            // 
            // jobDatePicker
            // 
            jobDatePicker.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobDatePicker.Location = new Point(745, 26);
            jobDatePicker.Name = "jobDatePicker";
            jobDatePicker.Size = new Size(381, 37);
            jobDatePicker.TabIndex = 24;
            jobDatePicker.ValueChanged += jobDatePicker_ValueChanged;
            // 
            // curStatus
            // 
            curStatus.BorderStyle = BorderStyle.FixedSingle;
            curStatus.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            curStatus.Location = new Point(363, 28);
            curStatus.Name = "curStatus";
            curStatus.Size = new Size(158, 37);
            curStatus.TabIndex = 23;
            // 
            // JobID
            // 
            JobID.BorderStyle = BorderStyle.FixedSingle;
            JobID.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobID.Location = new Point(180, 27);
            JobID.Name = "JobID";
            JobID.Size = new Size(59, 37);
            JobID.TabIndex = 22;
            // 
            // dgvLoadAssignments
            // 
            dgvLoadAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoadAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoadAssignments.Columns.AddRange(new DataGridViewColumn[] { LoadID, DriverColumn, AssistantColumn, LorryColumn, ContainerColumn });
            dgvLoadAssignments.Location = new Point(3, 80);
            dgvLoadAssignments.Name = "dgvLoadAssignments";
            dgvLoadAssignments.RowHeadersWidth = 51;
            dgvLoadAssignments.Size = new Size(1304, 322);
            dgvLoadAssignments.TabIndex = 28;
            // 
            // LoadID
            // 
            LoadID.HeaderText = "Load ID";
            LoadID.MinimumWidth = 6;
            LoadID.Name = "LoadID";
            LoadID.ReadOnly = true;
            // 
            // DriverColumn
            // 
            DriverColumn.HeaderText = "Driver";
            DriverColumn.MinimumWidth = 6;
            DriverColumn.Name = "DriverColumn";
            // 
            // AssistantColumn
            // 
            AssistantColumn.HeaderText = "Assistant";
            AssistantColumn.MinimumWidth = 6;
            AssistantColumn.Name = "AssistantColumn";
            // 
            // LorryColumn
            // 
            LorryColumn.HeaderText = "Lorry";
            LorryColumn.MinimumWidth = 6;
            LorryColumn.Name = "LorryColumn";
            // 
            // ContainerColumn
            // 
            ContainerColumn.HeaderText = "Container";
            ContainerColumn.MinimumWidth = 6;
            ContainerColumn.Name = "ContainerColumn";
            // 
            // assignUnitsbtn
            // 
            assignUnitsbtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignUnitsbtn.Location = new Point(528, 435);
            assignUnitsbtn.Name = "assignUnitsbtn";
            assignUnitsbtn.Size = new Size(165, 60);
            assignUnitsbtn.TabIndex = 29;
            assignUnitsbtn.Text = "Assign";
            assignUnitsbtn.UseVisualStyleBackColor = true;
            assignUnitsbtn.Click += assignUnitsbtn_Click;
            // 
            // dgvNext7DaysAvailability
            // 
            dgvNext7DaysAvailability.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNext7DaysAvailability.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNext7DaysAvailability.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNext7DaysAvailability.Dock = DockStyle.Bottom;
            dgvNext7DaysAvailability.Location = new Point(0, 553);
            dgvNext7DaysAvailability.Name = "dgvNext7DaysAvailability";
            dgvNext7DaysAvailability.RowHeadersWidth = 51;
            dgvNext7DaysAvailability.Size = new Size(1308, 235);
            dgvNext7DaysAvailability.TabIndex = 30;
            // 
            // AssignLoadUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 788);
            Controls.Add(dgvNext7DaysAvailability);
            Controls.Add(assignUnitsbtn);
            Controls.Add(dgvLoadAssignments);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(jobDatePicker);
            Controls.Add(curStatus);
            Controls.Add(JobID);
            Name = "AssignLoadUnitForm";
            Text = "AssignLoadUnitForm";
            Load += AssignLoadUnitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoadAssignments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNext7DaysAvailability).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker jobDatePicker;
        private TextBox curStatus;
        private TextBox JobID;
        private DataGridView dgvLoadAssignments;
        private DataGridViewTextBoxColumn LoadID;
        private DataGridViewComboBoxColumn DriverColumn;
        private DataGridViewComboBoxColumn AssistantColumn;
        private DataGridViewComboBoxColumn LorryColumn;
        private DataGridViewComboBoxColumn ContainerColumn;
        private Button assignUnitsbtn;
        private DataGridView dgvNext7DaysAvailability;
    }
}