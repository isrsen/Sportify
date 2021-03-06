using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Terminator.Contracts.Api.Settings;
using Terminator.Contracts.Services;
using Terminator.Contracts.Services.Tokens;

namespace Terminator.Services.Tokens
{
    public class TokenService : ITokenService
    {
        private readonly IAppSettings _appSettings;

        public TokenService(IAppSettingsProvider appSettingsProvider)
        {
            this._appSettings = appSettingsProvider.AppSettings ?? throw new ArgumentNullException(nameof(appSettingsProvider));
        }

        public string Generate(IEnumerable<Claim> claims)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(10),
                SigningCredentials = TokenOptionsProvider.GetSigningCredentials(this._appSettings.JwtSecret)
            };

            var securityToken = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(securityToken);
        }
    }
}
