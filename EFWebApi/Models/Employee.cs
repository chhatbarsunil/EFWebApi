using System;
using System.Collections.Generic;

#nullable disable

namespace EFWebApi.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
    }
}
