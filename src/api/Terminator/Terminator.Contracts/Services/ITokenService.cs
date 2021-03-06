using System.Collections.Generic;
using System.Security.Claims;

namespace Terminator.Contracts.Services
{
    public interface ITokenService
    {
        string Generate(IEnumerable<Claim> claims);
    }
}
