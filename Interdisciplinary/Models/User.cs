using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interdisciplinary.Models
{
	public class User
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string Adress { get; set; }
        public string Summary { get; set; }
        public string Education { get; set; }
    }
}