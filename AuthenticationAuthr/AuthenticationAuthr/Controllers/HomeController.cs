using AuthenticationAuthr.Auth;
using AuthenticationAuthr.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationAuthr.Controllers
{
    public class HomeController : Controller
    {
        [Logged]
        public ActionResult Index()
        {
            var db = new advsumm22_bEntities();
            var id = Int32.Parse(Session["logged_user"].ToString());
            var st = (from s in db.Students
                      where s.Id == id
                      select s).SingleOrDefault();
            return View(st);
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
    }
}