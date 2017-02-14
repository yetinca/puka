using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace puka.Models
{
    public class ReportsModel
    {
        public int ID { get; set; }
        public DateTime? date { get; set; }
        public string typestr { get; set; }
        public int? TypesOfRepDBModelID { get; set; }
        public List<SelectListItem> TypeOfRepDropDown { get; set; } = GetTypeOfRepDropDown();
        public string title { get; set; }
        public bool forOUTSIDE { get; set; }
        public int author { get; set; }

        private static List<SelectListItem> GetTypeOfRepDropDown()
        {
            var db = new ApplicationDbContext();

            var list = new List<SelectListItem>();

            list.AddRange(db.TypesOfRep.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.type }).ToList());

            return list;
        }
    }
}