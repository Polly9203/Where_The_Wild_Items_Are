using System.Web;
using System.Web.Mvc;

namespace Where_The_Wild_Items_Are
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}