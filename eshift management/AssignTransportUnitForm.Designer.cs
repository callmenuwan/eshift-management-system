﻿namespace eshift_management
{
    partial class AssignTransportUnitForm
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
            assignBtn = new Button();
            cmbAssistant = new ComboBox();
            cmbDriver = new ComboBox();
            cmbLorry = new ComboBox();
            cmbContainer = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            JobID = new TextBox();
            curStatus = new TextBox();
            jobDatePicker = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgvNext7DaysAvailability = new DataGridView();
            backBtn = new Button();
            dgvLoadAssignments = new DataGridView();
            assignUnitsbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNext7DaysAvailability).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoadAssignments).BeginInit();
            SuspendLayout();
            // 
            // assignBtn
            // 
            assignBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignBtn.Location = new Point(1063, 493);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(154, 99);
            assignBtn.TabIndex = 7;
            assignBtn.Text = "Assign";
            assignBtn.UseVisualStyleBackColor = true;
            assignBtn.Click += assignBtn_Click;
            // 
            // cmbAssistant
            // 
            cmbAssistant.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAssistant.FormattingEnabled = true;
            cmbAssistant.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbAssistant.Location = new Point(412, 548);
            cmbAssistant.Name = "cmbAssistant";
            cmbAssistant.Size = new Size(194, 44);
            cmbAssistant.TabIndex = 8;
            // 
            // cmbDriver
            // 
            cmbDriver.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(191, 548);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(194, 44);
            cmbDriver.TabIndex = 9;
            cmbDriver.SelectedIndexChanged += cmbDriver_SelectedIndexChanged;
            // 
            // cmbLorry
            // 
            cmbLorry.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLorry.FormattingEnabled = true;
            cmbLorry.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbLorry.Location = new Point(630, 548);
            cmbLorry.Name = "cmbLorry";
            cmbLorry.Size = new Size(194, 44);
            cmbLorry.TabIndex = 10;
            // 
            // cmbContainer
            // 
            cmbContainer.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbContainer.FormattingEnabled = true;
            cmbContainer.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbContainer.Location = new Point(846, 548);
            cmbContainer.Name = "cmbContainer";
            cmbContainer.Size = new Size(194, 44);
            cmbContainer.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 509);
            label1.Name = "label1";
            label1.Size = new Size(180, 36);
            label1.TabIndex = 12;
            label1.Text = "Available drivers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(399, 509);
            label2.Name = "label2";
            label2.Size = new Size(214, 36);
            label2.TabIndex = 13;
            label2.Text = "Available assistants";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(643, 509);
            label4.Name = "label4";
            label4.Size = new Size(173, 36);
            label4.TabIndex = 14;
            label4.Text = "Available lorries";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(831, 509);
            label5.Name = "label5";
            label5.Size = new Size(220, 36);
            label5.TabIndex = 15;
            label5.Text = "Available containers";
            // 
            // JobID
            // 
            JobID.BorderStyle = BorderStyle.FixedSingle;
            JobID.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobID.Location = new Point(271, 433);
            JobID.Name = "JobID";
            JobID.Size = new Size(59, 37);
            JobID.TabIndex = 16;
            // 
            // curStatus
            // 
            curStatus.BorderStyle = BorderStyle.FixedSingle;
            curStatus.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            curStatus.Location = new Point(454, 434);
            curStatus.Name = "curStatus";
            curStatus.Size = new Size(158, 37);
            curStatus.TabIndex = 17;
            // 
            // jobDatePicker
            // 
            jobDatePicker.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jobDatePicker.Location = new Point(836, 432);
            jobDatePicker.Name = "jobDatePicker";
            jobDatePicker.Size = new Size(381, 37);
            jobDatePicker.TabIndex = 18;
            jobDatePicker.ValueChanged += jobDatePicker_ValueChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(187, 434);
            label6.Name = "label6";
            label6.Size = new Size(78, 36);
            label6.TabIndex = 19;
            label6.Text = "Job ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(370, 434);
            label7.Name = "label7";
            label7.Size = new Size(78, 36);
            label7.TabIndex = 20;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(644, 434);
            label8.Name = "label8";
            label8.Size = new Size(186, 36);
            label8.TabIndex = 21;
            label8.Text = "Job Current Date";
            // 
            // dgvNext7DaysAvailability
            // 
            dgvNext7DaysAvailability.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNext7DaysAvailability.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNext7DaysAvailability.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNext7DaysAvailability.Dock = DockStyle.Bottom;
            dgvNext7DaysAvailability.Location = new Point(0, 651);
            dgvNext7DaysAvailability.Name = "dgvNext7DaysAvailability";
            dgvNext7DaysAvailability.RowHeadersWidth = 51;
            dgvNext7DaysAvailability.Size = new Size(1393, 235);
            dgvNext7DaysAvailability.TabIndex = 22;
            dgvNext7DaysAvailability.CellContentClick += dgvNext7DaysAvailability_CellContentClick;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backBtn.Location = new Point(1084, 598);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 37);
            backBtn.TabIndex = 23;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // dgvLoadAssignments
            // 
            dgvLoadAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoadAssignments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoadAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoadAssignments.Dock = DockStyle.Top;
            dgvLoadAssignments.Location = new Point(0, 0);
            dgvLoadAssignments.Name = "dgvLoadAssignments";
            dgvLoadAssignments.RowHeadersWidth = 51;
            dgvLoadAssignments.Size = new Size(1393, 348);
            dgvLoadAssignments.TabIndex = 24;
            dgvLoadAssignments.CellContentClick += dgvLoadAssignments_CellContentClick;
            // 
            // assignUnitsbtn
            // 
            assignUnitsbtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignUnitsbtn.Location = new Point(557, 354);
            assignUnitsbtn.Name = "assignUnitsbtn";
            assignUnitsbtn.Size = new Size(165, 60);
            assignUnitsbtn.TabIndex = 25;
            assignUnitsbtn.Text = "Create Load";
            assignUnitsbtn.UseVisualStyleBackColor = true;
            // 
            // AssignTransportUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 886);
            Controls.Add(assignUnitsbtn);
            Controls.Add(dgvLoadAssignments);
            Controls.Add(backBtn);
            Controls.Add(dgvNext7DaysAvailability);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(jobDatePicker);
            Controls.Add(curStatus);
            Controls.Add(JobID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbContainer);
            Controls.Add(cmbLorry);
            Controls.Add(cmbDriver);
            Controls.Add(cmbAssistant);
            Controls.Add(assignBtn);
            Name = "AssignTransportUnitForm";
            Text = "AssignTransportUnitForm";
            Load += AssignTransportUnitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNext7DaysAvailability).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoadAssignments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button assignBtn;
        private ComboBox cmbAssistant;
        private ComboBox cmbDriver;
        private ComboBox cmbLorry;
        private ComboBox cmbContainer;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox JobID;
        private TextBox curStatus;
        private DateTimePicker jobDatePicker;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgvNext7DaysAvailability;
        private Button backBtn;
        private DataGridView dgvLoadAssignments;
        private Button assignUnitsbtn;
    }
}