using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace puka.Models
{
    public class ReportsContentModel
    {
        public int ID { get; set; }
        public string cont { get; set; }
        public string author { get; set; }
        public List<SelectListItem> AuthorDropDown { get; set; } = GetAuthorsDropdown();
        public DateTime? date { get; set; }
        public int? reportID { get; set; }

        public static List<SelectListItem> GetAuthorsDropdown()
        {
            var db = new ApplicationDbContext();
            var list = new List<SelectListItem>();
            list.AddRange(db.Authors.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.nickname }).ToList());
            return list;
        }
    }

}