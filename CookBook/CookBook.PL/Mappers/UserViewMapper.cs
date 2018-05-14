using CookBook.PL.Models;
using CookBook.BLL.Models;

namespace CookBook.PL.Mappers
{
    internal class UserViewMapper
    {
        internal static UserModel ConvertUserViewModelToUserModel(UserViewModel userModel)
        {
            return new UserModel
            {
                Id = userModel.Id,
                Login = userModel.Login,
                Type = userModel.Type,
                Password = userModel.Password
            };
        }

        internal static UserViewModel ConvertUserModelToUserViewModel(UserModel user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Login = user.Login,
                Type = user.Type,
                Password = user.Password
            };
        }
    }
}
