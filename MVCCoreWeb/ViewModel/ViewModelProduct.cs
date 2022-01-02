using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWeb.ViewModel
{
    public class ViewModelProduct
    {
        public int ProductId { get; set; }
       
        public string ProductName { get; set; }
       
        public decimal? Price { get; set; }

        public int? UserId { get; set; }
    }
}
