using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTest.Models
{
    public class tblEmp
    {
        public int empId { get; set; }
        public string? empName { get; set; }
        public date hireDate { get; set; }
        public flot grossSalary { get; set; }
        public string? designation { get; set; }
        public string? gender { get; set; }
    }
}