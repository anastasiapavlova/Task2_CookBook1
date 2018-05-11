using CookBook.PL.Models;
using CookBook.BLL.Models;

namespace CookBook.Pl.Mappers
{
    internal class UserViewMapper
    {
        internal static UserModel ConvertUserViewModelToUserModel(UserViewModel userModel)
        {
            return new UserModel
            {
                Id = userModel.Id,
                Login = userModel.Login,
                Type = userModel.Type
            };
        }

        internal static UserViewModel ConvertUserModelToUserViewModel(UserModel user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Login = user.Login,
                Type = user.Type
            };
        }
    }
}
