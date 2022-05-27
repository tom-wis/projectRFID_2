using Microsoft.EntityFrameworkCore;
using projectRFID_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRFID_2
{
    public class ApplicationDbContext : DbContext

    {
        
           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=110DELL-12\ECSQLEXPRESS;Database=Registry;Trusted_Connection=True", options => options.EnableRetryOnFailure());
        }
        public DbSet<User>Users { get; set; }
        public DbSet<Registry> Registries { get; set; }
    }
    
}
