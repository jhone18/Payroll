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
using System.Net;

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
            var companyId = HttpContext.Session.GetString("CompanyId");
            var employee = new Employee();

            if (string.IsNullOrEmpty(employeeId))
            {
                employees = await _context.Employee.AsNoTracking().ToListAsync();
                loans = await _context.Loan.Include(l => l.LoanCodeNavigation).Where(e=> e.Employee.EmployeeStatus.Trim() == status && e.CompanyId == companyId).ToListAsync();
            }
            else
            {
                employees = await _context.Employee.AsNoTracking().ToListAsync();
                loans = await _context.Loan.Include(l => l.LoanCodeNavigation).Include(e => e.Employee).Where(e => e.EmployeeId == employeeId && e.Employee.EmployeeStatus == status).ToListAsync();
                employee = await _context.Employee.AsNoTracking().SingleOrDefaultAsync(e => e.EmployeeId == employeeId);
            }
            var loanCodes = await _context.LoanCode.AsNoTracking().ToListAsync();
            empLoan.FilterByEmployeeId = employeeId;

            
            empLoan.FilterByEmployeeId = employeeId;
            empLoan.FilterByEmployeeName = employee == null ? string.Empty : employee.FullName;
            empLoan.FilterByStatus = status;
            var tupleView = new Tuple<IEnumerable<Loan>, IEnumerable<Employee>, IEnumerable<LoanCode>, EmployeeLoan>(loans, employees, loanCodes, empLoan);

            return View(tupleView);
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployees(string term)
        {
            try
            {
                var employees = await _context.Employee.AsNoTracking().Where(e=> e.FullName.Contains(term)).ToListAsync();

                if (employees == null)
                {
                    return null;
                }

                var result = (from c in employees
                              let id = c.EmployeeId
                              let label = c.FullName
                              let value = c.FullName
                              select new { id, value, label });

                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(JsonConvert.SerializeObject(new Employee()));
            }
        }

        // GET: Loans/Details/5
        public async Task<JsonResult> Details(long loanId)
        {
            try
            {
                var loan = await _context.Loan.AsNoTracking().SingleOrDefaultAsync(m => m.LoanId == loanId);
                loan.Employee = await _context.Employee.AsNoTracking().SingleAsync(e => e.EmployeeId == loan.EmployeeId);
                if (loan == null)
                {
                    return null;
                }


                return Json(JsonConvert.SerializeObject(loan));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                    loanObj.CreatedBy = "admin";
                    loanObj.CreatedDate = DateTime.Now;
                    loanObj.LastUpdBy = "admin";
                    loanObj.LastUpdDate = DateTime.Now;
                    loanObj.CompanyId = "ABC";

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
        public async Task<JsonResult> Edit(string loan)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    Loan loanEntity = JsonConvert.DeserializeObject<Loan>(loan);
                    var loanToUpdate = _context.Loan.Where(u => u.LoanCode == loanEntity.LoanCode).FirstOrDefault();

                    loanToUpdate.LoanCode = loanEntity.LoanCode;
                    loanToUpdate.Principal = loanEntity.Principal;
                    loanToUpdate.WithInterest = loanEntity.WithInterest;
                    loanToUpdate.TotalPayments = loanEntity.TotalPayments;
                    loanToUpdate.Balance = loanEntity.Balance;
                    loanToUpdate.Amortization = loanEntity.Amortization;
                    loanToUpdate.ApprovedDate = loanEntity.ApprovedDate;
                    loanToUpdate.StartDate = loanEntity.StartDate;
                    loanToUpdate.Remarks = loanEntity.Remarks;
                    loanToUpdate.Hold = loanEntity.Hold;
                    loanToUpdate.Frequency = loanEntity.Frequency;
                    _context.Entry(loanToUpdate).State = EntityState.Modified;
                    
                    //_context.Entry(loanToUpdate).CurrentValues.SetValues(loanObj);

                    // TODO: Add update logic here
                    await _context.SaveChangesAsync();
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
        public JsonResult Delete(long loanId)
        {
            try
            {
                var loanToDelete = _context.Loan.Where(u => u.LoanId == loanId).FirstOrDefault();
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