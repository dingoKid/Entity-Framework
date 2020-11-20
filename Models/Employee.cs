using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadEntityFrameworkApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        
        [Column("FullName", TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        
        [Column("EmpCode", TypeName = "varchar(10)")]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; }
        
        [Column("Position", TypeName = "varchar(100)")]
        public string Position { get; set; }
        
        [Column("OfficeLocation", TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}