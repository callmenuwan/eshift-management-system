using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace eshift_management
{
    public class JobAssignment
    {
        public int AssignmentID { get; set; }
        public int JobID { get; set; }
        public DateTime AssignmentDate { get; set; }
        public int DriverID { get; set; }
        public int AssistantID { get; set; }
        public int LorryID { get; set; }
        public int ContainerID { get; set; }

        public bool AssignTransportUnitToJob()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                conn.Open();
                string query = @"INSERT INTO JobAssignment 
                (JobID, AssignmentDate, DriverID, AssistantID, LorryID, ContainerID) 
                VALUES 
                (@JobID, @AssignmentDate, @DriverID, @AssistantID, @LorryID, @ContainerID)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@JobID", JobID);
                cmd.Parameters.AddWithValue("@AssignmentDate", AssignmentDate);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
                cmd.Parameters.AddWithValue("@AssistantID", AssistantID);
                cmd.Parameters.AddWithValue("@LorryID", LorryID);
                cmd.Parameters.AddWithValue("@ContainerID", ContainerID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
