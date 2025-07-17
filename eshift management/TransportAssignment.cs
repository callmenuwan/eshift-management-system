using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace eshift_management
{
    public class TransportAssignment
    {
        public int JobID { get; set; }
        public int? DriverID { get; set; }
        public int? AssistantID { get; set; }
        public int? LorryID { get; set; }
        public int? ContainerID { get; set; }
        public DateTime JobDate { get; set; }

        public TransportAssignment(int jobId, int? driverId, int? assistantId, int? lorryId, int? containerId, DateTime jobDate)
        {
            JobID = jobId;
            DriverID = driverId;
            AssistantID = assistantId;
            LorryID = lorryId;
            ContainerID = containerId;
            JobDate = jobDate;
        }

        // Save assignment + update status
        public bool AssignmentRecordOnDb()
        {

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insert into JobAssignments table
                    string insertQuery = @"
                    INSERT INTO JobAssignment (JobID, DriverID, AssistantID, LorryID, ContainerID, AssignmentDate)
                    VALUES (@JobID, @DriverID, @AssistantID, @LorryID, @ContainerID, @JobDate)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@JobID", JobID);
                    insertCmd.Parameters.AddWithValue("@DriverID", (object?)DriverID ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@AssistantID", (object?)AssistantID ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@LorryID", (object?)LorryID ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@ContainerID", (object?)ContainerID ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@JobDate", JobDate);

                    insertCmd.ExecuteNonQuery();

                    // Update job status
                    string updateQuery = "UPDATE Job SET Status = 'Approved', JobDate = @JobDate WHERE JobID = @JobID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@JobID", JobID);
                    updateCmd.Parameters.AddWithValue("@JobDate", JobDate);
                    updateCmd.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }

}
