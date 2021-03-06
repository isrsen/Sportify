using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;
using Terminator.Contracts.Api.Settings;
using Terminator.Contracts.Services;

namespace Terminator.Services.Tokens
{
    public class TokenValidationService : ITokenValidationService
    {
        private readonly IAppSettings _appSettings;

        public TokenValidationService(IAppSettingsProvider appSettingsProvider)
        {
            this._appSettings = appSettingsProvider.AppSettings ?? throw new ArgumentNullException(nameof(appSettingsProvider));
        }

        //public TokenValidationResult ValidateToken(string token)
        //{
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var validationParameters = TokenOptionsProvider.GetValidationParameters(this._appSettings.JwtSecret);

        //    var result = tokenHandler.ValidateToken(token, validationParameters, out _);

        //    var email = result.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
        //    var roles = result.Claims.Where(c => c.Type == ClaimTypes.Role).Select(r => r.Value);

        //    return new TokenValidationResult
        //    {
        //        IsValid = true,
        //        UserEmail = email,
        //        Roles = roles
        //    };
        //}
    }
}
