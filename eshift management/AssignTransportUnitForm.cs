using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eshift_management
{
    public partial class AssignTransportUnitForm : Form
    {

        private int jobIDc;
        private string currentStatusx;

        public AssignTransportUnitForm(int jobID, string currentStatus)
        {
            InitializeComponent();

            this.jobIDc = jobID;
            this.currentStatusx = currentStatus;

            // Optionally, load job details here using jobID
            LoadJobDetails();
        }

        private void AssignTransportUnitForm_Load(object sender, EventArgs e)
        {
            //LoadPendingJobs();
        }

        private void LoadJobDetails()
        {
            JobID.Text = jobIDc.ToString();
            curStatus.Text = currentStatusx;
        }


        private void assignBtn_Click(object sender, EventArgs e)
        {

        }

        

        private void cmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
