using AuthenticationExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthenticationExample.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin,Manager")]
        public ActionResult UserDashboard()
        {
            return View();
        }
        [Authorize(Roles= "Admin")]
        public ActionResult About()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]
        public ActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(UserDetail u)
        {
            UserDetail user = db.UserDetails.Where(s => s.UserName == u.UserName).FirstOrDefault();
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                return Redirect("~/Login/UserDashboard");

            }
            return View();
        }



        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Login/index");
        }

        public ActionResult TempdataExample()
        {

            TempData["name"] = "Dhoni";
            return RedirectToAction("TempdataExample2");

        }

        public ActionResult TempdataExample2()
        {

            //ViewBag.s = TempData["name"];
            //TempData.Keep();
            ViewBag.s = TempData.Peek("name");
            TempData.Keep();
            return View();

        }

    }
}