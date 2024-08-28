
using EF_Demo.Configration;
using EF_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Demo.Contexts
{
    internal class EnterPriceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ;Database =EnterPrise;Trusted_connection = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());


            //modelBuilder.Entity<Departments>().ToView("Department");
            //modelBuilder.Entity<Departments>(D =>
            //{

            // D.HasKey(D => D.Dept_Id);

            // D.Property(D => D.Dept_Id)
            //  .UseIdentityColumn(10, 10);

            // D.Property(D => D.Name)
            //  .HasDefaultValue("Test")
            //  .HasColumnType("varchar")
            //  .HasColumnName("Dep_Name")
            //  .HasMaxLength(50)
            //  .IsRequired(false);
            //});

            modelBuilder.Entity<Employee>()
               .HasOne(E => E.Departments)
               .WithMany(D => D.Employees);

            modelBuilder.Entity<StudentCourse>()
                        .HasKey(SC => new { SC.StudentID, SC.CourseID });
            modelBuilder.Entity<Student>()
                        .HasMany(S => S.studentCourses)
                        .WithOne(C => C.student)
                        .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Departments> Departments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Projects> Projects { get; set; }
    }
}
