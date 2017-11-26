using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public enum CPanelAPIControllers
    {
        CPAuthentication,
        CPParking
    }
    public enum ResponseStatus
    {
        Unknown = 0,
        Success = 1,
        InternalError = 2,
        DuplicateObject = 3,
        NotExist = 4,
        AccessDenied = 5,
    }
}
