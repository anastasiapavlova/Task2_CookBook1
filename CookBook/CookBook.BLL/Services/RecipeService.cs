using System;
using Ninject;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.BLL.Mappers;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Interfaces;
using System.Collections.Generic;

namespace CookBook.BLL.Services
{
    public class RecipeService : IRecipeService
    {
        [Inject]
        public IRecipeRepository RecipeRepository { get; set; }
        [Inject]
        public ICompositionRepository CompositionRepository { get; set; }
        [Inject]
        public IReviewRepository ReviewRepository { get; set; }
        [Inject]
        public IUserRepository UserRepository { get; set; }
        [Inject]
        public IIngredientRepository IngredientRepository { get; set; }
        
        public List<RecipeModel> GetList()
        {
            var resultList = RecipeRepository.GetList();

            return resultList.Select(RecipeMapper.ConvertRecipeToRecipeModel).ToList();
        }

        public void AddItem(RecipeModel item)
        {
            RecipeRepository.Add(RecipeMapper.ConvertRecipeModelToRecipe(item));
        }

        public void AddItems(List<RecipeModel> items)
        {
            RecipeRepository.AddRange(items.Select(RecipeMapper.ConvertRecipeModelToRecipe).ToList());
        }

        public void DeleteItem(Guid id)
        {

            var compositions = CompositionRepository.GetList().Where(x => x.RecipeId == id).ToList();
            compositions.ForEach(x => CompositionRepository.Delete(x.Id));

            var reviews = ReviewRepository.GetList().Where(x => x.RecipeId == id).ToList();
            reviews.ForEach(x => ReviewRepository.Delete(x.Id));

            RecipeRepository.Delete(id);
        }

        public void UpdateItem(RecipeModel item)
        {
            RecipeRepository.Update(RecipeMapper.ConvertRecipeModelToRecipe(item));
        }

        public RecipeModel GetItem(Guid id)
        {
            var temp = RecipeRepository.GetItem(id);
            var tempIngr = IngredientRepository.GetList();
            var tempComp = CompositionRepository.GetList().Where(y => y.RecipeId == temp.Id).Select(CompositionMapper.ConvertCompositonToCompositionModel).ToList();
            tempComp.ForEach(y => y.IngredientName = tempIngr.Where(z => z.Id == y.IngredientId).FirstOrDefault()?.Name);

            return new RecipeModel
            {
                Id = temp.Id,
                Category = (Enums.CategoryTypes)temp.Category,
                Name = temp.Name,
                Composition = tempComp,
                Review = ReviewRepository.GetList().Where(y => y.Id == temp.Id).Select(ReviewMapper.ConvertReviewToReviewModel).ToList(),
                User = UserMapper.ConvertUserToUserModel(UserRepository.GetList().FirstOrDefault())
            };
        }
    }
}
