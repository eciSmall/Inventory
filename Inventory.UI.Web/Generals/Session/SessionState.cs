using System.Web;

namespace Inventory.UI.Web.General.Session
{
    public class SessionState : ISessionState
    {
        private System.Web.SessionState.HttpSessionState _session { get { return HttpContext.Current.Session; } }


        public void Clear()
        {
            _session.RemoveAll();
        }

        public void Delete(string key)
        {
            _session.Remove(key);
        }

        public object Get(string key)
        {
            return _session[key];
        }

        public T Get<T>(string key) where T : class
        {
            return _session[key] as T;
        }

        public ISessionState Store(string key, object value)
        {
            _session[key] = value;
            return this;
        }
    }
}