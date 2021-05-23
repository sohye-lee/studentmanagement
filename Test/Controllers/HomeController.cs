using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Test.ViewModels;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Student()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher() { Name = "Sean", Class = "English" },
                new Teacher() { Name = "Daniel", Class = "Math" },
                new Teacher() { Name = "Noah", Class = "Art" },
                new Teacher() { Name = "Chloe", Class = "Music" }
            };

            var viewModel = new StudentTeacherViewModel()
            {
                Student = new Student(),
                Teachers = teachers
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Student(StudentTeacherViewModel model)
        {
            //if (model is null)
            //{
            //    throw new ArgumentNullException(nameof(model));
            //}
            if (ModelState.IsValid)
            {
                // SAVE MODEL TO STUDENT TABLE
            }
            else
            {
                // SHOW ERROR
            }

            return View();
        }
    }
}
