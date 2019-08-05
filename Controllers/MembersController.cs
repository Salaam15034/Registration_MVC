using Login_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Registration.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Members()
        {
            return View(new List<Members>());
        }
    }
}