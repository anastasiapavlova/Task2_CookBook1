using CookBook.DAL.Interfaces;
using CookBook.DAL.Repositories;
using Ninject.Modules;

namespace CookBook.DAL
{
    public class DataAccessNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICompositionRepository>().To<CompositionRepository>();
            Bind<IIngredientRepository>().To<IngredientRepository>();
            Bind<IRecipeRepository>().To<RecipeRepository>();
            Bind<IReviewRepository>().To<ReviewRepository>();
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
