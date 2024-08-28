using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Enities
{
    internal class Stud_Course
    {

        [ForeignKey("Student")]

        public int stud_ID {  get; set; }
        [ForeignKey("Course")]
       
        public int Course_ID {  get; set; }
        [Required]
        public int Grade {  get; set; }
       
      
        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
