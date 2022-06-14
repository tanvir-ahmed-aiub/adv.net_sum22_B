using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            advsumm22_bEntities db = new advsumm22_bEntities();
            var students = db.Students.ToList();
            //(from s in db.Students where s.Id == 1 select s).SingleOrDefault();
            return View(students);
        }
        public ActionResult Create() {
            Student s = new Student() { 
                Id = 3,
                Name = "Sarwar",
                Cgpa = 3.75,
                FName ="Md. Habib"

            };
            advsumm22_bEntities db = new advsumm22_bEntities();
            db.Students.Add(s);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id) {
            advsumm22_bEntities db = new advsumm22_bEntities();
            var st = (from s in db.Students where s.Id == id select s).SingleOrDefault();
            st.Name = "Edited Name";
            st.Cgpa = 2.65;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id) {
            advsumm22_bEntities db = new advsumm22_bEntities();
            var st = (from s in db.Students where s.Id == id select s).SingleOrDefault();
            db.Students.Remove(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}