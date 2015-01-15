using System.Web;
using System.Web.Mvc;

namespace WebApplication_Lacaze_Pintault_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
