using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pop_It.Controllers
{
    public class ManageStudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
