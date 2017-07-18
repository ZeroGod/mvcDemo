using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Test()
        {
            return View();
        }
    }
}
