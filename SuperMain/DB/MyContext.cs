using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMain.DB
{
    public class MyContext : DbContext
    {
        private string cs = "server=; database=; user id=; password=";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }

        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
