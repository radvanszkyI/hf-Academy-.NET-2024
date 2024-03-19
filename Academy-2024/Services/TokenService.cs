using Academy_2024.Dtos;
using Academy_2024.Models;
using Academy_2024.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Academy_2024.Services
{
    public class TokenService : ITokenService
    {
        private readonly JwtOptions _jwtOptions;
        
        public TokenService(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
        }
        public TokenDto CreateToken(User user)
        {
            var claims= new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email!),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var sercurtyKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Key));
            var credentials = new SigningCredentials;
            var tokenDescriptor=new JwtSecurityToken(
                _jwtOptions.Issuer,

                )

        }
    }
}
