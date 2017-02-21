using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace puka.Models
{
    public class TagRepAllocationModel
    {
        public int ID { get; set; }
        public int? TagID { get; set; }
        [ForeignKey("TagID")]
        public virtual TagTypesModel TagTypesModel { get; set; }
        public int? RepID { get; set; }
        [ForeignKey("RepID")]
        public virtual ReportsModel ReportsModel { get; set; }
    }
}