using Ninject.Modules;
using CookBook.BLL.Services;
using CookBook.BLL.Interfaces;

namespace CookBook.BLL
{
    public class BusinessLogicNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICompositionService>().To<CompositionService>();
            Bind<IRecipeService>().To<RecipeService>();
            Bind<IReviewService>().To<ReviewService>();
            Bind<IUserService>().To<UserService>();
            Bind<IIngredientService>().To<IngredientService>();
        }
    }
}
