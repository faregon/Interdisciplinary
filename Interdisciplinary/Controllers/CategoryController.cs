using InterdisciplinaryDomainModel.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Interdisciplinary.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        // connection with the domain model
        private MysenseiEntities DB = new MysenseiEntities();
        // GET: Category
        // Generate a list with all of the categories in the Categories table
        public ActionResult Index()
        {
            var categories = DB.Categories.ToList();
            return View(categories);
        }
        // get courses for a specific category
        public ActionResult Courses(int id)
        {
            var category = DB.Categories.FirstOrDefault(c => c.ID == id);
            ViewBag.ID = category.ID;
            var courses = category.Courses.ToList();
            var users = DB.Users.Include(u => u.Courses).ToList();
            return View(users);
        }
    }
}