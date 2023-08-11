using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW3_module4
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            builder.Property(f => f.FirstName).HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(f => f.LastName).HasColumnName("LastName").HasMaxLength(50);
            builder.Property(e => e.HiredDate).HasColumnName("HiredDate");
            builder.Property(f => f.DateOfBirth).HasColumnName("DateOfBirth").IsRequired(false).HasColumnType("date");
            builder.Property(t => t.OfficeId).HasColumnName("OfficeId");
            builder.HasOne(t => t.Title).WithMany(e => e.Employees)
                                            .HasForeignKey(t => t.TitleId)
                                            .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(o => o.Office).WithMany(e => e.Employees)
                                           .HasForeignKey(o => o.OfficeId)
                                           .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
