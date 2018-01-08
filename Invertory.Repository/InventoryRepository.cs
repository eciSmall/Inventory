using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory.Repository
{
    public class InventoryRepository : BaseRepository
    {
        public ResponseStatus Add(InventoryModel inventoryModel)
        {
            string query = "INSERT INTO [dbo].[Inventory]([Address],[City],[Foundation],[Name]" +
                ",[PhoneNumber],[RepairCondition],[Representation],[State])VALUES(N'" + inventoryModel.Address + "',N'" + inventoryModel.City + "','"
                + inventoryModel.Foundation + "',N'" + inventoryModel.Name + "',N'" + inventoryModel.PhoneNumber + "','"
                + inventoryModel.RepairCondition + "','" + inventoryModel.Representation + "',N'"
                + inventoryModel.State + "')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
        public ResponseStatus AddInvertoryExpenses(InventoryExpenses invertoryExpenses)
        {
            string query = "INSERT INTO [dbo].[InventoryExpenses]([InventoryIncome],[InventoryTax],[Year],[InventoryOutcome]" +
                ",[InventoryId])VALUES('" + invertoryExpenses.InvertoryIncome + "','" + invertoryExpenses.Tax + "','" 
                + invertoryExpenses.Year.ToString() + "','" + invertoryExpenses.Outcome +"','" + invertoryExpenses.InvertoryId +"')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
        public List<InventoryModel> InventoryList()
        {
            string query = "SELECT * FROM Inventory";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            List<InventoryModel> inventoryList = new List<InventoryModel>();
            if (queryCommandReader.HasRows)
            {
                while (queryCommandReader.Read())
                {
                    inventoryList.Add(new InventoryModel()
                    {
                        Name = (string)queryCommandReader["Name"],
                        InventoryId = Int32.Parse(queryCommandReader[0].ToString()),
                        Address = (string)queryCommandReader["Address"],
                        City = (string)queryCommandReader["City"],
                        State = (string)queryCommandReader["State"],
                        Foundation = (int)queryCommandReader["Foundation"],
                        PhoneNumber = (string)queryCommandReader["PhoneNumber"],
                        RepairCondition = (bool)queryCommandReader["RepairCondition"],
                        Representation = (bool)queryCommandReader["Representation"],
                    });
                }
            }
            DBConnection.Close();
            return inventoryList;
        }
        public List<InventoryModel> InventoryNameList()
        {

            string query = "SELECT * FROM Inventory";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            List<InventoryModel> inventoryList = new List<InventoryModel>();
            if (queryCommandReader.HasRows)
            {
                while (queryCommandReader.Read())
                {
                    inventoryList.Add(new InventoryModel()
                    {
                        Name = (string)queryCommandReader["Name"],
                        InventoryId = Int32.Parse(queryCommandReader[0].ToString()),
                    });
                }
            }
            DBConnection.Close();
            return inventoryList;
        }
        public ResponseStatus Delete(InventoryModel inventoryModel)
        {
            string query = "DELETE FROM Inventory WHERE ID = '" +
                inventoryModel.InventoryId.ToString() + "'";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }

        public ResponseStatus AddRepairUnit(RepairUnit repairUnit)
        {
            string query = "INSERT INTO [dbo].[RepairUnit]([Name],[PhoneNumber]" +
                ")VALUES(N'" + repairUnit.Name + "',N'" + repairUnit.PhoneNumber + "')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
        public ResponseStatus DeleteRepairUnit(RepairUnit repairUnit)
        {
            string query = "DELETE FROM RepairUnit WHERE RepairUnitId = '" +
                repairUnit.RepairUnitId.ToString() + "'";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
        //public List<RepairUnit> RepairUnitList()
        //{

        //    string query = "SELECT * FROM Inventory";

        //    SqlCommand queryCommand = new SqlCommand(query, DBConnection);
        //    SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
        //    List<InventoryModel> inventoryList = new List<InventoryModel>();
        //    if (queryCommandReader.HasRows)
        //    {
        //        while (queryCommandReader.Read())
        //        {
        //            inventoryList.Add(new InventoryModel()
        //            {
        //                Name = (string)queryCommandReader["Name"],
        //                InventoryId = Int32.Parse(queryCommandReader[0].ToString()),
        //                Address = (string)queryCommandReader["Address"],
        //                City = (string)queryCommandReader["City"],
        //                State = (string)queryCommandReader["State"],
        //                Foundation = (int)queryCommandReader["Foundation"],
        //                PhoneNumber = (string)queryCommandReader["PhoneNumber"],
        //                RepairCondition = (bool)queryCommandReader["RepairCondition"],
        //                Representation = (bool)queryCommandReader["Representation"],
        //            });
        //        }
        //    }
        //    DBConnection.Close();
        //    return inventoryList;
        //}
        public ResponseStatus AddRepairCheck(RepairCheck repairCheck)
        {
            string query = "INSERT INTO [dbo].[RepairCheck]([VisitDate],[SugesstionPrice],[InventoryRefId]" +
                ")VALUES('" + repairCheck.VisitDate + "', '" + repairCheck.SugesstionPrice + "', '" + repairCheck.InventoryRefId + "')";
            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();

            query = "UPDATE [dbo].[Inventory] SET [RepairCondition] = '"
                + repairCheck.NeedRepair + "'WHERE ID = " + repairCheck.InventoryRefId;
            queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();

            DBConnection.Close();
            return ResponseStatus.Success;
        }
        public List<RepairCheck> RepairCheckList(InventoryModel inventoryModel)
        {
            string query = "SELECT * FROM RepairCheck WHERE InventoryRefId = '" + inventoryModel.InventoryId + "'";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            List<RepairCheck> repairCheckList = new List<RepairCheck>();
            if (queryCommandReader.HasRows)
            {
                while (queryCommandReader.Read())
                {
                    repairCheckList.Add(new RepairCheck()
                    {
                        SugesstionPrice = (int)queryCommandReader["SugesstionPrice"],
                        VisitDate = (DateTime)queryCommandReader["VisitDate"],
                    });
                }
            }
            DBConnection.Close();
            return repairCheckList;
        }
    }
}
