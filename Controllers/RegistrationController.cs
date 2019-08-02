using Login_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Registration.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register()
        {
            return View();
        }

          public ActionResult RegisterUser()
          {
               if (ModelState.IsValid)
               {
                    var userData = new Register();
                    UpdateModel(userData);
               }
               TempData["Salaam"] = "Salaam";
               return RedirectToRoute("LoginPage");
          }
    }
}