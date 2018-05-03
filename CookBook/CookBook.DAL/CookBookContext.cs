using System.Data.Entity;
using CookBook.Domain.Models;

namespace CookBook.DAL
{
    public class CookBookContext : DbContext
    {
        public CookBookContext() : base("DBConnection")
        {
            if (!Database.Exists("DBConnection"))
            {
                Database.SetInitializer<CookBookContext>(new DropCreateDatabaseIfModelChanges<CookBookContext>());
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Composition>()
                .HasRequired(c => c.Recipe)
                .WithOptional(c => c.Composition);
            modelBuilder.Entity<User>()
                .HasMany(p => p.Review)
                .WithRequired(p => p.User)
                .WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Domain.Models.Composition> Compositions { get; set; }
        public DbSet<Domain.Models.Recipe> Recipes { get; set; }
        public DbSet<Domain.Models.Ingredient> Ingredients { get; set; }
        public DbSet<Domain.Models.Review> Reviews { get; set; }
        public DbSet<Domain.Models.User> Users { get; set; }
    }
}
