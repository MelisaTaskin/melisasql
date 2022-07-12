using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace melisasql
{
    public class MyDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-HH46EBS\SQLEXPRESS;Database=melisasql;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);

        }
        public DbSet<Yeniurun> Yeniurun { get; set; }
    }
}
