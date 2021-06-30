using System.Web;
using System.Web.Mvc;

namespace _1811061230_TranPhanMinhTruong_BigShool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
