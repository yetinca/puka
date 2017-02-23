using puka.Methods;
using puka.Models;
using puka.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace puka.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Home
        public ActionResult Index()
        {
           
            return View();
        }

     
        public ActionResult RaportsView(string wyszukaj)
        {
           
            if (wyszukaj == null)
            {
                wyszukaj = " ";
            }
           
            var model = ReportsMethod.GetReports(wyszukaj);
            return View(model);
        }

        public ActionResult NewReport()
        {
            var model = new ReportsModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult NewReport(ReportsModel model)
        {
            if (ModelState.IsValid)
            {
                var newModel = new ReportsDBModels();

                newModel.ID = model.ID;
                newModel.AuthorsDBModelID = model.author;
                newModel.date = model.date;
                newModel.TypesOfRepDBModelID = model.TypesOfRepDBModelID;
                newModel.title = model.title;
                newModel.forOUTSIDE = model.forOUTSIDE;

                db.Reports.Add(newModel);
                db.SaveChanges();

               return RedirectToAction(nameof(NewReport));
            }
            
            return View(model);
        }
    }
}