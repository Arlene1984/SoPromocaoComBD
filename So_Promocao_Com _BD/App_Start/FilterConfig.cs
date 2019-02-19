using System.Web;
using System.Web.Mvc;

namespace So_Promocao_Com__BD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
