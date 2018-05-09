using System;
using System.Linq;
using CookBook.BLL.Models;
using CookBook.BLL.Mappers;
using CookBook.Domain.Models;
using CookBook.BLL.Interfaces;
using CookBook.DAL.Repositories;
using System.Collections.Generic;
using CookBook.DAL.Interfaces;
using CookBook.Domain.Enums;

namespace CookBook.BLL.Services
{
    public class RecipeService : IRecipeService
    {
        private IRecipeRepository _recipeRepository;
        private ICompositionRepository _compositionRepository;
        private IReviewRepository _reviewRepository;
        private IUserRepository _userRepository;
        private IIngredientRepository _ingredientRepository;

        public RecipeService(IRecipeRepository recipeRepository, ICompositionRepository compositionRepository,
            IReviewRepository reviewRepository, IUserRepository userRepository, IIngredientRepository ingredientRepository)
        {
            _recipeRepository = recipeRepository;
            _compositionRepository = compositionRepository;
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
            _ingredientRepository = ingredientRepository;
        }

        public List<RecipeModel> GetList()
        {
            var resultList = _recipeRepository.GetList();

            return resultList.Select(x => new RecipeModel
            {
                Id = x.Id,
                Category = (Enums.CategoryTypes)x.Category,
                Name = x.Name,
                Composition = _compositionRepository.GetList().Where(y => y.RecipeId == x.Id).Select(CompositionMapper.ConvertCompositonToCompositionModel).ToList(),
                Review = _reviewRepository.GetList().Where(y => y.Id == x.Id).Select(ReviewMapper.ConvertReviewToReviewModel).ToList(),
                User = UserMapper.ConvertUserToUserModel(_userRepository.GetList().FirstOrDefault())
            }).ToList();
        }

        public void AddItem(RecipeModel item)
        {
            _recipeRepository.Add(RecipeMapper.ConvertRecipeModelToRecipe(item));
        }

        public void AddItems(List<RecipeModel> items)
        {
            _recipeRepository.AddRange(items.Select(RecipeMapper.ConvertRecipeModelToRecipe).ToList());
        }

        public void DeleteItem(Guid id)
        {

            var compositions = _compositionRepository.GetList().Where(x => x.RecipeId == id).ToList();
            compositions.ForEach(x => _compositionRepository.Delete(x.Id));

            var reviews = _reviewRepository.GetList().Where(x => x.RecipeId == id).ToList();
            reviews.ForEach(x => _reviewRepository.Delete(x.Id));

            _recipeRepository.Delete(id);
        }

        public void UpdateItem(RecipeModel item)
        {
            _recipeRepository.Update(RecipeMapper.ConvertRecipeModelToRecipe(item));
        }

        public RecipeModel GetItem(Guid id)
        {
            var temp = _recipeRepository.GetItem(id);
            var tempIngr = _ingredientRepository.GetList();
            var tempComp = _compositionRepository.GetList().Where(y => y.RecipeId == temp.Id).Select(CompositionMapper.ConvertCompositonToCompositionModel).ToList();
            tempComp.ForEach(y => y.IngredientName = tempIngr.Where(z => z.Id == y.IngredientId).FirstOrDefault()?.Name);

            return new RecipeModel
            {
                Id = temp.Id,
                Category = (Enums.CategoryTypes)temp.Category,
                Name = temp.Name,
                Composition = tempComp,
                Review = _reviewRepository.GetList().Where(y => y.Id == temp.Id).Select(ReviewMapper.ConvertReviewToReviewModel).ToList(),
                User = UserMapper.ConvertUserToUserModel(_userRepository.GetList().FirstOrDefault())
            };
        }
    }
}
