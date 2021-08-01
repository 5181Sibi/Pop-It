using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pop_It.Models;

namespace Pop_It.Controllers
{
    
        public class StudentsController : Controller
        {

                 public ActionResult StudentDashboard()
                 {
                     return View();
                 }
                public ActionResult Profile()
                {
                    return View();
                }
                public ActionResult StudyMaterials()
                {
                    return View();
                }
                public ActionResult Assessment()
                {
                return View();
                }
                public ActionResult Result()
                {
                return View();
                }
        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }





    }
}

