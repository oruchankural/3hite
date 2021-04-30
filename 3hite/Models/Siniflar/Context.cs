using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _3hite.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet <Category> Categories{ get; set; }
        public DbSet <Order> Orders{ get; set; }
        public DbSet <Product> Products{ get; set; }
        public DbSet <User> Users{ get; set; }
        public DbSet <Otomasyon> Otomasyons{ get; set; }
        public DbSet <Logo> Logos{ get; set; }
    }
}