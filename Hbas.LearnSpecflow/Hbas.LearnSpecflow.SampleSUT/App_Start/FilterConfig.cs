using System.Web;
using System.Web.Mvc;

namespace Hbas.LearnSpecflow.SampleSUT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}