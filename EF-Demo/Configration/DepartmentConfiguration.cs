
using EF_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Demo.Configration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> builder)
        {
            //builder.HasKey(D => D.DeptId);

            //builder.Property(D => D.Dept_Id)
            //     .UseIdentityColumn(10, 10);

            //builder.Property(D => D.Name)
            //     .HasDefaultValue("Test")
            //     .HasColumnType("varchar")
            //     .HasColumnName("Dep_Name")
            //     .HasMaxLength(50)
            //     .IsRequired(false);
            //}
        }
    }
}
