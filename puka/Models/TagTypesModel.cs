using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace puka.Models
{
    public class TagTypesModel
    {
        public int ID { get; set; }
        public string tag { get; set; }
        public string BranchTypesID { get; set; }
        public List<SelectListItem> BranchTypesDropDown { get; set; } = GetBranchTypesDropDown();
        private static List<SelectListItem> GetBranchTypesDropDown()
        {
            var db = new ApplicationDbContext();
            var list = new List<SelectListItem>();

            list.AddRange(db.BranchTypes.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.branch }).ToList());

            return list;
        }
    }
}