using AutoMapper;
using puka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.QueryableExtensions;

namespace puka.Methods
{
    public class ReportsMethod
    {
        static ApplicationDbContext db = new ApplicationDbContext();

        public static List<ReportsModel> GetReports(string zapytanie)
        {
         

            var baza = (from m in db.Reports where m.title.Contains(zapytanie) select m).ToList();
            var model = Mapper.Map(baza, new List<ReportsModel>());
            Mapper.AssertConfigurationIsValid();

            return (model);
        }

    }
}