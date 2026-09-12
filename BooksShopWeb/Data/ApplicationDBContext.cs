using Microsoft.EntityFrameworkCore;

namespace BooksShopWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        // add DbSet<TEntity> properties here
    }
}
