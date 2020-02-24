using CouncelorNew.Models;
using DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CouncelorNew.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext.ContextDB _db = new DatabaseContext.ContextDB();
        public ActionResult Index()
        {
            var dasboard = new DashboardViewModel();
            var total = _db.CallInfos.Count();
            var today = _db.CallInfos.Where(x => x.ReceivedDate == DateTime.Today);
            var pending = _db.CallInfos.Where(x => x.StatusId == 2);
            var resolved = _db.CallInfos.Where(x => x.StatusId == 1);
            dasboard.Today = today.Count();
            dasboard.Total = total;
            dasboard.Pending = pending.Count();
            dasboard.Resolved = resolved.Count();
            return View(dasboard);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}