using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HW3_module4
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }

        [Column(TypeName = "money")]
        public decimal Rate { get; set; }
        public DateTime StartDate { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
        public int ProjectId { get; set; }
        public virtual Project? Project { get; set; }
    }
}
