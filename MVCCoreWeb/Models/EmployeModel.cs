using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWeb.Models
{
    public class EmployeModel
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Website { get; set; }

    }
}
