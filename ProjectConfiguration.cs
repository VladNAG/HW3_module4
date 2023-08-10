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
            builder.Property(c => c.ClientId).HasColumnName("ClientId").IsRequired(false);
            builder.HasOne(p => p.Client).WithMany(p => p.Projects).HasForeignKey(p => p.ClientId).OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<Project>()
            {
                new Project() { ProjectId = 10, Name = "Instagram", ClientId = 10, Budget = 24561, StartDate = new DateTime(2014, 03, 20) },
                new Project() { ProjectId = 20, Name = "Mono", ClientId = 11, Budget = 55665, StartDate = new DateTime(2016, 05, 10) },
                new Project() { ProjectId = 30, Name = "Onet", ClientId = 12, Budget = 1542, StartDate = new DateTime(2018, 07, 30) },
                new Project() { ProjectId = 40, Name = "Booolb", ClientId = 13, Budget = 846454, StartDate = new DateTime(2010, 08, 25) },
                new Project() { ProjectId = 50, Name = "Ms", ClientId = 14, Budget = 4894, StartDate = new DateTime(2021, 03, 21) }
            });
        }
    }
}
