using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhanSu.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department? Department {get; set;}
    }
}