using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory.Repository
{
    public class ProductRepository : BaseRepository
    {
        public ResponseStatus AddProduct(ProductModel productModel)
        {
            string query = "INSERT INTO [dbo].[Product]([Name],[Number],[Price],[OpeningDate],[ExpirationDate],[Source]" +
                ",[Destination],[InventoryId])VALUES(N'"+ productModel.Name + "','" + productModel.ProductNumber +
                "','" + productModel.Price + "','" + productModel.Opening.ToString() + "','"+ productModel.Expiration.ToString() + "',N'" + productModel.Source + "'" +
                ",N'" + productModel.Destination + "','" + productModel.InventoryId + "')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
        public ResponseStatus AddOwnProduct(OwnProduct ownProduct)
        {
            string query = "INSERT INTO [dbo].[OwnProduct]([Kind])VALUES(N'"+ ownProduct.Kind +"')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
    }
}
