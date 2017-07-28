using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Payroll.Models;
using Payroll.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Payroll.Controllers
{
    public class CompanyController : Controller
    {

        private readonly PayrollContext _context;

        public CompanyController(PayrollContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Company.ToListAsync());
        }

        public IActionResult SelectedCompany(string companyId, string companyName)
        {
            HttpContext.Session.SetString("CompanyId",companyId);
            HttpContext.Session.SetString("CompanyName", companyName.Trim());
            return RedirectToAction("Index", "Home");
        }
    }
}