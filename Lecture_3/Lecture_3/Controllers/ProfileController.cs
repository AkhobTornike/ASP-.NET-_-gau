using Lecture_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture_3.Controllers
{
    public class ProfileController : Controller
    {
        public static User loggedInUser = null;

        // GET: Login
        public ActionResult Index()
        {
            var users = UserList.UsersList;

            if (loggedInUser == null)
            {
                return RedirectToAction("Login");
            }
            else if (loggedInUser.IsAdmin)
            {
                return View("adminprofile", users);
            }
            else
            {
                return View("userprofile", loggedInUser);
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User Login)
        {
            try
            {
                if (Login != null)
                {
                    var enteredUser = UserList.UsersList.FirstOrDefault(u => u.Email == Login.Email && u.Password == Login.Password);
                    if (enteredUser != null)
                    {
                        loggedInUser = enteredUser;
                        Session["loggedInUser"] = enteredUser;

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Invalid email or password.";
                        return View();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return Register();
            }
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User Register)
        {
            try
            {
                if (Register != null)
                {
                    UserList.UsersList.Add(Register);
                }
                return RedirectToAction("Login");
            }
            catch
            {
                return Login();
            }
        }

        public ActionResult Logout()
        {
            loggedInUser = null;
            Session["loggedInUser"] = null;
            return RedirectToAction("Login");
        }
    }
}