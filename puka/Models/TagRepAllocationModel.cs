using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace puka.Models
{
    public class TagRepAllocationModel
    {
        public int ID { get; set; }
        public int? TagID { get; set; }
        public int? RepID { get; set; }
    }
}