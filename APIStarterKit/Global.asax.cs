using APIStarterKit.App_Start;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace APIStarterKit
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Initial izenda hooks & configuration
            IzendaConfig.Init();
        }
    }
}
