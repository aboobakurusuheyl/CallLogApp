using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatabaseContext;
using CouncelorNew.Models;

namespace CouncelorNew.Controllers
{
    public class CallInfoesController : Controller
    {
        private ContextDB db = new ContextDB();

        // GET: CallInfoes
        public async Task<ActionResult> Index()
        {
            return View(await db.CallInfos.Where(x=>x.IsDeleted != true).ToListAsync());
        }

        // GET: CallInfoes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CallInfo callInfo = await db.CallInfos.FindAsync(id);
            if (callInfo == null)
            {
                return HttpNotFound();
            }
            return View(callInfo);
        }

        // GET: CallInfoes/Create
        public ActionResult Create()
        {
            //var staff = db.Staffs.Where(x => x.IsDeleted == false).ToList();
            var stafflistDB = db.Staffs.Where(x => x.IsDeleted == false).Select(a => new Models.StaffsViewModel
            {
                StaffId  = a.StaffId,
                UserName = a.UserName
            }).ToList();
            var categories = db.CallCategories.Select(x => new Models.CategoriesViewModel
            {
                 CallCategoryId = x.CallCategoryId,
                 Description = x.Description
            }).ToList();
            var calllogmodel = new Models.CallInfoView();
            calllogmodel.StaffsList = stafflistDB;
            calllogmodel.CategoriesList = categories;
            return View(calllogmodel);
        }

        // POST: CallInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CallInfoView calllogmodel)
        {
            if (ModelState.IsValid)
            {
                var result = new CallInfo
                {
                    CallCategoryId = calllogmodel.CallCategoryId,
                    StaffId = calllogmodel.StaffId,
                    ReceivedDate = Convert.ToDateTime( calllogmodel.ReceivedDate),
                    Address = calllogmodel.Address,
                    CallDuration = calllogmodel.CallDuration,
                    Contact = calllogmodel.Contact,
                    Dob = Convert.ToDateTime(calllogmodel.Dob),
                    FullName = calllogmodel.FullName,
                    IsDeleted = calllogmodel.IsDeleted,
                    StatusId = 1,
                    Summary = calllogmodel.Summary
                };
                db.CallInfos.Add(result);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(calllogmodel);
        }

        // GET: CallInfoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //CallInfo callInfo = await db.CallInfos.FindAsync(id);
            var calllog = db.CallInfos.Where(x => x.CallInfoId == id).Select(a => new CouncelorNew.Models.CallInfoView
            {
                CallCategoryId = a.CallCategoryId,
                StaffId = a.StaffId,
                ReceivedDate = a.ReceivedDate,
                Address = a.Address,
                CallDuration = a.CallDuration,
                Contact = a.Contact,
                Dob = a.Dob,
                FullName = a.FullName,
                IsDeleted = a.IsDeleted,
                StatusId = a.StatusId,
                Summary = a.Summary,
                CallInfoId = a.CallInfoId
            }).FirstOrDefault();

            if (calllog == null)
            {
                return HttpNotFound();
            }
            var stafflistDB = db.Staffs.Where(x => x.IsDeleted == false).Select(a => new Models.StaffsViewModel
            {
                StaffId = a.StaffId,
                UserName = a.UserName
            }).ToList();

            var categories = db.CallCategories.Select(x => new Models.CategoriesViewModel
            {
                CallCategoryId = x.CallCategoryId,
                Description = x.Description
            }).ToList();

            calllog.StaffsList = stafflistDB;
            calllog.CategoriesList = categories;
            return View(calllog);
        }

        // POST: CallInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CallInfoView calllog)
        {
            if (ModelState.IsValid)
            {
                var log = db.CallInfos.Where(x => x.CallInfoId == calllog.CallInfoId).FirstOrDefault();
                log.CallDuration = calllog.CallDuration;
                log.Contact = calllog.Contact;
                log.Dob = calllog.Dob;
                log.FullName = calllog.FullName;
                log.ReceivedDate = calllog.ReceivedDate;
                log.StatusId = calllog.StatusId;
                log.Summary = calllog.Summary;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(calllog);
        }

        // GET: CallInfoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CallInfo callInfo = await db.CallInfos.FindAsync(id);
            if (callInfo == null)
            {
                return HttpNotFound();
            }
            return View(callInfo);
        }

        // POST: CallInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CallInfo callInfo = await db.CallInfos.FindAsync(id);
            db.CallInfos.Remove(callInfo);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
