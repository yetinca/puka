using AutoMapper;
using puka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace puka.Methods
{
    public class ReportsAllMethod
    {
        static ApplicationDbContext db = new ApplicationDbContext();

        public static List<ReportsModel> GetAllReports()
        {
            var model = Mapper.Map(db.Reports.ToList(), new List<ReportsModel>());
            Mapper.AssertConfigurationIsValid();

            return (model);
        }
    }
}