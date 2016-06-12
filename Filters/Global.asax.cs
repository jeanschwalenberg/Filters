using System.Web.Mvc;
using System.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Filters.App_Start;

namespace Filters {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
