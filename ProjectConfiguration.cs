using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW3_module4
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(t => t.ProjectId).HasColumnName("ProjectId");
            builder.Property(f => f.Name).HasColumnName("Name").HasMaxLength(50);
            builder.Property(f => f.StartDate).HasColumnName("StartDate").HasMaxLength(7);
            builder.Property(t => t.Budget).HasColumnName("Budget");
        }
    }
}
