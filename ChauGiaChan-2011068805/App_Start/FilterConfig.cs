using System.Web;
using System.Web.Mvc;

namespace ChauGiaChan_2011068805
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
