using System;
using Microsoft.AspNetCore.Identity;
using Terminator.Contracts.Database.Repositories;

namespace Terminator.Database.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UsersRepository(UserManager<IdentityUser> userManager)
        {
            this._userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }
    }
}
