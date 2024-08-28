using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Demo.Entities
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50),MinLength(10)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public Decimal Salary { get; set; }
        public int? Age { get; set; }
        public DateTime? Date { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Phone]
        public string Phone { get; set; }
        [ForeignKey("Departments")]
        public int Dept_Id {  get; set; }
        public Departments Departments { get; set; }
    }
}
