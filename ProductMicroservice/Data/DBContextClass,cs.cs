using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Model;

namespace ProductMicroservice.Data
{
    public class DBContextClass_cs: DbContext
    {
        protected readonly IConfiguration Configuration;

        public DBContextClass_cs(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Product> Products { get; set; }
    }
}
