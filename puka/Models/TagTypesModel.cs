using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace puka.Models
{
    public class TagTypesModel
    {
        public int ID { get; set; }
        public string tag { get; set; }
        public int? BranchTypesID { get; set; }
    }
}