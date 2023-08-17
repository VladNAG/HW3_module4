using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW3_module4
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.Property(t => t.EmployeeProjectId).HasColumnName("EmployeeProjectId");
            builder.Property(f => f.Rate).HasColumnName("Rate");
            builder.Property(f => f.StartDate).HasColumnName("StartDate").HasMaxLength(7);
            builder.HasKey(t => new { t.EmployeeId, t.ProjectId });
            builder.HasOne(sc => sc.Employee)
                   .WithMany(s => s.EmployeeProjects)
                   .HasForeignKey(sc => sc.EmployeeId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(sc => sc.Project)
                   .WithMany(s => s.EmployeeProjects)
                   .HasForeignKey(sc => sc.ProjectId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
