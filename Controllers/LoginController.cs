using Login_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Registration.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

          public ActionResult ValidateUser()
          {
               if (ModelState.IsValid)
               {
                    var loginDetails = new Login();
                    UpdateModel(loginDetails);
               }
               //return RedirectToRoute("Dashboard");
               //TempData["Salaam"] = "Salaam";
               var rt = TempData["Salaam"];
               return RedirectToAction("Index", "Dashboard");
          }

          public ActionResult Logout()
          {
               return RedirectToAction("Login");
          }
    }
}