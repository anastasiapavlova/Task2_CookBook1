using CookBook.BLL.Interfaces;
using CookBook.BLL.Services;
using Ninject.Modules;

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
