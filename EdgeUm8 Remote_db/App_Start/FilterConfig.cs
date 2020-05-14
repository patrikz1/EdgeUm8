using System.Web;
using System.Web.Mvc;

namespace EdgeUm8_Remote_db
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
