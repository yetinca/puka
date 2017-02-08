using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace puka.Models.DBModels
{
    [Table("TagRepAllocation")]
    public class TagRepAllocationDBModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int? TagID { get; set; }
        public virtual TagTypesDBModel TagTypesDBModel { get; set; }
        public int ? RepID { get; set; }
        public virtual ReportsDBModels ReportsDBModels { get; set; }

    }
}