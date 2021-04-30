using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _3hite.Models.Siniflar
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Surname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string Phone { get; set; }
        public decimal Price { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(400)]
        public string Mesage { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Mail { get; set; }
        public int Product { get; set; }
    }
}