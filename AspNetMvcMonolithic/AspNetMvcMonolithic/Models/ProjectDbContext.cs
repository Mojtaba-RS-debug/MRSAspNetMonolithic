using AspNetMvcMonolithic.Models.DomainModels.PersonAggregats;
using AspNetMvcMonolithic.Models.DomainModels.ProductAggregats;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AspNetMvcMonolithic.Models
{
    public class ProjectDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=.;Database=AspNetMvcMonolithic;Trusted_Connection=True;TrustServerCertificate=True;");

            }
             
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Product> Product { get; set; }
    }
}
