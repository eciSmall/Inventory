using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.UI.Web.General.Session
{
    public interface ISessionState
    {
        void Clear();
        void Delete(string key);
        object Get(string key);
        T Get<T>(string key) where T : class;
        ISessionState Store(string key, object value);
    }
}