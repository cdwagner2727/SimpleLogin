using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleLogin.Models;
using SimpleLogin.DAL;
using System.Data.Entity.Infrastructure;
using SimpleLogin.ViewModel;

namespace SimpleLogin.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View("Register");
        }

        //will call the database and check if username already exists, be upset with user if it does.
        public ActionResult Submit(User u)
        {
            UserDAL dal = new UserDAL();
            u.Joined = DateTime.Now.ToString();
            
            if (dal.IsUnique(u))
            {
                dal.Users.Add(u);
                dal.SaveChanges();
                return View("NewUserSummary", u);
            }
            else
            {
                return View("RegisterError", u);
            }
        }

    }
}