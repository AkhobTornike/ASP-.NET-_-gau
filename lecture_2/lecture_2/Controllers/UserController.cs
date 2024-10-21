using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lecture_2.Controllers
{
    public class UserController : Controller
    {
        // POST: User
        public ActionResult Create()
        {
            return View();
        }

        // GET: User
        public ActionResult List()
        {
            return View();
        }
    }
}