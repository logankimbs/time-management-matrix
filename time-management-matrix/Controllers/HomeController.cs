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

        public HomeController(TaskFormContext context)
        {
            FormContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = FormContext.Responses.Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(tasks);
        }

        [HttpPost]
        public IActionResult Tasks(TaskForm ar)
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

        //HEAD =======>>>>>>> 70b4e17a25522dcf3bd489cf35758f3a52ff0955
        public IActionResult CreateTask()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditTask(int id)
        {
            ViewBag.Categories = FormContext.Categories.ToList();
            var task = FormContext.Responses.Single(task => task.TaskID == id);

            return View("Tasks", task);
        }

        [HttpGet]
        public IActionResult DeleteTask()
        {
            return View();
        }
    }
}
