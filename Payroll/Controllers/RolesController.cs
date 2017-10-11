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
    public class RolesController : Controller
    {
        private readonly APPSECUContext _context;

        public RolesController(APPSECUContext context)
        {
            _context = context;
        }

        // GET: Roles
        public async Task<ActionResult> Index()
        {
            return View(await _context.Roles.ToListAsync());
        }

        // GET: Roles/Details/5
        public async Task<IActionResult> Details(int roleId)
        {
            try
            {
                var role = await _context.Roles.AsNoTracking().SingleOrDefaultAsync(r => r.RoleId == roleId);

                if (role == null)
                {
                    return null;
                }
                return Json(JsonConvert.SerializeObject(role));
            }
            catch
            {
                return Json(JsonConvert.SerializeObject(new Users()));
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetDetails(int draw, int start, int length)
        {
            try
            {
                var role = await _context.Roles.AsNoTracking().ToListAsync();
                var recordsTotal = role.Count();

                if (role == null)
                {
                    return null;
                }
                var data = (from d in role
                            let htmlButtons = "<a href = '#' onclick=show_Role('" + d.RoleId + "'); class='item-action item-action-raised' title='Edit'>" +
                                            "<span class='glyphicon glyphicon-pencil' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<a href = '#' class='item-action item-action-danger' title='Delete' data-toggle='modal' data-target='#deleteRoleModal" + d.RoleId + "'>" +
                                            "<span class='glyphicon glyphicon-trash' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<div class='modal fade' id='deleteRoleModal" + d.RoleId + "' role='dialog' aria-labelledby='roleModalLabel' aria-hidden='true'>" +
                                            "<div class='modal-dialog modal-sm' role='document'>" +
                                                "<div class='modal-content'>" +
                                                    "<div class='modal-header'>" +
                                                        "<button type = 'button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>" +
                                                        "<h4 class='modal-title' id='roleModalLabel'>Confirm Delete</h4>" +
                                                    "</div>" +
                                                    "<div class='modal-body'>" +
                                                        "Are you sure you want to delete " + d.ShortDesc + "?" +
                                                    "</div>" +
                                                    "<div class='modal-footer'>" +
                                                        "<button type = 'button' class='btn btn-danger' id='deleteRole' onclick=delete_Role('" + d.RoleId + "');>Delete</button>" +
                                                        "<button type = 'button' class='btn btn-default' data-dismiss='modal'>Close</button>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>"
                            select new { d.RoleId, d.ShortDesc, d.Description, htmlButtons });//JsonConvert.SerializeObject(role);

                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data.Skip(start).Take(length) });
            }
            catch
            {
                return Json(new { draw = draw, recordsFiltered = 0, recordsTotal = 0, data = new Roles() });
            }
        }
        // GET: Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        public JsonResult Create(string role)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Roles roleObj = JsonConvert.DeserializeObject<Roles>(role);
                    roleObj.Application = "Payroll";//ViewBag("Application");
                    // TODO: Add update logic here
                    //_context.Update(user);
                    _context.Add(roleObj);
                    _context.SaveChanges();
                }

                return Json(new { Success = true });
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Roles/Edit/5
        [HttpPost]
        public JsonResult Edit(string role)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    Roles roleObj = JsonConvert.DeserializeObject<Roles>(role);
                    var roleToUpdate = _context.Roles.Where(r => r.RoleId == roleObj.RoleId).FirstOrDefault();
                    roleObj.Application = roleToUpdate.Application;

                    _context.Entry(roleToUpdate).CurrentValues.SetValues(roleObj);

                    // TODO: Add update logic here
                    //_context.Update(user);
                    _context.SaveChanges();
                }

                return Json(new { Success = true });
            }
            catch
            {
                throw;
            }
        }

        // POST: Roles/Delete/5
        [HttpPost]
        public JsonResult Delete(int roleId)
        {
            try
            {
                var roleToDelete = _context.Roles.Where(r => r.RoleId == roleId).FirstOrDefault();
                _context.Entry(roleToDelete).State = EntityState.Deleted;
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