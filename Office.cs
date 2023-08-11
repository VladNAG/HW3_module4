using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW3_module4
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Ttitle { get; set; }
        public string Location { get; set; }
        public virtual List<Employee>? Employees { get; set; } = new List<Employee>();
    }
}
