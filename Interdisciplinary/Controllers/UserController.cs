using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterdisciplinaryDomainModel.Database;
using Interdisciplinary.Models;

namespace Interdisciplinary.Controllers
{
    public class UserController : Controller
    {
        // connection with the domain model
        private MysenseiEntities DB = new MysenseiEntities();
        // GET: User
        // get a list of users from teh User entity
        [Authorize]
        public ActionResult Index()
        {
            var users = DB.Users.ToList();

            return View(users);
        }
        
        [HttpGet]
        public ActionResult TeacherSignUp()
        {
            ViewBag.Courses = DB.Courses.ToList();
            return View();
        }
        // sign up for for teacher including validation is valid
        [HttpPost]
        public ActionResult TeacherSignUp(Models.User user)
        {
            if (ModelState.IsValid)
            {
                var newUser = new InterdisciplinaryDomainModel.Database.User() {FirstName = user.FirstName,
                    LastName=user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    Phone = user.Phone,
                    Address = user.Address,
                    Education = user.Education,
                    Birthday = user.Birthday,
                    Summary = user.Summary
                };
                var courses = DB.Courses.Where(c => user.CoursesId.Contains(c.ID)).ToList();
                foreach (var course in courses)
                {
                    newUser.Courses.Add(course);
                }
                DB.Users.Add(newUser);
                DB.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            ViewBag.Courses = DB.Courses.ToList();
            return View(user);
            

           
        }
        public ActionResult StudentSignUp()
        {
            return View();
        }
        // sign up for for student including validation is valid
        [HttpPost]
        public ActionResult StudentSignUp(Models.User user)
        {
            if (ModelState.IsValid)
            {
                var newUser = new InterdisciplinaryDomainModel.Database.User()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    Phone = user.Phone,
                    Address = user.Address,
                    Birthday = user.Birthday,
                };
                DB.Users.Add(newUser);
                DB.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View(user);
        }
        // dispose method for closing the connection to the DB
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DB.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}