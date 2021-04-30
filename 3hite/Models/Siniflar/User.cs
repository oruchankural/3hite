using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _3hite.Models.Siniflar
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UserName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UserSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UserEmail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UserPassword { get; set; }
    }
}