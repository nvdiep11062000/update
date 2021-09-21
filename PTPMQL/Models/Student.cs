using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string NameStudent { get; set; }
        public String Address { get; set; }
    }
}