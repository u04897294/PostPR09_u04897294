using System.Web;
using System.Web.Mvc;

namespace PostPR09_u04897294
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
