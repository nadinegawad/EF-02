
using EF_01.Enities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Context
{
    internal class ITIContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ;Database =ITI02;Trusted_connection = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
                        .HasKey(SC => new { SC.stud_ID, SC.Course_ID });
            modelBuilder.Entity<Course_Inst>()
                        .HasKey(IC => new { IC.inst_ID, IC.Course_ID });
            //modelBuilder.Entity<Student>()
            //            .HasMany(S => S.stud_Courses)
            //            .WithOne(Sc => Sc.Student)
            //            .IsRequired()
            //            .HasForeignKey(Sc => Sc.stud_ID);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> course_Inst { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Topic> Topics { get; set; }
     

    }
}
