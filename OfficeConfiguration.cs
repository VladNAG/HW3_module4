using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW3_module4
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(t => t.OfficeId).HasColumnName("OffiseId");
            builder.Property(t => t.Ttitle).HasColumnName("Ttitle").HasMaxLength(100);
            builder.Property(f => f.Location).HasColumnName("Location").HasMaxLength(100);
        }
    }
}
