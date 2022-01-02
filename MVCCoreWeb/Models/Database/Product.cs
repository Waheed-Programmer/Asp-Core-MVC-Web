using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MVCCoreWeb.Models.Database
{
    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        public int? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Products")]
        public virtual User User { get; set; }
    }
}
