using Entities.Models;
using Entities.Repo;
using InterfacesContrats.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepo : RepositoryBase<User>, IUserRepo
    {
        public UserRepo(RepoContext context): base(context)
        {

        }

        public void CreerUser(User user)
        {
            Create(user);
        }

        public User GetUser(bool tracked, string login, string password)
        {
            return FindByCondition(e => e.Login == login && e.Password == password, tracked).Single();
        }
    }
}
