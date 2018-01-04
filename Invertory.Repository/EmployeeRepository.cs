using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory.Repository
{
    public class EmployeeRepository : BaseRepository
    {
        public ResponseStatus Add(Employee employee)
        {
            string query = "INSERT INTO [dbo].[Employee] ([Name], [NationalId], [PersonalId],[PhoneNumber],[Address],[BirthDay],[BirthPlace])" +
                "VALUES(" + "N'" + employee.Name +
                "', " + employee.NationalId.ToString() + ", " + employee.PersonalId.ToString() + ", N'" + employee.PhoneNumber +
                "', N'" + employee.Address + "', '" + employee.BirthDay.ToString() + "', N'" + employee.BirthPlace + "')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }

        public ResponseStatus AddEmployeeContractKind(EmployeeContractKind employeeContractKind)
        {
            string query = "INSERT INTO [dbo].[EmployeeContractKind] ([ContractKind]) VALUES (N'" + employeeContractKind.ContractKind +"')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
        public ResponseStatus AddEmployeeFault(EmployeeFault employeeFault)
        {
            string query = "INSERT INTO [dbo].[EmployeeFault]([EmployeeId])VALUES" +
                "('" + employeeFault.EmployeeId + "')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
        public List<Employee> EmployeeList()
        {
            string query = "SELECT * FROM Employee";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            List<Employee> inventoryList = new List<Employee>();
            if (queryCommandReader.HasRows)
            {
                while (queryCommandReader.Read())
                {
                    inventoryList.Add(new Employee()
                    {
                        Name = (string)queryCommandReader["Name"],
                        EmployeeId = Int32.Parse(queryCommandReader[0].ToString()),
                        Address = (string)queryCommandReader["Address"],
                        PhoneNumber = (string)queryCommandReader["PhoneNumber"],
                        BirthDay = (DateTime)queryCommandReader["BirthDay"],
                        BirthPlace = (string)queryCommandReader["BirthPlace"],
                        NationalId = (int)queryCommandReader["NationalId"],
                        PersonalId = (int)queryCommandReader["PersonalId"],
                    });
                }
            }
            DBConnection.Close();
            return inventoryList;
        }
    }
}
