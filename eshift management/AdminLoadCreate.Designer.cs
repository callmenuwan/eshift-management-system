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
            LoadID = new DataGridViewTextBoxColumn();
            DriverID = new DataGridViewTextBoxColumn();
            AssistantID = new DataGridViewTextBoxColumn();
            LorryID = new DataGridViewTextBoxColumn();
            ContainerID = new DataGridViewTextBoxColumn();
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
            dgvAllProducts.Location = new Point(2, 36);
            dgvAllProducts.Name = "dgvAllProducts";
            dgvAllProducts.RowHeadersWidth = 51;
            dgvAllProducts.Size = new Size(457, 265);
            dgvAllProducts.TabIndex = 0;
            dgvAllProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgvCurrentLoadProducts
            // 
            dgvCurrentLoadProducts.AllowDrop = true;
            dgvCurrentLoadProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrentLoadProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentLoadProducts.Location = new Point(518, 36);
            dgvCurrentLoadProducts.Name = "dgvCurrentLoadProducts";
            dgvCurrentLoadProducts.RowHeadersWidth = 51;
            dgvCurrentLoadProducts.Size = new Size(474, 265);
            dgvCurrentLoadProducts.TabIndex = 1;
            // 
            // dgvLoadSummary
            // 
            dgvLoadSummary.AllowUserToAddRows = false;
            dgvLoadSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoadSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoadSummary.Columns.AddRange(new DataGridViewColumn[] { LoadID, DriverID, AssistantID, LorryID, ContainerID });
            dgvLoadSummary.Location = new Point(2, 373);
            dgvLoadSummary.Name = "dgvLoadSummary";
            dgvLoadSummary.ReadOnly = true;
            dgvLoadSummary.RowHeadersWidth = 51;
            dgvLoadSummary.Size = new Size(990, 206);
            dgvLoadSummary.TabIndex = 2;
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
            // addProBtn
            // 
            addProBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProBtn.Location = new Point(465, 127);
            addProBtn.Name = "addProBtn";
            addProBtn.Size = new Size(47, 41);
            addProBtn.TabIndex = 7;
            addProBtn.Text = ">>";
            addProBtn.UseVisualStyleBackColor = true;
            addProBtn.Click += addProBtn_Click;
            // 
            // assignUnitBtn
            // 
            assignUnitBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignUnitBtn.Location = new Point(404, 585);
            assignUnitBtn.Name = "assignUnitBtn";
            assignUnitBtn.Size = new Size(165, 60);
            assignUnitBtn.TabIndex = 8;
            assignUnitBtn.Text = "Create Loads";
            assignUnitBtn.UseVisualStyleBackColor = true;
            assignUnitBtn.Click += assignUnitBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, -2);
            label4.Name = "label4";
            label4.Size = new Size(132, 36);
            label4.TabIndex = 17;
            label4.Text = "All Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(560, -2);
            label1.Name = "label1";
            label1.Size = new Size(145, 36);
            label1.TabIndex = 18;
            label1.Text = "Current Load";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 331);
            label2.Name = "label2";
            label2.Size = new Size(180, 36);
            label2.TabIndex = 19;
            label2.Text = "Loads Summary";
            // 
            // createTempLoad
            // 
            createTempLoad.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTempLoad.Location = new Point(404, 307);
            createTempLoad.Name = "createTempLoad";
            createTempLoad.Size = new Size(165, 60);
            createTempLoad.TabIndex = 20;
            createTempLoad.Text = "Add to list";
            createTempLoad.UseVisualStyleBackColor = true;
            createTempLoad.Click += createTempLoad_Click;
            // 
            // removeProBtn
            // 
            removeProBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeProBtn.Location = new Point(465, 174);
            removeProBtn.Name = "removeProBtn";
            removeProBtn.Size = new Size(47, 41);
            removeProBtn.TabIndex = 21;
            removeProBtn.Text = "<<";
            removeProBtn.UseVisualStyleBackColor = true;
            removeProBtn.Click += removeProBtn_Click;
            // 
            // AdminLoadCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
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
            Load += AdminLoadCreate_Load;
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
        private DataGridViewTextBoxColumn LoadID;
        private DataGridViewTextBoxColumn DriverID;
        private DataGridViewTextBoxColumn AssistantID;
        private DataGridViewTextBoxColumn LorryID;
        private DataGridViewTextBoxColumn ContainerID;
    }
}