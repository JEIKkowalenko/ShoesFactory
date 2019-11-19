using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using ShoesFactory.BLL.Infrastucture;
using ShoesFactory.WEB.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ShoesFactory.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            NinjectModule supplyModule = new SupplyModule();
            NinjectModule serviceModule = new ServiceModule("Default Connection");
            var kernel = new StandardKernel(supplyModule, serviceModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
