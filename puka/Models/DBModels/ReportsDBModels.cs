using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace puka.Models.DBModels
{
    [Table("Reports")]
    public class ReportsDBModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime? date { get; set; }
        public int? TypesOfRepDBModelID { get; set; }
        public virtual TypesOfRepDBModel TypesOfRepDBModel { get; set; }
        public string title { get; set; }
        public bool forOUTSIDE { get; set; }
        public int? author { get; set; }
    }
}