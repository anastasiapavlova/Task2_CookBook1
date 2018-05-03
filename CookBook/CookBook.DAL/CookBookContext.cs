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
            modelBuilder.Entity<Recipe>()
                .HasMany(p => p.Composition)
                .WithRequired(p => p.Recipe)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Ingredient>()
                .HasMany(p => p.Composition)
                .WithRequired(p => p.Ingredient)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Recipe>()
                .HasMany(p => p.Review)
                .WithRequired(p => p.Recipe)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<User>()
                .HasMany(p => p.Review)
                .WithRequired(p => p.User)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<User>()
                .HasMany(p => p.Recipe)
                .WithRequired(p => p.User)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Ingredient>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Recipe>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Review>().Property(p => p.Description).IsRequired();
            modelBuilder.Entity<User>().Property(p => p.Login).IsRequired();
            modelBuilder.Entity<User>().Property(p => p.Password).IsRequired();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Domain.Models.Composition> Compositions { get; set; }
        public DbSet<Domain.Models.Recipe> Recipes { get; set; }
        public DbSet<Domain.Models.Ingredient> Ingredients { get; set; }
        public DbSet<Domain.Models.Review> Reviews { get; set; }
        public DbSet<Domain.Models.User> Users { get; set; }
    }
}
