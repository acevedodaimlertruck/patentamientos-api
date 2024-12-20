using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LCH.MercedesBenz.Api.Models.Application.Users;
using LCH.MercedesBenz.Api.Models.Application.Users.Dtos;
using Microsoft.IdentityModel.Tokens;

namespace LCH.MercedesBenz.Api.Services.Jwt
{
    public static class JwtService
    {
        public static string? GetToken(User user, string secretKey, int expiresInDays)
        {
            if (user == null || string.IsNullOrEmpty(secretKey) || expiresInDays < 1) return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim("UserName", user.UserName),
                    new Claim("FullName", $"{user.Name} {user.Surname}"),
                    new Claim("roleId", user.RoleId.ToString()),
                }),
                Expires = DateTime.UtcNow.AddDays(expiresInDays),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static string? GetToken(UserSignInResponseDto user, string secretKey, int expiresInMinutes)
        {
            if (user == null || string.IsNullOrEmpty(secretKey) || expiresInMinutes < 1) return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(secretKey);
            var now = DateTime.Now;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim("name", user.Name),
                    new Claim("surname", user.Surname),
                    new Claim("display_name", $"{user.Name} {user.Surname}"),
                    new Claim("roleId", user.RoleId.ToString()),
                }),
                Expires = now.AddMinutes(expiresInMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            tokenDescriptor.NotBefore = now;
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
