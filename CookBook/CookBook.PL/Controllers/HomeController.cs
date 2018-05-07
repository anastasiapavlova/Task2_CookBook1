using System.Collections.Generic;
using System.Web.Mvc;
using CookBook.BLL.Logic;
using CookBook.BLL.Models;

namespace CookBook.PL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<RecipeModel> recipelList = DataReader.ReadRecipes();
            return View(recipelList);
        }
        
        [HttpPost]
        public string DeleteRecipe(object item)
        {

            List<RecipeModel> recipelList = DataReader.ReadRecipes();
            return "Meow";
        }
    }
}