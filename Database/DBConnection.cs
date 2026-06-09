using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Configuration;
{
    
}

namespace College_Management_System.Database
{
    public static class DBConnection
    {
        // Connection String
        public static string cs =
            ConfigurationManager
            .ConnectionStrings["Mycon"]
            .ConnectionString;

        // Common SqlConnection Object
        public static SqlConnection con =
            new SqlConnection(cs);
    }

}
