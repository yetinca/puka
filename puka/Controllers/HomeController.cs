using puka.Methods;
using puka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace puka.Controllers
{
    public class HomeController : Controller
    {
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
            var model = ReportsAllMethod.GetAllReports();
            return View(model);
        }
    }
}