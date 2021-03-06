using Entities.Models;
using Entities.Models.AuthModels;
using InterfacesContrats.RepositoryInterfaces;
using InterfacesContrats.UserInterfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Helpers;

namespace WebAPI.Extensions
{
    public class UserService : IUserService
    {

        private readonly AppSettings _appSettings;
        private User _user;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _user = new User();
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model, IUserRepo userRepo)
        {
            _user = userRepo.GetUser(false, model.Username, model.Password);

            // return null if user not found
            if (_user == null) return null;

            // authentication successful so generate jwt token
            var token = GenerateJwtToken(_user);

            return new AuthenticateResponse(_user, token);
        }


        public User GetById(Guid id)
        {
            return _user;
        }

        // helper methods

        private string GenerateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.IdUs.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
