using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Payroll.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Personal()
        {
            return View();
        }
        
        public IActionResult Employment()
        {
            return View();
        }

        public IActionResult Payroll()
        {
            return View();
        }

        public IActionResult Statutory()
        {
            return View();
        }
    }
}