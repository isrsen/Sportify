using System;
using Microsoft.IdentityModel.Tokens;

namespace Terminator.Contracts.Services.Tokens
{
    public static class TokenOptionsProvider
    {
        public static TokenValidationParameters GetValidationParameters(string secret)
        {
            var symmetricKey = Convert.FromBase64String(secret);

            return new TokenValidationParameters
            {
                ValidateLifetime = true,
                RequireExpirationTime = true,
                ValidateAudience = false,
                ValidateIssuer = false,
                ClockSkew = TimeSpan.Zero,
                IssuerSigningKey = new SymmetricSecurityKey(symmetricKey)
            };
        }

        public static SigningCredentials GetSigningCredentials(string secret)
        {
            var symmetricKey = Convert.FromBase64String(secret);
            var symmetricSecurityKey = new SymmetricSecurityKey(symmetricKey);

            return new SigningCredentials(
                symmetricSecurityKey,
                SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
