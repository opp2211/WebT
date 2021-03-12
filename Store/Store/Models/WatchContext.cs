using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Store.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class WatchContext : DbContext
    {
        public WatchContext() : base("conn") { }
        public DbSet<Watch> Watches { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
    }
}