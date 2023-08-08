using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW3_module4
{
    internal class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.Property(t => t.TitleId).HasColumnName("TitleId");
            builder.Property(f => f.Name).HasColumnName("Name").HasMaxLength(50);
        }
    }
}
