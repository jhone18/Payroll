using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Payroll.Models;
using System.Net;
using Payroll.Data;
using Microsoft.EntityFrameworkCore;

namespace Payroll.Controllers
{
    public class PayrollController : Controller
    {

        private readonly PayrollContext _context;

        public PayrollController(PayrollContext context)
        {
            _context = context;
        }

        // GET: Payroll
        public async Task<IActionResult> Index()
        {
            var earningCodes = await _context.EarningCode.AsNoTracking().ToListAsync();
            var tupleView = new Tuple<IEnumerable<EarningCode>>(earningCodes);
            return View(tupleView);
        }

        [HttpGet]
        public async Task<JsonResult> GetDepartment(string term)
        {
            try
            {
                var department = await _context.Department.AsNoTracking().Where(e => e.DeptDescr.Contains(term)).ToListAsync();

                if (department == null)
                {
                    return null;
                }

                var result = (from c in department
                              let id = c.DeptCode
                              let label = c.DeptDescr
                              let value = c.DeptDescr
                              select new { id, value, label });

                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(JsonConvert.SerializeObject(new ViewAutoCompleteModel()));
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetPayCode(string term)
        {
            try
            {
                var payCode = await _context.PayCode.AsNoTracking().Where(e => e.PayCode1.Contains(term)).ToListAsync();

                if (payCode == null)
                {
                    return null;
                }

                var result = (from c in payCode
                              let id = c.PayCode1
                              let label = c.Description
                              let value = c.Description
                              select new { id, value, label });

                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(JsonConvert.SerializeObject(new ViewAutoCompleteModel()));
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployeesId(string term)
        {
            try
            {
                var employees = await _context.Employee.AsNoTracking().Where(e => e.EmployeeId.Contains(term)).ToListAsync();

                if (employees == null)
                {
                    return null;
                }

                var result = (from c in employees
                              let id = c.EmployeeId
                              let label = c.EmployeeId
                              let value = c.EmployeeId
                              select new { id, value, label });

                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(JsonConvert.SerializeObject(new ViewAutoCompleteModel()));
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
                return Json(JsonConvert.SerializeObject(new ViewAutoCompleteModel()));
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetIncomeDetails(int draw, int start, int length, string searchText, string status)
        {
            try
            {
                var earning = new List<Earning>();
                if (string.IsNullOrEmpty(searchText))
                {
                    earning = await _context.Earning.Include(e => e.Employee).Include(e=> e.EarningCode).Where(e => e.Employee.EmployeeStatus == status).AsNoTracking().ToListAsync();
                }
                else
                {
                    earning = await _context.Earning.Include(e => e.Employee).Include(e => e.EarningCode).Where(e => e.EmployeeId == searchText && e.Employee.EmployeeStatus == status).AsNoTracking().ToListAsync();
                }
                var recordsTotal = earning.Count();

                if (earning == null)
                {
                    return null;
                }
                var data = (from d in earning
                            let htmlButtons = "<a href = '#' onclick=show_PayrollIncome('" + d.EarningId + "'); class='item-action item-action-raised' title='Edit'>" +
                                            "<span class='glyphicon glyphicon-pencil' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<a href = '#' class='item-action item-action-danger' title='Delete' data-toggle='modal' data-target='#deleteIncomeModal" + d.EarningId + "'>" +
                                            "<span class='glyphicon glyphicon-trash' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<div class='modal fade' id='deleteIncomeModal" + d.EarningId + "' role='dialog' aria-labelledby='incomeModalLabel' aria-hidden='true'>" +
                                            "<div class='modal-dialog modal-sm' role='document'>" +
                                                "<div class='modal-content'>" +
                                                    "<div class='modal-header'>" +
                                                        "<button type = 'button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>" +
                                                        "<h4 class='modal-title' id='incomeModalLabel'>Confirm Delete</h4>" +
                                                    "</div>" +
                                                    "<div class='modal-body'>" +
                                                        "Are you sure you want to delete ?" +
                                                    "</div>" +
                                                    "<div class='modal-footer'>" +
                                                        "<button type = 'button' class='btn btn-danger' id='deleteIncome' onclick=delete_PayrollIncome('" + d.EarningId + "');>Delete</button>" +
                                                        "<button type = 'button' class='btn btn-default' data-dismiss='modal'>Close</button>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>"
                            select new { d.EarningCode.EarnDescr, d.TranDate, d.Amount, d.RecurStart, d.RecurEnd, d.Frequency, htmlButtons });

                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data.Skip(start).Take(length) });
            }
            catch
            {
                return Json(JsonConvert.SerializeObject(new Earning()));
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetDeductionDetails(int draw, int start, int length, string searchText, string status)
        {
            try
            {
                var deduction = new List<Deduction>();
                if (string.IsNullOrEmpty(searchText))
                {
                    deduction = await _context.Deduction.Include(e => e.Employee).Where(e => e.Employee.EmployeeStatus == status).AsNoTracking().ToListAsync();
                }
                else
                {
                    deduction = await _context.Deduction.Include(e => e.Employee).Where(e => e.EmployeeId == searchText && e.Employee.EmployeeStatus == status).AsNoTracking().ToListAsync();
                }
                var recordsTotal = deduction.Count();

                if (deduction == null)
                {
                    return null;
                }
                var data = (from d in deduction
                            let htmlButtons = "<a href = '#' onclick=show_Deduction('" + d.DeductionCode + "'); class='item-action item-action-raised' title='Edit'>" +
                                            "<span class='glyphicon glyphicon-pencil' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<a href = '#' class='item-action item-action-danger' title='Delete' data-toggle='modal' data-target='#deleteDeductionModal" + d.DeductionCode + "'>" +
                                            "<span class='glyphicon glyphicon-trash' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<div class='modal fade' id='deleteDeductionModal" + d.DeductionCode + "' role='dialog' aria-labelledby='deductionModalLabel' aria-hidden='true'>" +
                                            "<div class='modal-dialog modal-sm' role='document'>" +
                                                "<div class='modal-content'>" +
                                                    "<div class='modal-header'>" +
                                                        "<button type = 'button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>" +
                                                        "<h4 class='modal-title' id='deductionModalLabel'>Confirm Delete</h4>" +
                                                    "</div>" +
                                                    "<div class='modal-body'>" +
                                                        "Are you sure you want to delete ?" +
                                                    "</div>" +
                                                    "<div class='modal-footer'>" +
                                                        "<button type = 'button' class='btn btn-danger' id='deleteDeduction' onclick=delete_Deduction('" + d.DeductionCode + "');>Delete</button>" +
                                                        "<button type = 'button' class='btn btn-default' data-dismiss='modal'>Close</button>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>"
                            select new { d.DeductionCode.DedDescr, d.TranDate, d.DedAmount, d.RecurStart, d.RecurEnd, d.Frequency, htmlButtons });

                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data.Skip(start).Take(length) });
            }
            catch
            {
                return Json(JsonConvert.SerializeObject(new Deduction()));
            }
        }

        // GET: Payroll/Details/5
        public async Task<JsonResult> Details(int incomeId)
        {
            try
            {
                var earning = await _context.Earning.Where(e => e.EarningId == incomeId).AsNoTracking().SingleOrDefaultAsync();
                if (earning == null)
                {
                    return null;
                }

                return Json(JsonConvert.SerializeObject(earning));
            }
            catch
            {
                return Json(JsonConvert.SerializeObject(new Earning()));
            }
        }

        // GET: Payroll/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Payroll/Income
        public ActionResult Income()
        {
            return View();
        }

        // GET: Payroll/Deduction
        public ActionResult Deduction()
        {
            return View();
        }

        // POST: Payroll/Create
        [HttpPost]
        public JsonResult CreateIncome(string income)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Earning incomeObj = JsonConvert.DeserializeObject<Earning>(income);
                    incomeObj.CreatedBy = "admin";
                    incomeObj.CreatedDate = DateTime.Now;
                    incomeObj.LastUpdBy = "admin";
                    incomeObj.LastUpdDate = DateTime.Now;
                    incomeObj.CompanyId = "ABC";

                    // TODO: Add update logic here
                    //_context.Update(user);
                    _context.Add(incomeObj);
                    _context.SaveChanges();
                }

                return Json(new { Success = true });
            }
            catch
            {
                return Json(new { Success = false });
            }
        }

        // GET: Payroll/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Payroll/Edit/5
        [HttpPost]
        public async Task<JsonResult> EditIncome(string income)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    Earning incomeEntity = JsonConvert.DeserializeObject<Earning>(income);
                    var incomeToUpdate = _context.Earning.Where(u => u.EarningId == incomeEntity.EarningId).FirstOrDefault();

                    incomeToUpdate.TranDate = incomeEntity.TranDate;
                    incomeToUpdate.Amount = incomeEntity.Amount;
                    incomeToUpdate.RecurStart = incomeEntity.RecurStart;
                    incomeToUpdate.RecurEnd = incomeEntity.RecurEnd;
                    incomeToUpdate.Frequency = incomeEntity.Frequency;
                    _context.Entry(incomeToUpdate).State = EntityState.Modified;

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

        // GET: Payroll/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public JsonResult DeleteIncome(long incomeId)
        {
            try
            {
                var incomeToDelete = _context.Earning.Where(u => u.EarningId == incomeId).FirstOrDefault();
                _context.Entry(incomeToDelete).State = EntityState.Deleted;
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