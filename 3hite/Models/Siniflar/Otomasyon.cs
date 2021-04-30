using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _3hite.Models.Siniflar
{
    public class Otomasyon
    {
        [Key]
        public int ProductID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string ProductImage { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string ProductExp1 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string ProductExp2 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public Category Category { get; set; }
    }
}