using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using log4net.Config;

namespace demo
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
           // XmlConfigurator.Configure();
            //应用启动时加载log4net配置，还有别一种方法，
            //FileSystemWatcher监听，如果watch为true
            //相应的AssemblyInfo中添加[assembly: XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(logCfg);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
