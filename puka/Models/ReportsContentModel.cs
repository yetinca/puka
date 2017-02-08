using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace puka.Models
{
    public class ReportsContentModel
    {
        public int ID { get; set; }
        public string cont { get; set; }
        public int? author { get; set; }
        public DateTime? date { get; set; }
        public int? reportID { get; set; }
    }
}