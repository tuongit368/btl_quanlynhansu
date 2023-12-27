using System.ComponentModel.DataAnnotations;

namespace NhanSu.Models
{
    public class Department
    {
        [Key]       
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }

    }
}