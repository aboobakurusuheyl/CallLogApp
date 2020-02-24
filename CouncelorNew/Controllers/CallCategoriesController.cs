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

namespace CouncelorNew.Controllers
{
    public class CallCategoriesController : Controller
    {
        private ContextDB db = new ContextDB();

        // GET: CallCategories
        public async Task<ActionResult> Index()
        {
            return View(await db.CallCategories.ToListAsync());
        }

        // GET: CallCategories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CallCategory callCategory = await db.CallCategories.FindAsync(id);
            if (callCategory == null)
            {
                return HttpNotFound();
            }
            return View(callCategory);
        }

        // GET: CallCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CallCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CallCategoryId,Description")] CallCategory callCategory)
        {
            if (ModelState.IsValid)
            {
                db.CallCategories.Add(callCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(callCategory);
        }

        // GET: CallCategories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CallCategory callCategory = await db.CallCategories.FindAsync(id);
            if (callCategory == null)
            {
                return HttpNotFound();
            }
            return View(callCategory);
        }

        // POST: CallCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CallCategoryId,Description")] CallCategory callCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(callCategory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(callCategory);
        }

        // GET: CallCategories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CallCategory callCategory = await db.CallCategories.FindAsync(id);
            if (callCategory == null)
            {
                return HttpNotFound();
            }
            return View(callCategory);
        }

        // POST: CallCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CallCategory callCategory = await db.CallCategories.FindAsync(id);
            db.CallCategories.Remove(callCategory);
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
