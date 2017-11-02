using System.Web;
using System.Web.Mvc;

namespace Hacakthon.Application.DisasterManagement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
