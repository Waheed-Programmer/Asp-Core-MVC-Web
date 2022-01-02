using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MVCCoreWeb.Models.Database
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserEmail { get; set; }
        [StringLength(50)]
        public string UserMobileNo { get; set; }

        [InverseProperty(nameof(Product.User))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
