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

        [HttpGet]
        public ActionResult RaportsView()
        {
            var zapytanie = new StartModel();
            string zap = "";
            if (zapytanie.WyszukajWTemacie == null)
            {
                zap = " ";
            }
            else
            {
                zap = zapytanie.WyszukajWTemacie.ToString();

            }
            var model = ReportsMethod.GetReports(zap);
            return View(model);
        }
    }
}