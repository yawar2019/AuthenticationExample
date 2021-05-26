using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorAttribute2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     
        public ActionResult testing(string id)
        {
            try
            {
                int a = Convert.ToInt32(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View();
        }


        [OutputCache(Duration =20,Location =System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult getmeData() {

            return View();
        }
    }
}