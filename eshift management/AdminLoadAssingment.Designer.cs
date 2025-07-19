namespace eshift_management
{
    partial class AdminLoadAssingment
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
            assignUnitsbtn = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            jobDatePicker = new DateTimePicker();
            curStatus = new TextBox();
            JobID = new TextBox();
            loadIDCombo = new ComboBox();
            cmbDriver = new ComboBox();
            cmbAssistant = new ComboBox();
            cmbLorry = new ComboBox();
            cmbContainer = new ComboBox();
            dgvNext7DaysAvailability = new DataGridView();
            dgvAssignments = new DataGridView();
            LoadID = new DataGridViewTextBoxColumn();
            DriverID = new DataGridViewTextBoxColumn();
            AssistantID = new DataGridViewTextBoxColumn();
            LorryID = new DataGridViewTextBoxColumn();
            ContainerID = new DataGridViewTextBoxColumn();
            jobAcceptBtn = new Button();
            jobDeclineBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNext7DaysAvailability).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            SuspendLayout();
            // 
            // assignUnitsbtn
            // 
            assignUnitsbtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignUnitsbtn.Location = new Point(881, 67);
            assignUnitsbtn.Name = "assignUnitsbtn";
            assignUnitsbtn.Size = new Size(197, 44);
            assignUnitsbtn.TabIndex = 30;
            assignUnitsbtn.Text = "Assign to load";
            assignUnitsbtn.UseVisualStyleBackColor = true;
            assignUnitsbtn.Click += assignUnitsbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(467, 3);
            label8.Name = "label8";
            label8.Size = new Size(186, 36);
            label8.TabIndex = 36;
            label8.Text = "Job Current Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(163, 5);
            label7.Name = "label7";
            label7.Size = new Size(78, 36);
            label7.TabIndex = 35;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 5);
            label6.Name = "label6";
            label6.Size = new Size(78, 36);
            label6.TabIndex = 34;
            label6.Text = "Job ID";
            // 
            // jobDatePicker
            // 
            jobDatePicker.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobDatePicker.Location = new Point(659, 3);
            jobDatePicker.Name = "jobDatePicker";
            jobDatePicker.Size = new Size(419, 37);
            jobDatePicker.TabIndex = 33;
            jobDatePicker.ValueChanged += jobDatePicker_ValueChanged;
            // 
            // curStatus
            // 
            curStatus.BorderStyle = BorderStyle.FixedSingle;
            curStatus.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            curStatus.Location = new Point(247, 5);
            curStatus.Name = "curStatus";
            curStatus.Size = new Size(158, 37);
            curStatus.TabIndex = 32;
            // 
            // JobID
            // 
            JobID.BorderStyle = BorderStyle.FixedSingle;
            JobID.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobID.Location = new Point(84, 4);
            JobID.Name = "JobID";
            JobID.Size = new Size(59, 37);
            JobID.TabIndex = 31;
            // 
            // loadIDCombo
            // 
            loadIDCombo.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadIDCombo.FormattingEnabled = true;
            loadIDCombo.Items.AddRange(new object[] { "Admin", "Customer" });
            loadIDCombo.Location = new Point(9, 67);
            loadIDCombo.Name = "loadIDCombo";
            loadIDCombo.Size = new Size(95, 44);
            loadIDCombo.TabIndex = 37;
            // 
            // cmbDriver
            // 
            cmbDriver.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbDriver.Location = new Point(189, 67);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(167, 44);
            cmbDriver.TabIndex = 38;
            // 
            // cmbAssistant
            // 
            cmbAssistant.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAssistant.FormattingEnabled = true;
            cmbAssistant.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbAssistant.Location = new Point(362, 67);
            cmbAssistant.Name = "cmbAssistant";
            cmbAssistant.Size = new Size(167, 44);
            cmbAssistant.TabIndex = 39;
            // 
            // cmbLorry
            // 
            cmbLorry.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLorry.FormattingEnabled = true;
            cmbLorry.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbLorry.Location = new Point(535, 67);
            cmbLorry.Name = "cmbLorry";
            cmbLorry.Size = new Size(167, 44);
            cmbLorry.TabIndex = 40;
            // 
            // cmbContainer
            // 
            cmbContainer.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbContainer.FormattingEnabled = true;
            cmbContainer.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbContainer.Location = new Point(708, 67);
            cmbContainer.Name = "cmbContainer";
            cmbContainer.Size = new Size(167, 44);
            cmbContainer.TabIndex = 41;
            // 
            // dgvNext7DaysAvailability
            // 
            dgvNext7DaysAvailability.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNext7DaysAvailability.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNext7DaysAvailability.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNext7DaysAvailability.Location = new Point(9, 426);
            dgvNext7DaysAvailability.Name = "dgvNext7DaysAvailability";
            dgvNext7DaysAvailability.RowHeadersWidth = 51;
            dgvNext7DaysAvailability.Size = new Size(1069, 163);
            dgvNext7DaysAvailability.TabIndex = 42;
            // 
            // dgvAssignments
            // 
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignments.Columns.AddRange(new DataGridViewColumn[] { LoadID, DriverID, AssistantID, LorryID, ContainerID });
            dgvAssignments.Location = new Point(9, 144);
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.RowHeadersWidth = 51;
            dgvAssignments.Size = new Size(1069, 276);
            dgvAssignments.TabIndex = 43;
            // 
            // LoadID
            // 
            LoadID.HeaderText = "Load ID";
            LoadID.MinimumWidth = 6;
            LoadID.Name = "LoadID";
            LoadID.ReadOnly = true;
            // 
            // DriverID
            // 
            DriverID.HeaderText = "Driver ID";
            DriverID.MinimumWidth = 6;
            DriverID.Name = "DriverID";
            DriverID.ReadOnly = true;
            // 
            // AssistantID
            // 
            AssistantID.HeaderText = "Assistant ID";
            AssistantID.MinimumWidth = 6;
            AssistantID.Name = "AssistantID";
            AssistantID.ReadOnly = true;
            // 
            // LorryID
            // 
            LorryID.HeaderText = "Lorry ID";
            LorryID.MinimumWidth = 6;
            LorryID.Name = "LorryID";
            LorryID.ReadOnly = true;
            // 
            // ContainerID
            // 
            ContainerID.HeaderText = "Container ID";
            ContainerID.MinimumWidth = 6;
            ContainerID.Name = "ContainerID";
            ContainerID.ReadOnly = true;
            // 
            // jobAcceptBtn
            // 
            jobAcceptBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobAcceptBtn.Location = new Point(364, 598);
            jobAcceptBtn.Name = "jobAcceptBtn";
            jobAcceptBtn.Size = new Size(165, 60);
            jobAcceptBtn.TabIndex = 44;
            jobAcceptBtn.Text = "Accept";
            jobAcceptBtn.UseVisualStyleBackColor = true;
            jobAcceptBtn.Click += jobAcceptBtn_Click;
            // 
            // jobDeclineBtn
            // 
            jobDeclineBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobDeclineBtn.Location = new Point(535, 598);
            jobDeclineBtn.Name = "jobDeclineBtn";
            jobDeclineBtn.Size = new Size(165, 60);
            jobDeclineBtn.TabIndex = 45;
            jobDeclineBtn.Text = "Decline";
            jobDeclineBtn.UseVisualStyleBackColor = true;
            jobDeclineBtn.Click += jobDeclineBtn_Click;
            // 
            // AdminLoadAssingment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1085, 715);
            Controls.Add(jobDeclineBtn);
            Controls.Add(jobAcceptBtn);
            Controls.Add(dgvAssignments);
            Controls.Add(dgvNext7DaysAvailability);
            Controls.Add(cmbContainer);
            Controls.Add(cmbLorry);
            Controls.Add(cmbAssistant);
            Controls.Add(cmbDriver);
            Controls.Add(loadIDCombo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(jobDatePicker);
            Controls.Add(curStatus);
            Controls.Add(JobID);
            Controls.Add(assignUnitsbtn);
            Name = "AdminLoadAssingment";
            Text = "AdminLoadAssingment";
            Load += AdminLoadAssingment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNext7DaysAvailability).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button assignUnitsbtn;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker jobDatePicker;
        private TextBox curStatus;
        private TextBox JobID;
        private ComboBox loadIDCombo;
        private ComboBox cmbDriver;
        private ComboBox cmbAssistant;
        private ComboBox cmbLorry;
        private ComboBox cmbContainer;
        private DataGridView dgvNext7DaysAvailability;
        private DataGridView dgvAssignments;
        private Button jobAcceptBtn;
        private Button jobDeclineBtn;
        private DataGridViewTextBoxColumn LoadID;
        private DataGridViewTextBoxColumn DriverID;
        private DataGridViewTextBoxColumn AssistantID;
        private DataGridViewTextBoxColumn LorryID;
        private DataGridViewTextBoxColumn ContainerID;
    }
}