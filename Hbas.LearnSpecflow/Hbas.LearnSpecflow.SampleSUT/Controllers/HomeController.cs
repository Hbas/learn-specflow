using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hbas.LearnSpecflow.SampleSUT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string Login)
        {
            return View((object)Login);
        }

    }
}
