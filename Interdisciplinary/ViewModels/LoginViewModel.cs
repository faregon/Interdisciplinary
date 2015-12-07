using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interdisciplinary.ViewModels
{
    public class LoginViewModel
    {
        // email for login
        public string Email { get; set; }
        // paswword for log in
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}