using AuthenticationAuthr.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationAuthr.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student model) {
            var db = new advsumm22_bEntities();
            var st = (from s in db.Students
                      where s.Username.Equals(model.Username)
                      && s.Password.Equals(model.Password)
                      select s).SingleOrDefault();
            if (st != null) {
                Session["logged_user"] = st.Id;
                return RedirectToAction("Index", "Home");
            }
            TempData["msg"] = "User Does not exist";
            return View();

        }
        public ActionResult Logout() {
            Session.Remove("logged_user");
            return RedirectToAction("Index");
            //Session.RemoveAll();
        }
    }
}