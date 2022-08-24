﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_HotChoclate_EFCore.Models
{
    public class Employee
    { 
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }


    public class Excel
    {
        [Key]


        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }
}
