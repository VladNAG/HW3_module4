using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_module4
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public virtual List<Project> Projects { get; set; } = new List<Project>();
    }
}
