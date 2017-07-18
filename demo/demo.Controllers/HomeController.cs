using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using demo.Common;
using log4net;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
           var logger = LogManager.GetLogger(typeof(HomeController));
           // var logger = LogManager.GetLogger("myinfo");
              logger.Info("56558452....,\r\n");
          // LogHelper.WriteLog(typeof(HomeController),"你kkk敢");
              //调用另外的控制器
              var otherController = DependencyResolver.Current.GetService<Test>();
            var result = otherController.MyTest();
            
            return View();
        }
        public ViewResult Test()
        {
            return View();
        }
    }
}
