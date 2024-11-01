using System.Web;
using System.Web.Mvc;

namespace GianDuyKhanh_23DH111541
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
