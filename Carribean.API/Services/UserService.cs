using Carribean.API.Models;
using Carribean.API.Models.Entities;

namespace Carribean.API.Services
{
    public interface IUserService : IBaseService<User>
    {
        User? FindUser(string userName);
    }
    public class UserService : BaseServices<User>, IUserService
    {
        public UserService(Context context) : base(context)
        {
        }

        public User? FindUser(string? userName)
        {
            var userForLogin = Query()
                              .Where(x => x.UserName == userName)
                              .FirstOrDefault();

            if (userForLogin == null) return null;

            return userForLogin;
        }
    }
}
