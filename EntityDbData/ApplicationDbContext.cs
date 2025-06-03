using Asp.NetCore_MVC_Practice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Asp.NetCore_MVC_Practice.EntityDbData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }
        public DbSet<DbTable> StudentInfo { get; set; }
        public DbSet<Login> Account { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbTable>().HasData(
                new DbTable { Id = 1, Name = "Joshua", age = 19, Lastname = "Escarez" },
                new DbTable { Id = 2, Name = "Josh", age = 20, Lastname = "Manalo" },
                new DbTable { Id = 3, Name = "Leodevier", age = 19, Lastname = "Semilia" },
                new DbTable { Id = 4, Name = "U Morales", age = 30, Lastname = "Gaspado" }
            );
        }


    }
}
