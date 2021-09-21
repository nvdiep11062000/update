using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public string  UserName { get; set; }
        public string PassWord { get; set; }
    }
}