using Autofac;
using Newtonsoft.Json;
using Promact.Erp.Util.StringConstantConvertor;
using Promact.Erp.Util.StringConstants;
using Promact.Erp.Web.App_Start;
using System.IO;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Promact.Erp.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = AutofacConfig.RegisterDependancies();
            DatabaseConfig.Initialize(container);
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var convertor = container.Resolve<IStringConstantConvertor>();
            convertor.OnInit();
            //Bot.ScrumMain(container);
            //Bot.Main(container);
        }
    }
}
