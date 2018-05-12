using Ninject;
using Ninject.Web.Mvc;
using CookBook.BLL;
using System.Reflection;
using System.Web.Mvc;
using CookBook.DAL;

namespace CookBook.PL.App_Start
{
    public class ResolverConfig
    {
        public static void Configure()
        {
            var container = new StandardKernel(new BusinessLogicNinjectModule(), new DataAccessNinjectModule());
            container.Load(Assembly.GetExecutingAssembly());
            container.Unbind<ModelValidatorProvider>();
            DependencyResolver.SetResolver(new NinjectDependencyResolver(container));
        }
    }
}