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
    class ReleveRepo : RepositoryBase<Releve>, IReleveRepo
    {
        public ReleveRepo(RepoContext context) : base(context)
        {

        }
    }
}
