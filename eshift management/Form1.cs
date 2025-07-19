namespace eshift_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowRelevantButtons();
            SetSidePanelColor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Redirect to form

            if (Login.LoggedInCustomer != null)
            {
                LoadChildForm(new CustomerDashboard(this));
            }
            else if (Login.LoggedInAdmin != null)
            {
                LoadChildForm(new AdminDashboard(this));
            }
            else
            {
                LoadChildForm(new Login());
            }


            //Change Welcome Name

            if (Login.LoggedInAdmin != null)
            {
                userNameLabel.Text = "Hello " + Login.LoggedInAdmin.Name;
            }
            else if (Login.LoggedInCustomer != null)
            {
                userNameLabel.Text = "Hello " + Login.LoggedInCustomer.Name;
            }

        }

        public Form currentForm = null;
        public void LoadChildForm(Form childForm)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewAdminDashboardBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminDashboard(this));
        }

        private void viewAdminJobsBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminJobsViewForm(this));
        }

        private void viewCusAddBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new RegisterCustomerForm());
        }

        private void ShowRelevantButtons()
        {
            if (Login.LoggedInAdmin != null)
            {
                viewAdminDashboardBtn.Visible = true;
                viewAdminJobsBtn.Visible = true;
                viewJobEditBtn.Visible = true;
                viewCustomersBtn.Visible = true;
                viewCusAddBtn.Visible = true;

                viewCusDashboardBtn.Visible = false;
                cusAddJobViewBtn.Visible = false;
            }
            else if (Login.LoggedInCustomer != null)
            {
                viewAdminDashboardBtn.Visible = false;
                viewAdminJobsBtn.Visible = false;
                viewJobEditBtn.Visible = false;
                viewCustomersBtn.Visible = false;
                viewCusAddBtn.Visible = false;

                viewCusDashboardBtn.Visible = true;
                cusAddJobViewBtn.Visible    = true;
            }
        }

        private void SetSidePanelColor()
        {
            if (Login.LoggedInCustomer != null)
            {
                sidePanel.BackColor = Color.FromArgb(0, 120, 215); // Blue
            }
            else if (Login.LoggedInAdmin != null)
            {
                sidePanel.BackColor = Color.FromArgb(72, 61, 139); // Green
            }
            else
            {
                sidePanel.BackColor = Color.FromArgb(0, 120, 215); // Default
            }
        }

        private void viewCusDashboardBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new CustomerDashboard(this));
        }

        private void cusAddJobViewBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new CreateJobForm(this));
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
