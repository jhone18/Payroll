using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Payroll.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Payroll.Models;

namespace Payroll.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly PayrollContext _context;

        public EmployeeController(PayrollContext context)
        {
            _context = context;
        }

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

        public async Task<JsonResult> GetEmploymentDetails(string empId)
        {
            try
            {
                var employee = await _context.Employee.AsNoTracking().Where(e=> e.EmployeeId == empId).ToListAsync();

                if (employee == null)
                {
                    return null;
                }

                return Json(JsonConvert.SerializeObject(employee));
            }
            catch
            {
                throw;
            }
        }

        public async Task<JsonResult> GetPayrollDetails(string empId)
        {
            try
            {
                var payroll = await _context.PayMast.AsNoTracking().Where(e => e.EmployeeId == empId).ToListAsync();

                if (payroll == null)
                {
                    return null;
                }

                return Json(JsonConvert.SerializeObject(payroll));
            }
            catch
            {
                throw;
            }
        }

        #region Employment
        public async Task<JsonResult> GetEmploymentType()
        {
            try
            {
                var employmentType = await _context.EmploymentType.AsNoTracking().ToListAsync();

                if (employmentType == null)
                {
                    return null;
                }

                var result = (from c in employmentType
                              let id = c.Code
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

        public async Task<JsonResult> GetRank()
        {
            try
            {
                var rank = await _context.Rank.AsNoTracking().ToListAsync();

                if (rank == null)
                {
                    return null;
                }

                var result = (from c in rank
                              let id = c.RankCode
                              let label = c.RankName
                              let value = c.RankName
                              select new { id, value, label });

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }

        public async Task<JsonResult> GetEmploymentStatus()
        {
            try
            {
                var employmentStatus = await _context.EmployeeStatus.AsNoTracking().ToListAsync();

                if (employmentStatus == null)
                {
                    return null;
                }

                var result = (from c in employmentStatus
                              let id = c.Code
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

        public async Task<JsonResult> GetDivision()
        {
            try
            {
                var companyId = HttpContext.Session.GetString("CompanyId");
                var division = await _context.Division.AsNoTracking().Where(d=> d.CompanyId == companyId).ToListAsync();
                
                if (division == null)
                {
                    return null;
                }

                var result = (from c in division
                              let id = c.DivCode
                              let label = c.DivDescr
                              let value = c.DivDescr
                              select new { id, value, label });

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }

        public async Task<JsonResult> GetDepartment(string division)
        {
            try
            {
                var companyId = HttpContext.Session.GetString("CompanyId");
                var department = await _context.Department.AsNoTracking().Where(d=> d.CompanyId == companyId && d.DivCode.Trim() == division.Trim()).ToListAsync();
                
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

        public async Task<JsonResult> GetSection(string department)
        {
            try
            {
                var companyId = HttpContext.Session.GetString("CompanyId");
                var section = await _context.Section.AsNoTracking().Where(s=> s.CompanyId == companyId && s.DeptCode.Trim() == department.Trim()).ToListAsync();
                
                if (section == null)
                {
                    return null;
                }

                var result = (from c in section
                              let id = c.SectCode
                              let label = c.SectDescr
                              let value = c.SectDescr
                              select new { id, value, label });

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }

        public async Task<JsonResult> GetCostCenter()
        {
            try
            {
                var companyId = HttpContext.Session.GetString("CompanyId");
                var costCenter = await _context.CostCenter.AsNoTracking().Where(c => c.CompanyId == companyId).ToListAsync();

                if (costCenter == null)
                {
                    return null;
                }

                var result = (from c in costCenter
                              let id = c.Cccode
                              let label = c.Ccdescr
                              let value = c.Ccdescr
                              select new { id, value, label });

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Payroll
        public IActionResult Payroll()
        {
            return View();
        }

        public async Task<JsonResult> GetPayCode()
        {
            try
            {
                var companyId = HttpContext.Session.GetString("CompanyId");
                var payCode = await _context.PayCode.AsNoTracking().Where(p=> p.CompanyId == companyId).ToListAsync();

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

        public async Task<JsonResult> GetPayrollType()
        {
            try
            {
                var payrollType = await _context.PayrollType.AsNoTracking().ToListAsync();

                if (payrollType == null)
                {
                    return null;
                }

                var result = (from c in payrollType
                              let id = c.PayrollType1
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

        public async Task<JsonResult> GetBank()
        {
            try
            {
                var bank = await _context.Bank.AsNoTracking().ToListAsync();

                if (bank == null)
                {
                    return null;
                }

                var result = (from c in bank
                              let id = c.BankCode.Trim()
                              let label = c.BankName
                              let value = c.BankName
                              select new { id, value, label });

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }

        public async Task<JsonResult> GetBankBranch(string bankCode)
        {
            try
            {
                var bankBranch = await _context.BankBranch.AsNoTracking().Where(b=> b.BankCode == bankCode).ToListAsync();

                if (bankBranch == null)
                {
                    return null;
                }

                var result = (from c in bankBranch
                              let id = c.BankBranchId
                              let label = c.BranchName
                              let value = c.BranchName
                              select new { id, value, label });

                return Json(JsonConvert.SerializeObject(result));
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Statutory
        public IActionResult Statutory()
        {
            return View();
        }

        public async Task<JsonResult> GetTEU()
        {
            try
            {
                var teu = await _context.Teu.AsNoTracking().ToListAsync();

                if (teu == null)
                {
                    return null;
                }

                var result = (from c in teu
                              let id = c.Code
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
        #endregion

        #region Dependents
        public IActionResult Dependents()
        {
            return View();
        }
        public async Task<JsonResult> GetDependentsDetail(int draw, int start, int length, string employeeId)
        {
            try
            {
                var dependents = new List<Dependents>();
                var companyId = HttpContext.Session.GetString("CompanyId");
                if (string.IsNullOrEmpty(employeeId))
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = dependents });
                }
                else
                {
                    dependents = await _context.Dependents.Where(d=> d.EmployeeId.Trim() == employeeId.Trim() && d.CompanyId.Trim() == companyId.Trim() ).AsNoTracking().ToListAsync();
                }
                var recordsTotal = dependents.Count();

                if (dependents == null)
                {
                    return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = dependents });
                }
                var data = (from d in dependents
                            let htmlButtons = "<a href = '#' onclick=show_Dependents('" + d.RowId + "'); class='item-action item-action-raised' title='Edit'>" +
                                            "<span class='glyphicon glyphicon-pencil' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<a href = '#' class='item-action item-action-danger' title='Delete' data-toggle='modal' data-target='#deleteDependentsModal" + d.RowId + "'>" +
                                            "<span class='glyphicon glyphicon-trash' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<div class='modal fade' id='deleteDependentsModal" + d.RowId + "' role='dialog' aria-labelledby='dependentsModalLabel' aria-hidden='true'>" +
                                            "<div class='modal-dialog modal-sm' role='document'>" +
                                                "<div class='modal-content'>" +
                                                    "<div class='modal-header'>" +
                                                        "<button type = 'button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>" +
                                                        "<h4 class='modal-title' id='dependentsModalLabel'>Confirm Delete</h4>" +
                                                    "</div>" +
                                                    "<div class='modal-body'>" +
                                                        "Are you sure you want to delete ?" +
                                                    "</div>" +
                                                    "<div class='modal-footer'>" +
                                                        "<button type = 'button' class='btn btn-danger' id='deleteDependents' onclick=delete_Dependents('" + d.RowId + "');>Delete</button>" +
                                                        "<button type = 'button' class='btn btn-default' data-dismiss='modal'>Close</button>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>"
                            select new { d.DependentName, d.BirthDate, htmlButtons });

                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data.Skip(start).Take(length) });
            }
            catch
            {
                return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = new Dependents() });
            }
        }
        public async Task<IActionResult> DetailsDependents(int dependentsId)
        {
            try
            {
                var dependent = await _context.Dependents.AsNoTracking().SingleOrDefaultAsync(d => d.RowId == dependentsId);

                if (dependent == null)
                {
                    return null;
                }
                return Json(JsonConvert.SerializeObject(dependent));
            }
            catch
            {
                return Json(JsonConvert.SerializeObject(new Users()));
            }
        }
        [HttpPost]
        public JsonResult CreateDependents(string dependents)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Dependents dependentsObj = JsonConvert.DeserializeObject<Dependents>(dependents);
                    dependentsObj.CompanyId = HttpContext.Session.GetString("CompanyId");
                    _context.Add(dependentsObj);
                    _context.SaveChanges();
                }

                return Json(new { Success = true });
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public JsonResult EditDependents(string dependents)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    Dependents dependentsObj = JsonConvert.DeserializeObject<Dependents>(dependents);
                    var dependentsToUpdate = _context.Dependents.Where(d => d.RowId == dependentsObj.RowId).FirstOrDefault();
                    dependentsObj.CompanyId = HttpContext.Session.GetString("CompanyId");

                    _context.Entry(dependentsToUpdate).CurrentValues.SetValues(dependentsObj);
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
        public JsonResult DeleteDependents(int dependentsId)
        {
            try
            {
                var dependentsToDelete = _context.Dependents.Where(d => d.RowId == dependentsId).FirstOrDefault();
                _context.Entry(dependentsToDelete).State = EntityState.Deleted;
                _context.SaveChanges();
                return Json(new { Success = true });
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}