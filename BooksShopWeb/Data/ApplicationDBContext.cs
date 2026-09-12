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
                new Category { Id = 1, Name = "Action" },
                new Category { Id = 2, Name = "Biography" },
                new Category { Id = 3, Name = "Children" },
                new Category { Id = 4, Name = "Crime" },
                new Category { Id = 5, Name = "Fantasy" }
            );
        }
    }
}
