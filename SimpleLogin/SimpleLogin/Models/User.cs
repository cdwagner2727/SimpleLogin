using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleLogin.Models
{
    public class User
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        [Key]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }

        public string Joined { get; set; }
    }
}