namespace eshift_management
{
    partial class AdminDashboard
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
            cusRegFormBtn = new Button();
            untiAssignFormBtn = new Button();
            panelChart = new Panel();
            SuspendLayout();
            // 
            // cusRegFormBtn
            // 
            cusRegFormBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusRegFormBtn.Location = new Point(134, 469);
            cusRegFormBtn.Name = "cusRegFormBtn";
            cusRegFormBtn.Size = new Size(278, 60);
            cusRegFormBtn.TabIndex = 2;
            cusRegFormBtn.Text = "Customer Register";
            cusRegFormBtn.UseVisualStyleBackColor = true;
            cusRegFormBtn.Click += cusRegFormBtn_Click;
            // 
            // untiAssignFormBtn
            // 
            untiAssignFormBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            untiAssignFormBtn.Location = new Point(459, 469);
            untiAssignFormBtn.Name = "untiAssignFormBtn";
            untiAssignFormBtn.Size = new Size(278, 60);
            untiAssignFormBtn.TabIndex = 3;
            untiAssignFormBtn.Text = "Assign Transport Unit";
            untiAssignFormBtn.UseVisualStyleBackColor = true;
            untiAssignFormBtn.Click += untiAssignFormBtn_Click;
            // 
            // panelChart
            // 
            panelChart.BackColor = Color.Transparent;
            panelChart.Dock = DockStyle.Top;
            panelChart.Location = new Point(0, 0);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(926, 361);
            panelChart.TabIndex = 4;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(926, 543);
            Controls.Add(panelChart);
            Controls.Add(untiAssignFormBtn);
            Controls.Add(cusRegFormBtn);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button cusRegFormBtn;
        private Button untiAssignFormBtn;
        private Panel panelChart;
    }
}