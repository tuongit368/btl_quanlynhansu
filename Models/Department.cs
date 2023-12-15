using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace rrorViewModel.Models
{
     [Table("Department")]
     public class Department 
     {
        [Key]
          public int DepartmentId { get; set; }
          public string Name { get; set; }
          public string Note { get; set; }

     }
}