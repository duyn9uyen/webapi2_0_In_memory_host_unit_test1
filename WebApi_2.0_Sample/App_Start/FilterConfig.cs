using System.Web;
using System.Web.Mvc;

namespace WebApi_2._0_Sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
