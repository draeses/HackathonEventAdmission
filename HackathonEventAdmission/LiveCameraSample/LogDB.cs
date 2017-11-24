using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCameraSample
{
    class LogDB
    {
        public void WriteStats(string personID, decimal accuracy, int age_range)
        {
            string EntryTime = DateTime.Now.ToString();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "hackathonateventadmission.database.windows.net";
            builder.UserID = "dree";
            builder.Password = "DevAt1234567";
            builder.InitialCatalog = "hackathonateventadmission";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append($"INSERT INTO dbo.Statistics VALUES {{'{personID}','{EntryTime}', {accuracy}, NULL, NULL, {age_range}}}");
                String sql = sb.ToString();
                connection.Close();
            }
        }
    }
}
