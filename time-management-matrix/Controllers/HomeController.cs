using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using time_management_matrix.Models;

namespace time_management_matrix.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tasks()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateTask()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditTask()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteTask()
        {
            return View();
        }
    }
}
