using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWeb.Models
{
    public class EmployeModel
    {
        [Required (ErrorMessage ="Full Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is Required")]
        public DateTime? DateBirth { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile No is Required")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary is Required")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Website is Required")]
        public string Website { get; set; }

    }
}
