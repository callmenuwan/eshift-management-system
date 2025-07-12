using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eshift_management
{
    public partial class CreateJobForm : Form
    {
        public CreateJobForm()
        {
            InitializeComponent();
        }

        private void createJobBtn_Click(object sender, EventArgs e)
        {
            if (Login.LoggedInCustomer == null)
            {
                MessageBox.Show("Please log in as customer.");
                return;
            }

            string start                = startLocation.Text.Trim();
            string destination          = destinationLocation.Text.Trim();
            DateTime selectedJobDate    = jobDate.SelectionStart;

            TransportJob job = new TransportJob
            {
                CustomerID      = Login.LoggedInCustomer.UId,
                StartLocation   = start,
                Destination     = destination,
                JobDate         = selectedJobDate,
                Status          = "Pending"
            };

            if (job.SaveToDatabase())
            {
                MessageBox.Show("Job request submitted successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save job.");
            }
        }
    }
}
