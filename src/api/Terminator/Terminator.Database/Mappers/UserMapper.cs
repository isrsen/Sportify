using Terminator.Contracts.Models;
using Terminator.Database.Entities;

namespace Terminator.Database.Mappers
{
    public static class UserMapper
    {
        public static User Map(DbUser user)
        {
            return new User
            {
                Email = user.Email,
                UserName = user.UserName
            };
        }
    }
}
