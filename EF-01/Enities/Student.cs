﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Enities
{
    internal class Student
    {
        public int Id {  get; set; }
        [Required]
        public string FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        [ForeignKey("department")]
        public int Dept_Id { get; set;}
       
        public Department department { get; set; }
        public ICollection<Stud_Course> stud_Courses { get; set; } = new  HashSet<Stud_Course>();



    }
}
