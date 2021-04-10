using Microsoft.IdentityModel.Tokens;
using StockSystem.Domain.Response;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StockSystem.Infra.Common
{
    public static class JsonWebToken
    {
        private const int ExpiresIn = 30;
        public static TokenResponse GerarToken(Claim[] claims = null, int expiresIn = ExpiresIn)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Key.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                IssuedAt = DateTime.Now,
                NotBefore = DateTime.Now,
                Expires = DateTime.Now.AddMinutes(expiresIn),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new TokenResponse(token: tokenHandler.WriteToken(token), expiresIn: TimeSpan.FromMinutes(expiresIn).TotalSeconds);
        }
    }
}
