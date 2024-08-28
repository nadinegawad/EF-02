using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Enities
{
    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(30),MinLength(3)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public Decimal Bouns { get; set; }
        [DataType(DataType.Currency)]
        public Decimal Salary { get; set; }
        public string? Adress {  get; set; }
        [DataType(DataType.Currency)]
        public Decimal HourRate { get; set; }
        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        public Department Department { get; set; }
        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();

    }
}
