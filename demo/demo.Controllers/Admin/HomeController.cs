using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace demo.Controllers.Admin
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("~/Views/Admin/Home/Index.cshtml");
        }
    }
}
