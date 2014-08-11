using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DbClasses
{
    public class TWContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
