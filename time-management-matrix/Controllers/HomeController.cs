using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using time_management_matrix.Models;
using Microsoft.EntityFrameworkCore;

namespace time_management_matrix.Controllers
{
    public class HomeController : Controller
    {
        private TaskFormContext FormContext { get; set; }

        public HomeController(TaskFormContext someName)
        {
            FormContext = someName;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TaskForm()
        {
            ViewBag.Categories = FormContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult TaskForm(TaskForm ar)
        {
            if (ModelState.IsValid)
            {
                FormContext.Add(ar);
                FormContext.SaveChanges();
                return View();
            }

            else
            {
                ViewBag.Categories = FormContext.Categories.ToList();
                return View();
            }
        }
        public IActionResult Quadrants()
        {
            return View();
        }
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
