using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleLogin.DAL;
using SimpleLogin.Models;

namespace SimpleLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(string username, string password)
        {
            UserDAL dal = new UserDAL();
            User u;
            if (dal.IsValid(username, password))
            {
                u = dal.GetUserByUsername(username);
                Session["User"] = u;
                return View("AccountSummary", u);
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            return View("Login");
        }

        public ActionResult AccountSummary()
        {
            if (Session["User"] == null)
            {
                return View("Login");
            }
            else
            {
                User u = Session["User"] as User;
                return View("AccountSummary", u);
            }
        }
    }
}