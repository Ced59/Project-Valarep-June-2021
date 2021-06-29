using Entities.Models;
using Entities.Models.AuthModels;
using InterfacesContrats.RepositoryInterfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;


namespace InterfacesContrats.UserInterfaces
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, IUserRepo userRepo);
        User GetById(Guid id);
    }
}
