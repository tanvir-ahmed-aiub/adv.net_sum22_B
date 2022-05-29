using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class PersonController : Controller
    {

        public ActionResult Profile() {
            /*ViewBag.Name = "Tanvir";
            ViewBag.Id = "11212";*/
            /*Person p = new Person() {
                Dob = "12,12,12",
                Id=1,
                Name="Tanvir"

            };*/
            Person pr = new Person();
            pr.Id = 1;
            pr.Name = "Ahsan";
            pr.Dob = "12.12.12";
            return View(pr);
        }

        // GET: Person
        public ActionResult Index()
        {
            ViewBag.Name = "Sabbir";
            return View();
        }

        public ActionResult Register() {
            //return Redirect("/person/profile");
            TempData["msg"] = "Registration Successfull";
            return RedirectToAction("Profile");
            //return RedirectToAction("Index", "Home");
            //return View();
        }
    }
}