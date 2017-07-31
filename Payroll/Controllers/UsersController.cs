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
            try
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
                var user = await _context.Users.AsNoTracking().ToListAsync();
                var recordsTotal = user.Count();

                if (user == null)
                {
                    return null;
                }
                var data = (from d in user
                            let htmlButtons = "<a href = '#' onclick=show_Users('"+d.UserId.Trim()+"'); class='item-action item-action-raised' title='Edit'>" +
                                            "<span class='glyphicon glyphicon-pencil' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<a href = '#' class='item-action item-action-danger' title='Delete' data-toggle='modal' data-target='#deleteUserModal"+d.UserId.Trim()+"'>" +
                                            "<span class='glyphicon glyphicon-trash' aria-hidden='true'></span>" +
                                        "</a>" +
                                        "<div class='modal fade' id='deleteUserModal"+d.UserId.Trim()+"' role='dialog' aria-labelledby='userModalLabel' aria-hidden='true'>" +
                                            "<div class='modal-dialog modal-sm' role='document'>" +
                                                "<div class='modal-content'>" +
                                                    "<div class='modal-header'>" +
                                                        "<button type = 'button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>" +
                                                        "<h4 class='modal-title' id='userModalLabel'>Confirm Delete</h4>" +
                                                    "</div>" +
                                                    "<div class='modal-body'>" +
                                                        "Are you sure you want to delete " + d.UserId + "?" +
                                                    "</div>" +
                                                    "<div class='modal-footer'>" +
                                                        "<button type = 'button' class='btn btn-danger' id='deleteUser' onclick=delete_Users('" + d.UserId.Trim()+"');>Delete</button>" +
                                                        "<button type = 'button' class='btn btn-default' data-dismiss='modal'>Close</button>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>"
                            select new { d.UserId, d.UserFname, d.UserLname, d.Activated, d.Status, htmlButtons });//JsonConvert.SerializeObject(user);
               
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data.Skip(start).Take(length) });
            }
            catch
            {
                return Json(JsonConvert.SerializeObject(new Users()));
            }
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
            try
            {
                if (ModelState.IsValid)
                {
                    Users userObj = JsonConvert.DeserializeObject<Users>(user);
                    userObj.Application = "PAYROLL";//ViewBag("Application");
                    // TODO: Add update logic here
                    //_context.Update(user);
                    _context.Add(userObj);
                    _context.SaveChanges();
                }

                return Json(new { Success = true });
            }
            catch
            {
                return Json(new { Success = false });
            }
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
            try
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
            catch
            {
                return Json(new { Success = false });
            }
        }

        // GET: Users/Delete/5
        [HttpPost]
        public JsonResult Delete(string userId)
        {
            try
            {
                var userToDelete = _context.Users.Where(u => u.UserId == userId).FirstOrDefault();
                _context.Entry(userToDelete).State = EntityState.Deleted;
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