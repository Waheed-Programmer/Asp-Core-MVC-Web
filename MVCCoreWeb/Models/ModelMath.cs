using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWeb.Models
{
    public class ModelMath
    {
        [Required(ErrorMessage ="Firs Number is Required")]
        public int FirstNum { get; set; }
        [Required(ErrorMessage ="Last Number is Required")]
        public int LastNum { get; set; }
        public int Result { get; set; }
    }
}
