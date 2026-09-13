using BooksShopWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksShopWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Biography", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Children", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Crime", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Fantasy", DisplayOrder = 5 }
            );
        }
    }
}
