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
            var people = new List<Person>();
            for (int i = 1; i <= 10; i++) {
                people.Add(
                    new Person() { 
                        Id=i,
                        Name = "Person " + i,
                        Dob = "12.12.12"
                    }
                 );
            }
            //var data = (from p in people select new { p.Dob, p.Name }).Single();
            return View(people);
        }

        public ActionResult Register() {
            //return Redirect("/person/profile");
            TempData["msg"] = "Registration Successfull";
            return RedirectToAction("Profile");
            //return RedirectToAction("Index", "Home");
            //return View();
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Person p) {
            if (ModelState.IsValid) {
                return RedirectToAction("Index");
            }
            return View(p);
        }
        public ActionResult Submit(Person p) {
            /*ViewBag.FormName = Name;
            ViewBag.Id = Id;
            ViewBag.Dob = Dob;*/
            return View(p);
        }
    }
}