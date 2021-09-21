﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int MyProperty { get; set; }
        public string Name { get; set; }
    }
}