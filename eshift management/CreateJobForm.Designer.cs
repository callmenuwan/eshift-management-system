namespace eshift_management
{
    partial class CreateJobForm
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
            destinationLocation = new TextBox();
            label1 = new Label();
            createJobBtn = new Button();
            label2 = new Label();
            startLocation = new TextBox();
            jobDate = new MonthCalendar();
            label3 = new Label();
            SuspendLayout();
            // 
            // destinationLocation
            // 
            destinationLocation.BorderStyle = BorderStyle.FixedSingle;
            destinationLocation.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            destinationLocation.Location = new Point(270, 113);
            destinationLocation.Name = "destinationLocation";
            destinationLocation.Size = new Size(278, 37);
            destinationLocation.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 41);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 5;
            label1.Text = "Start Location";
            // 
            // createJobBtn
            // 
            createJobBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createJobBtn.Location = new Point(270, 378);
            createJobBtn.Name = "createJobBtn";
            createJobBtn.Size = new Size(278, 60);
            createJobBtn.TabIndex = 6;
            createJobBtn.Text = "Create Job";
            createJobBtn.UseVisualStyleBackColor = true;
            createJobBtn.Click += createJobBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 115);
            label2.Name = "label2";
            label2.Size = new Size(134, 36);
            label2.TabIndex = 7;
            label2.Text = "Destination ";
            // 
            // startLocation
            // 
            startLocation.BorderStyle = BorderStyle.FixedSingle;
            startLocation.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startLocation.Location = new Point(270, 39);
            startLocation.Name = "startLocation";
            startLocation.Size = new Size(278, 37);
            startLocation.TabIndex = 8;
            // 
            // jobDate
            // 
            jobDate.Location = new Point(270, 159);
            jobDate.Name = "jobDate";
            jobDate.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 191);
            label3.Name = "label3";
            label3.Size = new Size(62, 36);
            label3.TabIndex = 10;
            label3.Text = "Date";
            // 
            // CreateJobForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(jobDate);
            Controls.Add(startLocation);
            Controls.Add(label2);
            Controls.Add(createJobBtn);
            Controls.Add(label1);
            Controls.Add(destinationLocation);
            Name = "CreateJobForm";
            Text = "CreateJobForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox destinationLocation;
        private Label label1;
        private Button createJobBtn;
        private Label label2;
        private TextBox startLocation;
        private MonthCalendar jobDate;
        private Label label3;
    }
}