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

    }
}
