using System.Web;
using System.Web.Mvc;

namespace u24989003_INF272_Prac_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
