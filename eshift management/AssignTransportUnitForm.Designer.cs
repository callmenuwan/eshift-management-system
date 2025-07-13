namespace eshift_management
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
            cmbJobList = new ComboBox();
            label3 = new Label();
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
            SuspendLayout();
            // 
            // cmbJobList
            // 
            cmbJobList.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbJobList.FormattingEnabled = true;
            cmbJobList.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbJobList.Location = new Point(268, 35);
            cmbJobList.Name = "cmbJobList";
            cmbJobList.Size = new Size(278, 44);
            cmbJobList.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 35);
            label3.Name = "label3";
            label3.Size = new Size(204, 36);
            label3.TabIndex = 6;
            label3.Text = "Select pending job";
            // 
            // assignBtn
            // 
            assignBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignBtn.Location = new Point(392, 363);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(278, 60);
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
            cmbAssistant.Location = new Point(314, 174);
            cmbAssistant.Name = "cmbAssistant";
            cmbAssistant.Size = new Size(278, 44);
            cmbAssistant.TabIndex = 8;
            // 
            // cmbDriver
            // 
            cmbDriver.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(268, 104);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(278, 44);
            cmbDriver.TabIndex = 9;
            cmbDriver.SelectedIndexChanged += cmbDriver_SelectedIndexChanged;
            // 
            // cmbLorry
            // 
            cmbLorry.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLorry.FormattingEnabled = true;
            cmbLorry.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbLorry.Location = new Point(314, 239);
            cmbLorry.Name = "cmbLorry";
            cmbLorry.Size = new Size(278, 44);
            cmbLorry.TabIndex = 10;
            // 
            // cmbContainer
            // 
            cmbContainer.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbContainer.FormattingEnabled = true;
            cmbContainer.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbContainer.Location = new Point(314, 304);
            cmbContainer.Name = "cmbContainer";
            cmbContainer.Size = new Size(278, 44);
            cmbContainer.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(241, 36);
            label1.TabIndex = 12;
            label1.Text = "Show available drivers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 177);
            label2.Name = "label2";
            label2.Size = new Size(275, 36);
            label2.TabIndex = 13;
            label2.Text = "Show available assistants";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 239);
            label4.Name = "label4";
            label4.Size = new Size(234, 36);
            label4.TabIndex = 14;
            label4.Text = "Show available lorries";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 312);
            label5.Name = "label5";
            label5.Size = new Size(281, 36);
            label5.TabIndex = 15;
            label5.Text = "Show available containers";
            // 
            // JobID
            // 
            JobID.BorderStyle = BorderStyle.FixedSingle;
            JobID.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JobID.Location = new Point(642, 90);
            JobID.Name = "JobID";
            JobID.Size = new Size(278, 37);
            JobID.TabIndex = 16;
            // 
            // curStatus
            // 
            curStatus.BorderStyle = BorderStyle.FixedSingle;
            curStatus.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            curStatus.Location = new Point(629, 164);
            curStatus.Name = "curStatus";
            curStatus.Size = new Size(278, 37);
            curStatus.TabIndex = 17;
            // 
            // AssignTransportUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 450);
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
            Controls.Add(label3);
            Controls.Add(cmbJobList);
            Name = "AssignTransportUnitForm";
            Text = "AssignTransportUnitForm";
            Load += AssignTransportUnitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbJobList;
        private Label label3;
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
    }
}