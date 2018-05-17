using CookBook.BLL.Models;
using CookBook.Domain.Enums;
using CookBook.Domain.Models;

namespace CookBook.BLL.Mappers
{
    internal class UserMapper
    {
        internal static User ConvertUserModelToUser(UserModel userModel)
        {
            return new User
            {
                Login = userModel.Login,
                Type = (AccountTypes)userModel.Type,
                Password = userModel.Password
            };
        }

        internal static UserModel ConvertUserToUserModel(User user)
        {
            return new UserModel
            {
                Id = user.Id,
                Login = user.Login,
                Type = (Enums.AccountTypes)user.Type,
                Password = user.Password
            };
        }
    }
}
