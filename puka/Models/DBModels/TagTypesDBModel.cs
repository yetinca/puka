using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace puka.Models.DBModels
{
    [Table("TagTypes")]
    public class TagTypesDBModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string tag { get; set; }
        public int? BranchTypesID { get; set; }
    }
}