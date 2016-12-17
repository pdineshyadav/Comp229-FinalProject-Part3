using System.Web;
using System.Web.Mvc;

namespace TeamProject2_Part3Final
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
