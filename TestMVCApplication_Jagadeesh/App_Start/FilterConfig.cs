using System.Web;
using System.Web.Mvc;

namespace TestMVCApplication_Jagadeesh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
