namespace eshift_management
{
    partial class AdminProductForm
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
            label1 = new Label();
            proName = new TextBox();
            proDeleteBtn = new Button();
            proAddBtn = new Button();
            proUpdateBtn = new Button();
            clearBtn = new Button();
            proWeight = new TextBox();
            proDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(160, 36);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // proName
            // 
            proName.BorderStyle = BorderStyle.FixedSingle;
            proName.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proName.Location = new Point(181, 28);
            proName.Name = "proName";
            proName.Size = new Size(278, 37);
            proName.TabIndex = 4;
            // 
            // proDeleteBtn
            // 
            proDeleteBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proDeleteBtn.Location = new Point(49, 434);
            proDeleteBtn.Name = "proDeleteBtn";
            proDeleteBtn.Size = new Size(278, 60);
            proDeleteBtn.TabIndex = 5;
            proDeleteBtn.Text = "Delete";
            proDeleteBtn.UseVisualStyleBackColor = true;
            proDeleteBtn.Click += proDeleteBtn_Click;
            // 
            // proAddBtn
            // 
            proAddBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proAddBtn.Location = new Point(49, 368);
            proAddBtn.Name = "proAddBtn";
            proAddBtn.Size = new Size(278, 60);
            proAddBtn.TabIndex = 6;
            proAddBtn.Text = "Add";
            proAddBtn.UseVisualStyleBackColor = true;
            proAddBtn.Click += proAddBtn_Click;
            // 
            // proUpdateBtn
            // 
            proUpdateBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proUpdateBtn.Location = new Point(333, 368);
            proUpdateBtn.Name = "proUpdateBtn";
            proUpdateBtn.Size = new Size(278, 60);
            proUpdateBtn.TabIndex = 7;
            proUpdateBtn.Text = "Update";
            proUpdateBtn.UseVisualStyleBackColor = true;
            proUpdateBtn.Click += proUpdateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(333, 434);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(278, 60);
            clearBtn.TabIndex = 8;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // proWeight
            // 
            proWeight.BorderStyle = BorderStyle.FixedSingle;
            proWeight.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proWeight.Location = new Point(209, 201);
            proWeight.Name = "proWeight";
            proWeight.Size = new Size(278, 37);
            proWeight.TabIndex = 11;
            // 
            // proDescription
            // 
            proDescription.BorderStyle = BorderStyle.FixedSingle;
            proDescription.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proDescription.Location = new Point(181, 114);
            proDescription.Name = "proDescription";
            proDescription.Size = new Size(278, 37);
            proDescription.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 201);
            label2.Name = "label2";
            label2.Size = new Size(181, 36);
            label2.TabIndex = 13;
            label2.Text = "\tUnit Weight (kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 116);
            label3.Name = "label3";
            label3.Size = new Size(127, 36);
            label3.TabIndex = 14;
            label3.Text = "Description";
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Right;
            dgvProducts.Location = new Point(637, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(596, 603);
            dgvProducts.TabIndex = 15;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // AdminProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 603);
            Controls.Add(dgvProducts);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(proDescription);
            Controls.Add(proWeight);
            Controls.Add(clearBtn);
            Controls.Add(proUpdateBtn);
            Controls.Add(proAddBtn);
            Controls.Add(proDeleteBtn);
            Controls.Add(proName);
            Controls.Add(label1);
            Name = "AdminProductForm";
            Text = "AdminProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox proName;
        private Button proDeleteBtn;
        private Button proAddBtn;
        private Button proUpdateBtn;
        private Button clearBtn;
        private TextBox proWeight;
        private TextBox proDescription;
        private Label label2;
        private Label label3;
        private DataGridView dgvProducts;
    }
}