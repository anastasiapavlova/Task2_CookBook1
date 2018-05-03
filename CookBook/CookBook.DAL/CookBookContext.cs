using System.Data.Entity;
namespace CookBook.DAL
{
    public class CookBookContext : DbContext
    {
        public CookBookContext(): base("DBConnection")
        { }

        public DbSet<Domain.Models.Composition> Compositions { get; set; }
        public DbSet<Domain.Models.Recipe> Recipes { get; set; }
        public DbSet<Domain.Models.Ingredient> Ingredients { get; set; }
        public DbSet<Domain.Models.Review> Reviews { get; set; }
        public DbSet<Domain.Models.User> Users { get; set; }
    }
}
