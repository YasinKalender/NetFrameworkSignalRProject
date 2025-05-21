using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Signalr.ProjectExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private ContractNotificationBackgroundService _notificationService;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            _notificationService = new ContractNotificationBackgroundService();
            _notificationService.Start();
        }

        protected void Application_End()
        {
            _notificationService.Stop();
        }
    }
}
