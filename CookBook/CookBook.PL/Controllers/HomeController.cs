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
        
        public ActionResult DeleteRecipe(int id)
        {
            DataDeleter.DeleteRecipes(id);
            List<RecipeModel> recipelList = DataReader.ReadRecipes();
            return RedirectToAction("Index");
        }
    }
}