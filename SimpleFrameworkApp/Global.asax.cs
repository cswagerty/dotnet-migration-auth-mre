using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SimpleFrameworkApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Configure app to handle requests for session info from PepConnect.WebCore .NET Core application
            SystemWebAdapterConfiguration.AddSystemWebAdapters(this)
                .AddRemoteAppServer(options =>
                {
                    options.ApiKey = "c3dcebce-1c40-4805-a015-aa7288cc52a2";
                })
                .AddAuthenticationServer();
        }
    }
}
