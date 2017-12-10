using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProject.FrameworkLayer
{
    public class SqlDbAccess
    {
        const string ConnectionString = @"Data Source=(localdb)\MyLocalDb;Initial Catalog=BloodDonatedatabase;Integrated Security=True";

        public SqlCommand GetCommand(String query)
        {
             
             SqlConnection connection = new SqlConnection(ConnectionString);
             
             SqlCommand cmd = new SqlCommand(query);
               
             cmd.Connection = connection;
              
            return cmd;
           
        }
    }
}
