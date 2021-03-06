using System.Collections.Generic;
using System.Security.Claims;

namespace Terminator.Contracts.Services.Tokens
{
    public interface ITokenService
    {
        string Generate(IEnumerable<Claim> claims);
    }
}
