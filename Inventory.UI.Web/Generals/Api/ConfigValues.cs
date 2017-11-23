using System.Configuration;

namespace Inventory.UI.Web.General
{
    public class ConfigValues
    {
        internal static string ApiUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
    }
}