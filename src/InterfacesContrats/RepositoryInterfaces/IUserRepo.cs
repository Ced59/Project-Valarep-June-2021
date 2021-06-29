using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesContrats.RepositoryInterfaces
{
    public interface IUserRepo
    {
        void CreerUser(User user);

        User GetUser(bool tracked, string login, string password);
    }
}
