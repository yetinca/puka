using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace puka.Models
{
    public class ReportsModel
    {
        public int ID { get; set; }
        public DateTime? date { get; set; }
        public int? type { get; set; }
        public string title { get; set; }
        public bool forOUTSIDE { get; set; }
        public int author { get; set; }
    }
}