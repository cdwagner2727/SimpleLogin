using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleLogin.Models
{
    public class User
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Username")]
        [Key]
        public string Username { get; set; }

        [Required, Display(Name = "Password")]
        public string Password { get; set; }

        public string Joined { get; set; }
    }
}