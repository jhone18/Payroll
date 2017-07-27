using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payroll.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Payroll.Models;

namespace Payroll.Controllers
{
    public class LoansController : Controller
    {
        private readonly PayrollContext _context;

        public LoansController(PayrollContext context)
        {
            _context = context;
        }

        // GET: Loans
        //public async Task<IActionResult> Index()
        //{
        //    //return View(await _context.Loan.Include(l=> l.LoanCodeNavigation).ToListAsync());

        //    //EmployeeLoan empLoan = new EmployeeLoan();
        //    var employees = await _context.Employee.AsNoTracking().ToListAsync();
        //    var loans = await _context.Loan.Include(l => l.LoanCodeNavigation).ToListAsync();


        //    var tupleView = new Tuple<IEnumerable<Loan>, IEnumerable<Employee>>(loans, employees);

        //    return View(tupleView);
        //}

        public async Task<IActionResult> Index(string employeeId,string status="ACTIVE")
        {
            //return View(await _context.Loan.Include(l=> l.LoanCodeNavigation).ToListAsync());
            //EmployeeLoan empLoan = new EmployeeLoan();
            var employees = new List<Employee>();
            var loans = new List<Loan>();
            var empLoan = new EmployeeLoan();
            if (string.IsNullOrEmpty(employeeId))
            {
                employees = await _context.Employee.AsNoTracking().ToListAsync();
                loans = await _context.Loan.Include(l => l.LoanCodeNavigation).Where(e=> e.Employee.EmployeeStatus.Trim() == status).ToListAsync();
            }
            else
            {
                employees = await _context.Employee.AsNoTracking().ToListAsync();
                loans = await _context.Loan.Include(l => l.LoanCodeNavigation).Include(e => e.Employee).Where(e => e.EmployeeId == employeeId && e.Employee.EmployeeStatus == status).ToListAsync();
                
            }
            empLoan.FilterByEmployeeId = employeeId;
            empLoan.FilterByStatus = status;
            var tupleView = new Tuple<IEnumerable<Loan>, IEnumerable<Employee>, EmployeeLoan>(loans, employees, empLoan);

            return View(tupleView);
        }

        public async Task<JsonResult> LoanCodes()
        {
            try
            {
                var loanCodes = await _context.LoanCode.AsNoTracking().ToListAsync();

                if (loanCodes == null)
                {
                    return null;
                }
                return Json(JsonConvert.SerializeObject(loanCodes));
            }
            catch
            {
                return Json(JsonConvert.SerializeObject(new LoanCode()));
            }
        }

        // GET: Loans/Details/5
        public async Task<JsonResult> Details(string loanCode)
        {
            try
            {
                if (string.IsNullOrEmpty(loanCode))
                {
                    return null;
                }

                var loan = await _context.Loan.AsNoTracking().SingleOrDefaultAsync(m => m.LoanCode == loanCode);

                if (loan == null)
                {
                    return null;
                }


                return Json(JsonConvert.SerializeObject(loan));
            }
            catch
            {
                return Json(JsonConvert.SerializeObject(new Loan()));
            }
        }

        // GET: Loans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Loans/Create
        [HttpPost]
        public JsonResult Create(string loan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Loan loanObj = JsonConvert.DeserializeObject<Loan>(loan);
                    // TODO: Add update logic here
                    //_context.Update(user);
                    _context.Add(loanObj);
                    _context.SaveChanges();
                }

                return Json(new { Success = true });
            }
            catch
            {
                return Json(new { Success = false });
            }
        }

        // GET: Loans/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Loans/Edit/5
        [HttpPost]
        public JsonResult Edit(string loan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Loan loanObj = JsonConvert.DeserializeObject<Loan>(loan);
                    var loanToUpdate = _context.Loan.Where(u => u.LoanCode == loanObj.LoanCode).FirstOrDefault();

                    _context.Entry(loanToUpdate).CurrentValues.SetValues(loanObj);

                    // TODO: Add update logic here
                    //_context.Update(user);
                    _context.SaveChanges();
                }

                return Json(new { Success = true });
            }
            catch
            {
                return Json(new { Success = false });
            }
        }

        // GET: Loans/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Loans/Delete/5
        [HttpPost]
        public JsonResult Delete(string loanCode)
        {
            try
            {
                var loanToDelete = _context.Loan.Where(u => u.LoanCode == loanCode).FirstOrDefault();
                _context.Entry(loanToDelete).State = EntityState.Deleted;
                _context.SaveChanges();
                return Json(new { Success = true });
            }
            catch
            {
                return Json(new { Success = false });
            }
        }
    }
}