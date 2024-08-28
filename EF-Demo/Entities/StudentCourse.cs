using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Demo.Entities
{
    internal class StudentCourse
    {
        [ForeignKey("student")]
        public int StudentID { get; set; }
        [ForeignKey("course")]
        public int CourseID { get; set; }
        public int  Grade { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
        
    }
}
