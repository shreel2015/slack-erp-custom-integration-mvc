using Newtonsoft.Json;
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

            var path = "D:\\New Task Mail Report\\New folder\\slack-erp-custom-integration-mvc\\Slack.Automation\\Promact.Erp.Util\\StringConstants\\StringConstants.json";
            AppConstant a;
            using (StreamReader r = System.IO.File.OpenText(path))
            {

                string json = r.ReadToEnd();
                a = JsonConvert.DeserializeObject<AppConstant>(json);
                r.Close();
            }
            string NextPage;//=Util.Properties.Settings.Default.NextPage;
            a.TaskReport.TryGetValue("NextPage", out NextPage);
            Util.Properties.Settings.Default["NextPage"] = NextPage;
            Util.Properties.Settings.Default.Save();
            System.IO.File.OpenText(path).Close();
            //Bot.ScrumMain(container);
            //Bot.Main(container);

        }
    }
}
