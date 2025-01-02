using Microsoft.EntityFrameworkCore;
using ShagoWeb.Models;

namespace ShagoWeb.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "XXX", DisplayOrder = 12 },
                 new Category { Id = 3, Name = "YYY", DisplayOrder = 13 },
                  new Category { Id = 5, Name = "ZZZ", DisplayOrder = 10 },
                   new Category { Id = 4, Name = "FFF", DisplayOrder = 11 },
                    new Category { Id = 2, Name = "DDD", DisplayOrder = 19 }
                );
        }

    }
}
