using Hbas.LearnSpecflow.SampleSUT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hbas.LearnSpecflow.SampleSUT.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index()
        {
            return View(new LoginViewModel());
        }

        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO: TDD: Testing other invalid passwords will make us refactor and use a database
                if (model.Password != "invalid")
                {
                    return RedirectToAction("Index", "Home", new { Login = model.Login });
                }
                else
                {
                    ModelState.AddModelError("Password", "Invalid password");
                }
            }
            return View("Index", model);
        }

    }
}
