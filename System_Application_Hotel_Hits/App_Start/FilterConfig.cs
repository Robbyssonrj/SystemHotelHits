using System.Web;
using System.Web.Mvc;

namespace System_Application_Hotel_Hits
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
