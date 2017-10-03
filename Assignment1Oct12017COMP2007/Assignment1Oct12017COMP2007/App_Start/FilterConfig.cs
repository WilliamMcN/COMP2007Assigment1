using System.Web;
using System.Web.Mvc;

namespace Assignment1Oct12017COMP2007
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
