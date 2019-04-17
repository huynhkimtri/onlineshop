﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar", Order = 1)]
        public string TagID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        [ForeignKey("TagID")]
        public Tag Tag { get; set; }
    }
}
