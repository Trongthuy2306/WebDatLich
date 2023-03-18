using OnlineDoctor.Code;
using OnlineDoctor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineDoctor.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            var dao = new UserDao();
            return View(dao);
        }
    }
}