using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace puka.Models.DBModels
{
    [Table("Authors")]
    public class AuthorsDBModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string login { get; set; }
        public string nickname { get; set; }

    }
}