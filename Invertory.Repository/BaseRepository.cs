using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory.Repository
{
    public class BaseRepository
    {
        string ConnectionString { get; set; }
        public SqlConnection DBConnection { get; set; }
        public BaseRepository()
        {
            ConnectionString = @"Data Source =DESKTOP-7DSG2PO\SERVER;initial catalog=Invertory;integrated security=True;MultipleActiveResultSets=True; ";

            DBConnection = new SqlConnection(ConnectionString);

            DBConnection.Open();
        }
    }
}
