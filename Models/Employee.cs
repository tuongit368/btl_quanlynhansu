using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace allin1.Models
{
     [Table("Employee")]
     public class Employee
     {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int EmployeeId { get; set; }

          
          [Required(ErrorMessage ="Name is required")]
          public string Name { get; set; }

          
          [Required(ErrorMessage ="Adres is required")]
          public string Adress { get; set; }
          
          [Required(ErrorMessage ="phone number is required")]
          public string PhoneNumber { get; set; }
          [Display(Name = " email ")]
          [Required(ErrorMessage ="email is required")]
          [DataType(DataType.EmailAddress)]
          public string Email { get; set; }
          

     }
}