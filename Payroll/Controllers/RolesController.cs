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
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return Json(new { Success = false });
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
                return Json(new { Success = false });
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
                return Json(new { Success = false });
            }
        }
    }
}