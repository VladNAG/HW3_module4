using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_module4
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }

        [Column(TypeName="money")]
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public virtual List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
