using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWeb.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Full Name is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name ="You can't proceed further untill you accept our terms and conditions.")]
        public bool IsAgreeTerm { get; set; }


    }
}
