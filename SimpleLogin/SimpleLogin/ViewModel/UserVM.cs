using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleLogin.Models;

namespace SimpleLogin.ViewModel
{
    public class UserVM
    {
        public User UserObj { get; set; }
        public List<User> UserList { get; set; }
    }
}