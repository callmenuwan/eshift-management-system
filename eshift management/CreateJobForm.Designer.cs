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
            jobDate = new MonthCalendar();
            label3 = new Label();
            startLocation = new TextBox();
            proName = new ComboBox();
            addProBtn = new Button();
            dgvProductList = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            proQTY = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proQTY).BeginInit();
            SuspendLayout();
            // 
            // destinationLocation
            // 
            destinationLocation.BorderStyle = BorderStyle.FixedSingle;
            destinationLocation.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            destinationLocation.Location = new Point(660, 190);
            destinationLocation.Name = "destinationLocation";
            destinationLocation.Size = new Size(404, 37);
            destinationLocation.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(653, 26);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 5;
            label1.Text = "Start Location";
            // 
            // createJobBtn
            // 
            createJobBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createJobBtn.Location = new Point(660, 571);
            createJobBtn.Name = "createJobBtn";
            createJobBtn.Size = new Size(404, 60);
            createJobBtn.TabIndex = 6;
            createJobBtn.Text = "Create Job";
            createJobBtn.UseVisualStyleBackColor = true;
            createJobBtn.Click += createJobBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(652, 150);
            label2.Name = "label2";
            label2.Size = new Size(134, 36);
            label2.TabIndex = 7;
            label2.Text = "Destination ";
            // 
            // jobDate
            // 
            jobDate.Location = new Point(802, 309);
            jobDate.Name = "jobDate";
            jobDate.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(660, 309);
            label3.Name = "label3";
            label3.Size = new Size(62, 36);
            label3.TabIndex = 10;
            label3.Text = "Date";
            // 
            // startLocation
            // 
            startLocation.BorderStyle = BorderStyle.FixedSingle;
            startLocation.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startLocation.Location = new Point(660, 67);
            startLocation.Name = "startLocation";
            startLocation.Size = new Size(404, 37);
            startLocation.TabIndex = 8;
            // 
            // proName
            // 
            proName.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proName.FormattingEnabled = true;
            proName.Location = new Point(135, 26);
            proName.Name = "proName";
            proName.Size = new Size(278, 44);
            proName.TabIndex = 13;
            // 
            // addProBtn
            // 
            addProBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProBtn.Location = new Point(26, 94);
            addProBtn.Name = "addProBtn";
            addProBtn.Size = new Size(572, 60);
            addProBtn.TabIndex = 14;
            addProBtn.Text = "Add product to list";
            addProBtn.UseVisualStyleBackColor = true;
            addProBtn.Click += addProBtn_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(26, 190);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.Size = new Size(572, 441);
            dgvProductList.TabIndex = 15;
            dgvProductList.CellDoubleClick += dgvProductList_CellDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 29);
            label4.Name = "label4";
            label4.Size = new Size(103, 36);
            label4.TabIndex = 16;
            label4.Text = "Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(425, 29);
            label5.Name = "label5";
            label5.Size = new Size(101, 36);
            label5.TabIndex = 17;
            label5.Text = "Quantity";
            // 
            // proQTY
            // 
            proQTY.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proQTY.Location = new Point(532, 29);
            proQTY.Name = "proQTY";
            proQTY.Size = new Size(66, 37);
            proQTY.TabIndex = 18;
            // 
            // CreateJobForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1113, 684);
            Controls.Add(proQTY);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvProductList);
            Controls.Add(addProBtn);
            Controls.Add(proName);
            Controls.Add(label3);
            Controls.Add(jobDate);
            Controls.Add(startLocation);
            Controls.Add(label2);
            Controls.Add(createJobBtn);
            Controls.Add(label1);
            Controls.Add(destinationLocation);
            Name = "CreateJobForm";
            Text = "CreateJobForm";
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)proQTY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox destinationLocation;
        private Label label1;
        private Button createJobBtn;
        private Label label2;
        private MonthCalendar jobDate;
        private Label label3;
        private TextBox startLocation;
        private ComboBox proName;
        private Button addProBtn;
        private DataGridView dgvProductList;
        private Label label4;
        private Label label5;
        private NumericUpDown proQTY;
    }
}