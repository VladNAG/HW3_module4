using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HW3_module4
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(t => t.ClientId).HasColumnName("ClientId");
            builder.Property(f => f.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(f => f.LastName).HasColumnName("LastName").HasMaxLength(7);
            builder.Property(t => t.Age).HasColumnName("Age");
            builder.Property(c => c.Country).HasColumnName("County");
            builder.HasData(new List<Client>()
            {
                new Client() { ClientId = 10, LastName = "Ivanov", FirstName = "Ivan", Age = 35, Country = "Ukraine" },
                new Client() { ClientId = 11, LastName = "Mike", FirstName = "Tyson", Age = 25, Country = "Armenia" },
                new Client() { ClientId = 12, LastName = "Petr", FirstName = "Korobka", Age = 37, Country = "Ukraine" },
                new Client() { ClientId = 13, LastName = "Artem", FirstName = "Mex", Age = 28, Country = "Ukraine" },
                new Client() { ClientId = 14, LastName = "Jons", FirstName = "Jon", Age = 44, Country = "Ireland" },
            });
        }
    }
}
