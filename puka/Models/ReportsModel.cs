using puka.Models.DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace puka.Models
{
    public class ReportsModel
    {
        public int ID { get; set; }
        [Display(Name = "Data powstania")]
        public DateTime? date { get; set; }
        public string typestr { get; set; }
        [Display(Name = "Typ Raportu")]
        public int? TypesOfRepDBModelID { get; set; }
        public List<SelectListItem> TypeOfRepDropDown { get; set; } = GetTypeOfRepDropDown();
        [Display(Name = "Temat Raportu")]
        public string title { get; set; }
        [Display(Name = "Na zewnątrz")]
        public bool forOUTSIDE { get; set; }
        [Display(Name = "Autor")]
        public int? author { get; set; }
        public List<SelectListItem> authorDropDown { get; set; } = GetauthorDropDown();
        [ForeignKey("author")]
        public virtual AuthorsModel AuthorsModel { get; set; }
        [ForeignKey("TypesOfRepDBModelID")]
        public virtual TypesOfRepModel TypesOfRepModel { get; set; }


        private static List<SelectListItem> GetTypeOfRepDropDown()
        {
            var db = new ApplicationDbContext();

            var list = new List<SelectListItem>();

            list.AddRange(db.TypesOfRep.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.type }).ToList());

            return list;
        }
        private static List<SelectListItem> GetauthorDropDown()
        {
            var db = new ApplicationDbContext();

            var list = new List<SelectListItem>();

            list.AddRange(db.Authors.Select(p => new SelectListItem { Value = p.ID.ToString(), Text = p.nickname }).ToList());

            return list;
        }
    }
}