using System.Web;
using System.Web.Mvc;

namespace ASPSec4_HTML_forms
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
