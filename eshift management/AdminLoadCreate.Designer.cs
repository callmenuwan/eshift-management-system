namespace eshift_management
{
    partial class AdminLoadCreate
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
            dgvAllProducts = new DataGridView();
            dgvCurrentLoadProducts = new DataGridView();
            dgvLoadSummary = new DataGridView();
            addProBtn = new Button();
            assignUnitBtn = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            createTempLoad = new Button();
            removeProBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentLoadProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoadSummary).BeginInit();
            SuspendLayout();
            // 
            // dgvAllProducts
            // 
            dgvAllProducts.AllowDrop = true;
            dgvAllProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllProducts.Location = new Point(44, 39);
            dgvAllProducts.Name = "dgvAllProducts";
            dgvAllProducts.RowHeadersWidth = 51;
            dgvAllProducts.Size = new Size(365, 331);
            dgvAllProducts.TabIndex = 0;
            dgvAllProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgvCurrentLoadProducts
            // 
            dgvCurrentLoadProducts.AllowDrop = true;
            dgvCurrentLoadProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrentLoadProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentLoadProducts.Location = new Point(620, 39);
            dgvCurrentLoadProducts.Name = "dgvCurrentLoadProducts";
            dgvCurrentLoadProducts.RowHeadersWidth = 51;
            dgvCurrentLoadProducts.Size = new Size(361, 331);
            dgvCurrentLoadProducts.TabIndex = 1;
            // 
            // dgvLoadSummary
            // 
            dgvLoadSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoadSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoadSummary.Location = new Point(13, 519);
            dgvLoadSummary.Name = "dgvLoadSummary";
            dgvLoadSummary.RowHeadersWidth = 51;
            dgvLoadSummary.Size = new Size(964, 135);
            dgvLoadSummary.TabIndex = 2;
            // 
            // addProBtn
            // 
            addProBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProBtn.Location = new Point(475, 115);
            addProBtn.Name = "addProBtn";
            addProBtn.Size = new Size(79, 60);
            addProBtn.TabIndex = 7;
            addProBtn.Text = ">>";
            addProBtn.UseVisualStyleBackColor = true;
            addProBtn.Click += addProBtn_Click;
            // 
            // assignUnitBtn
            // 
            assignUnitBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignUnitBtn.Location = new Point(441, 677);
            assignUnitBtn.Name = "assignUnitBtn";
            assignUnitBtn.Size = new Size(165, 60);
            assignUnitBtn.TabIndex = 8;
            assignUnitBtn.Text = "Assign Units";
            assignUnitBtn.UseVisualStyleBackColor = true;
            assignUnitBtn.Click += assignUnitBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 36);
            label4.TabIndex = 17;
            label4.Text = "All Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(664, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 36);
            label1.TabIndex = 18;
            label1.Text = "Current Load";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 480);
            label2.Name = "label2";
            label2.Size = new Size(296, 36);
            label2.TabIndex = 19;
            label2.Text = "All Created Loads Summary";
            // 
            // createTempLoad
            // 
            createTempLoad.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTempLoad.Location = new Point(415, 392);
            createTempLoad.Name = "createTempLoad";
            createTempLoad.Size = new Size(165, 60);
            createTempLoad.TabIndex = 20;
            createTempLoad.Text = "Create Load";
            createTempLoad.UseVisualStyleBackColor = true;
            createTempLoad.Click += createTempLoad_Click;
            // 
            // removeProBtn
            // 
            removeProBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeProBtn.Location = new Point(475, 194);
            removeProBtn.Name = "removeProBtn";
            removeProBtn.Size = new Size(79, 60);
            removeProBtn.TabIndex = 21;
            removeProBtn.Text = "<<";
            removeProBtn.UseVisualStyleBackColor = true;
            removeProBtn.Click += removeProBtn_Click;
            // 
            // AdminLoadCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 748);
            Controls.Add(removeProBtn);
            Controls.Add(createTempLoad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(assignUnitBtn);
            Controls.Add(addProBtn);
            Controls.Add(dgvLoadSummary);
            Controls.Add(dgvCurrentLoadProducts);
            Controls.Add(dgvAllProducts);
            Name = "AdminLoadCreate";
            Text = "AdminLoadCreate";
            ((System.ComponentModel.ISupportInitialize)dgvAllProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentLoadProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoadSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllProducts;
        private DataGridView dgvCurrentLoadProducts;
        private DataGridView dgvLoadSummary;
        private Button addProBtn;
        private Button assignUnitBtn;
        private Label label4;
        private Label label1;
        private Label label2;
        private Button createTempLoad;
        private Button removeProBtn;
    }
}