using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestCoreApp.Models;

namespace TestCoreApp.Data
{
    public class AppDbContext:DbContext
    {
        public readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }
            
        public DbSet<Category> Categories { get; set; }
    }

}

