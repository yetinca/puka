using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace puka.Models.DBModels
{
    [Table("ReportsContent")]
    public class ReportsContentDBModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string cont { get; set; }
        public int? author { get; set; }
        public virtual AuthorsDBModel AuthorsDBModel { get; set; }
        public DateTime? date { get; set; }
        public int? reportID { get; set; }
        public virtual ReportsDBModels ReportDBModel { get; set; }
    }
}