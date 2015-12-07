using Interdisciplinary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterdisciplinaryDomainModel.Database;
using System.Web.Security;
using System.Web.Helpers;

namespace Interdisciplinary.Controllers
{
    public class LoginController : Controller
    {
        // connection with the domain model
        private MysenseiEntities DB = new MysenseiEntities();
        // GET: Login
        // Login action method
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            var user = DB.Users.FirstOrDefault(x => x.Email.Equals(model.Email));
            
            if (user != null && user.Password == model.Password)
            {
                FormsAuthentication.SetAuthCookie(user.Email, model.RememberMe);
                ModelState.Clear();
                return RedirectToAction("Index", "Category");
                
            }
            else {
                ModelState.Clear();
                return RedirectToAction("Login", "Login");
            }
           
            return View();
        }
        // sign out action method
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}