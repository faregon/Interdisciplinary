using InterdisciplinaryDomainModel.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interdisciplinary.Controllers
{
    public class CourseController : Controller
    {
        private MysenseiEntities DB = new MysenseiEntities();
        // GET: Course
        public ActionResult Index()
        {
            var users = DB.Users.ToList();
            return View(users);
        }
    }
}