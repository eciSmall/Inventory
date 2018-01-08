using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory.Repository
{
    public class PartnerRepository : BaseRepository
    {
        public ResponseStatus Add(Partner partner)
        {
            string query = "INSERT INTO [dbo].[Partner]([Name],[PhoneNumber],[Address],[Email],[Password]" +
                ")VALUES(N'" + partner.Name + "',N'" + partner.PhoneNumber +
                "',N'" + partner.Address + "','" + partner.Email + "'" +
                ",N'" + partner.Password +"')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
        public ResponseStatus AddPartnerRequest(PartnerRequest partnerRequest)
        {
            string query = "INSERT INTO [dbo].[PartnerRequest]([RequestKind],[RequestDescription]" +
                ")VALUES(N'" + partnerRequest.RequestKind + "',N'" + partnerRequest.RequestDescription + "')";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            queryCommand.ExecuteNonQuery();
            DBConnection.Close();
            return ResponseStatus.Success;
        }
        public List<PartnerRequest> PartnerRquestList()
        {
            string query = "SELECT * FROM PartnerRequest";

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            List<PartnerRequest> partnerRquestList = new List<PartnerRequest>();
            if (queryCommandReader.HasRows)
            {
                while (queryCommandReader.Read())
                {
                    partnerRquestList.Add(new PartnerRequest()
                    {
                        RequestKind = (string)queryCommandReader["RequestKind"],
                        PartnerRequestId = Int32.Parse(queryCommandReader[0].ToString()),
                        RequestDescription = (string)queryCommandReader["RequestDescription"],
                        PartnerRefId = (int)queryCommandReader["PartnerRefId"],
                    });
                }
            }
            DBConnection.Close();
            return partnerRquestList;
        }
        public Partner GetPartner(int partnerId)
        {
            string query = "SELECT * FROM Partner WHERE PartnerId = " + partnerId;

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            if (queryCommandReader.HasRows)
            {
                while (queryCommandReader.Read())
                {
                    return new Partner()
                    {
                        Name = (string)queryCommandReader["Name"],
                        PartnerId = Int32.Parse(queryCommandReader[0].ToString()),
                        PhoneNumber = (string)queryCommandReader["PhoneNumber"],
                        Address = (string)queryCommandReader["Address"],
                        Email = (string)queryCommandReader["Email"],
                    };
                }
            }
            return new Partner()
            {
                EndUserMessage = "اطلاعات غلط"
            };
        }
        public ResponseStatus Login(Partner partner, out int partnerId)
        {
            string query = "SELECT COUNT(*) from Partner where Email = '" + partner.Email + "' AND password = N'" + partner.Password + "'";
            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            if (queryCommandReader.HasRows)
            {
                while (queryCommandReader.Read())
                {
                    partner = new Partner()
                    {
                        PartnerId = Int32.Parse(queryCommandReader[0].ToString()),
                    };
                }
                DBConnection.Close();
                partnerId = partner.PartnerId;
                return ResponseStatus.Success;
            }
            else
            {
                DBConnection.Close();
                partnerId = 0;
                return ResponseStatus.AccessDenied;
            }
        }
        public List<PartnerRequest> PartnerRquestListByPartner(int partnerId)
        {
            string query = "SELECT * FROM PartnerRequest WHERE PartnerRefId = " + partnerId;

            SqlCommand queryCommand = new SqlCommand(query, DBConnection);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            List<PartnerRequest> partnerRquestList = new List<PartnerRequest>();
            if (queryCommandReader.HasRows)
            {
                while (queryCommandReader.Read())
                {
                    partnerRquestList.Add(new PartnerRequest()
                    {
                        RequestKind = (string)queryCommandReader["RequestKind"],
                        PartnerRequestId = Int32.Parse(queryCommandReader[0].ToString()),
                        RequestDescription = (string)queryCommandReader["RequestDescription"],
                        PartnerRefId = (int)queryCommandReader["PartnerRefId"],
                    });
                }
            }
            DBConnection.Close();
            return partnerRquestList;
        }
    }
}
