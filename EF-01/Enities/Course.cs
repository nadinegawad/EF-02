using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Enities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
        public ICollection<Stud_Course> courseStuds { get; set; }= new HashSet<Stud_Course>();
        public ICollection<Course_Inst> course_Insts { get; set; }= new HashSet<Course_Inst>();







    }
}
