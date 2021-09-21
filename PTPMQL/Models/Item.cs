using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public string NameItem { get; set; }
        public int IDItem { get; set; }
    }
}