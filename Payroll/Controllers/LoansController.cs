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

        public async Task<IActionResult> Index()
        {
            var loanCodes = await _context.LoanCode.AsNoTracking().ToListAsync();
            var tupleView = new Tuple<IEnumerable<LoanCode>>(loanCodes);

            return View(tupleView);
        }

        [HttpGet]
        public async Task<JsonResult> GetDetails(int draw, int start, int length, string empId, string status)
        {
            try
            {
                var loan = new List<Loan>();
                if (string.IsNullOrEmpty(empId))
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = loan });
                }
                else
                {
                    loan = await _context.Loan.Include(l => l.LoanCodeNavigation).Include(e=> e.Employee).Where(e=> e.EmployeeId == empId && e.Employee.EmployeeStatus == status).AsNoTracking().ToListAsync();
                }
                var recordsTotal = loan.Count();

                if (loan == null)
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = loan });
                }
                var data = (from d in loan
                            let htmlButtons = "<a href = '#' onclick=show_Loan('" + d.LoanId + "'); class='item-action item-action-raised' title='Edit'>" +
                                            "<span class='glyphicon glyphicon-pencil' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<a href = '#' class='item-action item-action-danger' title='Delete' data-toggle='modal' data-target='#deleteLoanModal" + d.LoanId + "'>" +
                                            "<span class='glyphicon glyphicon-trash' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<div class='modal fade' id='deleteLoanModal" + d.LoanId + "' role='dialog' aria-labelledby='loanModalLabel' aria-hidden='true'>" +
                                            "<div class='modal-dialog modal-sm' role='document'>" +
                                                "<div class='modal-content'>" +
                                                    "<div class='modal-header'>" +
                                                        "<button type = 'button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>" +
                                                        "<h4 class='modal-title' id='loanModalLabel'>Confirm Delete</h4>" +
                                                    "</div>" +
                                                    "<div class='modal-body'>" +
                                                        "Are you sure you want to delete ?" +
                                                    "</div>" +
                                                    "<div class='modal-footer'>" +
                                                        "<button type = 'button' class='btn btn-danger' id='deleteLoan' onclick=delete_Loan('" + d.LoanId + "');>Delete</button>" +
                                                        "<button type = 'button' class='btn btn-default' data-dismiss='modal'>Close</button>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>"
                            select new { d.LoanCode, d.LoanCodeNavigation.LoanDescr, d.Principal, d.WithInterest, d.ApprovedDate, htmlButtons });//JsonConvert.SerializeObject(loan);

                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data.Skip(start).Take(length) });
            }
            catch
            {
                return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = new Loan() });
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployees(string term, string status)
        {
            try
            {
                var employees = await _context.Employee.AsNoTracking().Where(e => e.FullName.Contains(term) && e.EmployeeStatus == status).ToListAsync();

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