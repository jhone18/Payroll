using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payroll.Data;
using Payroll.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.Http;

namespace Payroll.Controllers
{
    public class UsersController : Controller
    {

        private readonly APPSECUContext _context;

        public UsersController(APPSECUContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<JsonResult> Details(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return null;
            }

            var user = await _context.Users.AsNoTracking().SingleOrDefaultAsync(m => m.UserId == userId);

            if (user == null)
            {
                return null;
            }


            return Json(JsonConvert.SerializeObject(user));
        }

        // GET: Users/Detail/5
        public async Task<IActionResult> Detail(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return NotFound();
            }

            var user = await _context.Users.AsNoTracking().SingleOrDefaultAsync(m => m.UserId == userId);

            if (user == null)
            {
                return NotFound();
            }


            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public JsonResult Create(string user)
        {
            if (ModelState.IsValid)
            {
                Users userObj = JsonConvert.DeserializeObject<Users>(user);
                userObj.Application = "Payroll";//ViewBag("Application");
                userObj.Password = "";
                // TODO: Add update logic here
                //_context.Update(user);
                _context.Add(userObj);
                _context.SaveChanges();
            }

            return Json(new { Success = true });
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public JsonResult Edit(string jsonData)
        {
            if (ModelState.IsValid)
            {
                Users user = JsonConvert.DeserializeObject<Users>(jsonData);
                var usersToUpdate = _context.Users.Where(u => u.UserId == user.UserId).FirstOrDefault();
                user.Application = usersToUpdate.Application;
                user.Password = usersToUpdate.Password;

                _context.Entry(usersToUpdate).CurrentValues.SetValues(user);

                // TODO: Add update logic here
                //_context.Update(user);
                _context.SaveChanges();
            }

            return Json(new { Success = true });
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        // GET: Users/Delete/5
        [HttpPost]
        public JsonResult Delete(string userId)
        {
            var userToDelete = _context.Users.Where(u => u.UserId == userId).FirstOrDefault();
            _context.Entry(userToDelete).State = EntityState.Deleted;
            _context.SaveChanges();
            return Json(new { Success = true });
        }
    }
}