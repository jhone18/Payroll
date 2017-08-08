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
            var deductionCodes = await _context.DeductionCode.AsNoTracking().ToListAsync();
            var timeSheetCodes = await _context.Timesheet2Code.AsNoTracking().OrderBy(t=> t.DisplayOrder).ToListAsync();
            var otSheetCodes = await _context.Otcode.AsNoTracking().OrderBy(t => t.DisplayOrder).ToListAsync();

            var tupleView = new Tuple<IEnumerable<EarningCode>, IEnumerable<DeductionCode>, IEnumerable<Timesheet2Code>, IEnumerable<Otcode>>(earningCodes, deductionCodes, timeSheetCodes, otSheetCodes);
            return View(tupleView);
        }

        [HttpGet]
        public async Task<JsonResult> GetDepartment()
        {
            try
            {
                var department = await _context.Department.AsNoTracking().ToListAsync();

                if (department == null)
                {
                    return null;
                }

                var result = (from c in department
                              let id = c.DeptCode
                              let label = c.DeptDescr
                              let value = c.DeptDescr
                              select new { id, value, label });

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetPayCode()
        {
            try
            {
                var payCode = await _context.PayCode.AsNoTracking().ToListAsync();

                if (payCode == null)
                {
                    return null;
                }

                var result = (from c in payCode
                              let id = c.PayCode1
                              let label = c.Description
                              let value = c.Description
                              select new { id, value, label });

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployeesById(string status, string term)
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

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployeesByName(string status, string term)
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

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployees(int draw, int start, int length, string status)
        {
            try
            {
                var employees = await _context.Employee.AsNoTracking().Where(e=> e.EmployeeStatus == status).ToListAsync();

                if (employees == null)
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = new Employee() });
                }

                var recordsTotal = employees.Count();
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = employees.Skip(start).Take(length) });
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployeesID(int draw, int start, int length, string employeeId, string status)
        {
            try
            {
                var employees = await _context.Employee.AsNoTracking().Where(e => e.EmployeeId == employeeId && e.EmployeeStatus == status).ToListAsync();

                if (employees == null)
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = new Employee() });
                }

                var recordsTotal = employees.Count();
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = employees.Skip(start).Take(length) });
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployeesByDepartment(int draw, int start, int length, string departmentId, string status)
        {
            try
            {
                var employees = await _context.Employee.AsNoTracking().Where(e=> e.Department == departmentId).ToListAsync();

                if (employees == null)
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = new Employee() });
                }

                var recordsTotal = employees.Count();
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = employees.Skip(start).Take(length) });
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployeesByPayCode(int draw, int start, int length, string payCode, string status)
        {
            try
            {
                var employees = await _context.Employee.AsNoTracking().Where(e=> e.PayCode == payCode).ToListAsync();

                if (employees == null)
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = new Employee() });
                }
                var recordsTotal = employees.Count();
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = employees.Skip(start).Take(length) });
            }
            catch
            {
                throw;
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
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = earning });
                }
                else
                {
                    earning = await _context.Earning.Include(e => e.Employee).Include(e => e.EarningCode).Where(e => e.EmployeeId == searchText && e.Employee.EmployeeStatus == status).AsNoTracking().ToListAsync();
                }
                var recordsTotal = earning.Count();

                if (earning == null)
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = earning });
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
                return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = new Earning() });
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
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data =deduction});
                }
                else
                {
                    deduction = await _context.Deduction.Include(e => e.Employee).Include(d=> d.DeductionCode).Where(e => e.EmployeeId == searchText && e.Employee.EmployeeStatus == status).AsNoTracking().ToListAsync();
                }
                var recordsTotal = deduction.Count();

                if (deduction == null)
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = deduction });
                }
                var data = (from d in deduction
                            let htmlButtons = "<a href = '#' onclick=show_PayrollDeduction('" + d.DeductionId + "'); class='item-action item-action-raised' title='Edit'>" +
                                            "<span class='glyphicon glyphicon-pencil' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<a href = '#' class='item-action item-action-danger' title='Delete' data-toggle='modal' data-target='#deleteDeductionModal" + d.DeductionId + "'>" +
                                            "<span class='glyphicon glyphicon-trash' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<div class='modal fade' id='deleteDeductionModal" + d.DeductionId + "' role='dialog' aria-labelledby='deductionModalLabel' aria-hidden='true'>" +
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
                                                        "<button type = 'button' class='btn btn-danger' id='deletePayrollDeduction' onclick=delete_PayrollDeduction('" + d.DeductionId + "');>Delete</button>" +
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
                return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = new Deduction() });
            }
        }

        // GET: Payroll/Details/5
        public async Task<JsonResult> DetailsIncome(int incomeId)
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
                throw;
            }
        }

        public async Task<JsonResult> DetailsDeduction(int deductionId)
        {
            try
            {
                var deduction = await _context.Deduction.Where(e => e.DeductionId == deductionId).AsNoTracking().SingleOrDefaultAsync();
                if (deduction == null)
                {
                    return null;
                }

                return Json(JsonConvert.SerializeObject(deduction));
            }
            catch
            {
                throw;
            }
        }

        public async Task<JsonResult> DetailsTimeSheet(string employeeId)
        {
            try
            {
                var timeSheet = await _context.Timesheet2.Include(t=> t.Timesheet2Code).Where(e => e.EmployeeId == employeeId).AsNoTracking().ToListAsync();
                if (timeSheet == null)
                {
                    return null;
                }

                return Json(JsonConvert.SerializeObject(timeSheet, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }));
            }
            catch
            {
                throw;
            }
        }

        public async Task<JsonResult> DetailsOTSheet(string employeeId)
        {
            try
            {
                var otSheet = await _context.Otsheet.Include(o=> o.OtcodeNavigation).Where(e => e.EmployeeId == employeeId).AsNoTracking().ToListAsync();
                if (otSheet == null)
                {
                    return null;
                }

                return Json(JsonConvert.SerializeObject(otSheet, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }));
            }
            catch
            {
                throw;
            }
        }

        public async Task<JsonResult> GetTimeSheetCodes()
        {
            try
            {
                var timeSheetCodes = await _context.Timesheet2Code.AsNoTracking().OrderBy(t => t.DisplayOrder).ToListAsync();
                if (timeSheetCodes == null)
                {
                    return null;
                }

                return Json(JsonConvert.SerializeObject(timeSheetCodes));
            }
            catch
            {
                throw;
            }
        }

        public async Task<JsonResult> GetOTSheetCodes()
        {
            try
            {
                var otSheetCodes = await _context.Otcode.AsNoTracking().OrderBy(t => t.DisplayOrder).ToListAsync();
                if (otSheetCodes == null)
                {
                    return null;
                }

                return Json(JsonConvert.SerializeObject(otSheetCodes));
            }
            catch
            {
                throw;
            }
        }

        // GET: Payroll/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Payroll/TimeSheet
        public ActionResult TimeSheet()
        {
            return View();
        }

        // GET: Payroll/OTSheet
        public ActionResult OTSheet()
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
                throw;
            }
        }

        [HttpPost]
        public JsonResult CreateDeduction(string deduction)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Deduction deductionObj = JsonConvert.DeserializeObject<Deduction>(deduction);
                    deductionObj.CreatedBy = "admin";
                    deductionObj.CreatedDate = DateTime.Now;
                    deductionObj.LastUpdBy = "admin";
                    deductionObj.LastUpdDate = DateTime.Now;
                    deductionObj.CompanyId = "ABC";

                    // TODO: Add update logic here
                    //_context.Update(user);
                    _context.Add(deductionObj);
                    _context.SaveChanges();
                }

                return Json(new { Success = true });
            }
            catch
            {
                throw;
            }
        }

        // GET: Payroll/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> EditTimeSheet(string timeSheet, string employeeId)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var tsData = await _context.Timesheet2.AsNoTracking().Where(t => t.EmployeeId == employeeId).ToListAsync();
                    if (tsData == null)
                    {
                        List<Timesheet2> timeSheetEntity = JsonConvert.DeserializeObject<List<Timesheet2>>(timeSheet);
                        foreach (var ts in timeSheetEntity)
                        {
                            ts.EmployeeId = employeeId;
                            ts.CompanyId = HttpContext.Session.GetString("CompanyId");
                            _context.Add(ts);
                            await _context.SaveChangesAsync();
                        }
                        
                    }
                    else
                    {
                        List<Timesheet2> timeSheetEntity = JsonConvert.DeserializeObject<List<Timesheet2>>(timeSheet);
                        foreach (var ts in timeSheetEntity)
                        {
                            var timeSheetToUpdate = _context.Timesheet2.Where(u => u.EmployeeId == employeeId && u.TsCode == ts.TsCode).FirstOrDefault();

                            if (timeSheetToUpdate == null)
                            {
                                ts.EmployeeId = employeeId;
                                ts.CompanyId = HttpContext.Session.GetString("CompanyId");
                                _context.Add(ts);
                            }
                            else
                            {
                                timeSheetToUpdate.TsDays = ts.TsDays;
                                timeSheetToUpdate.TsHrs = ts.TsHrs;
                                timeSheetToUpdate.TsMins = ts.TsMins;
                                _context.Entry(timeSheetToUpdate).State = EntityState.Modified;
                            }
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                return Json(new { Success = true });
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<JsonResult> EditOTSheet(string otSheet, string employeeId)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var tsData = await _context.Otsheet.AsNoTracking().Where(t => t.EmployeeId == employeeId).ToListAsync();
                    if (tsData == null)
                    {
                        List<Otsheet> otSheetEntity = JsonConvert.DeserializeObject<List<Otsheet>>(otSheet);
                        foreach (var ts in otSheetEntity)
                        {
                            ts.EmployeeId = employeeId;
                            ts.CompanyId = HttpContext.Session.GetString("CompanyId");
                            ts.CreatedBy = "admin";
                            ts.CreatedDate = DateTime.Now;
                            ts.LastUpdBy = "admin";
                            ts.LastUpdDate = DateTime.Now;
                            _context.Add(ts);
                            await _context.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        List<Otsheet> otSheetEntity = JsonConvert.DeserializeObject<List<Otsheet>>(otSheet);
                        foreach (var ts in otSheetEntity)
                        {
                            var otSheetData = _context.Otsheet.Where(u => u.EmployeeId == employeeId && u.Otcode == ts.Otcode).FirstOrDefault();
                            if (otSheetData != null)
                            {
                                _context.Entry(otSheetData).State = EntityState.Deleted;
                                await _context.SaveChangesAsync();
                            }

                            var otSheetToUpdate = _context.Otsheet.Where(u => u.EmployeeId == employeeId && u.Otcode == ts.Otcode).FirstOrDefault();
                            if (otSheetToUpdate == null)
                            {
                                ts.EmployeeId = employeeId;
                                ts.CompanyId = HttpContext.Session.GetString("CompanyId");
                                ts.CreatedBy = "admin";
                                ts.CreatedDate = DateTime.Now;
                                ts.LastUpdBy = "admin";
                                ts.LastUpdDate = DateTime.Now;
                                _context.Add(ts);
                            }
                            else
                            {
                                otSheetToUpdate.Othours = ts.Othours;
                                otSheetToUpdate.Ot8hours = ts.Ot8hours;
                                otSheetToUpdate.Otndhours = ts.Otndhours;
                                otSheetToUpdate.Otnd2hours = ts.Otnd2hours;
                                otSheetToUpdate.LastUpdBy = "admin";
                                otSheetToUpdate.LastUpdDate = DateTime.Now;
                                _context.Entry(otSheetToUpdate).State = EntityState.Modified;
                            }
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                return Json(new { Success = true });
            }
            catch
            {
                throw;
            }
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
                throw;
            }
        }

        [HttpPost]
        public async Task<JsonResult> EditDeduction(string deduction)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    Deduction deductionEntity = JsonConvert.DeserializeObject<Deduction>(deduction);
                    var incomeToUpdate = _context.Deduction.Where(u => u.DeductionId == deductionEntity.DeductionId).FirstOrDefault();

                    incomeToUpdate.TranDate = deductionEntity.TranDate;
                    incomeToUpdate.DedAmount = deductionEntity.DedAmount;
                    incomeToUpdate.RecurStart = deductionEntity.RecurStart;
                    incomeToUpdate.RecurEnd = deductionEntity.RecurEnd;
                    incomeToUpdate.Frequency = deductionEntity.Frequency;
                    _context.Entry(incomeToUpdate).State = EntityState.Modified;

                    //_context.Entry(loanToUpdate).CurrentValues.SetValues(loanObj);

                    // TODO: Add update logic here
                    await _context.SaveChangesAsync();
                }

                return Json(new { Success = true });
            }
            catch
            {
                throw;
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
                throw;
            }
        }

        [HttpPost]
        public JsonResult DeleteDeduction(long deductionId)
        {
            try
            {
                var deductionToDelete = _context.Deduction.Where(u => u.DeductionId== deductionId).FirstOrDefault();
                _context.Entry(deductionToDelete).State = EntityState.Deleted;
                _context.SaveChanges();
                return Json(new { Success = true });
            }
            catch
            {
                throw;
            }
        }
    }
}