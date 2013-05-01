using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using ExquisiteCMS.Data;
using ExquisiteCMS.Data.Entities;
using ExquisiteCMS.Data.Repositories;
using ExquisiteCMS.Filters;
using ExquisiteCMS.Library.Authentication;

namespace ExquisiteCMS.Controllers
{
    public class LoginController : Controller
    {
        //
        // Post: /Login/

        [HttpPost]
        public ActionResult Login(User user)
        {
            Authentication auth = new Authentication();
            if (auth.Login(user.Email, user.Password))
            {
                User userLogin = Session["user"] as User;
                return RedirectToAction("Index", "Index", new { area = "Dashboard" });
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
