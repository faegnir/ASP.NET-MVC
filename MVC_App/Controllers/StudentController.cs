using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_App.Controllers
{
    public class StudentController : Controller
    {
        StudentManager studentManager = new StudentManager(new EfStudentRepository());
        public IActionResult Index()
        {
            var values = studentManager.GetAllStudents();

            return View(values);
        }
    }
}
