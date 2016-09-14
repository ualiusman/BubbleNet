using BubbleNet.App_Start;
using BubbleNet.Infrastructure.DI;
using Ninject;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BubbleNet
{
    public class MvcApplication : HttpApplication
    {
        protected  void Application_Start() 
        {

            //base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new ApplicationDbInitializer());

            BubbleNet.Infrastructure.Email.EmailServiceFactory.InitiliazeEmailService(new BubbleNet.Infrastructure.Email.SMTPService());
            BubbleNet.Infrastructure.Logging.LoggingFactory.InitilizeLogger(new BubbleNet.Infrastructure.Logging.NLogAdapter());
            //App_Start.NinjectWebCommon.Start();   
        }
    }
}
