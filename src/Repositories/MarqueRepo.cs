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
    public class MarqueRepo : RepositoryBase<Marque>, IMarqueRepo
    {
        public MarqueRepo(RepoContext context) : base(context)
        {

        }

        public Marque GetMarque(bool tracked, Guid id)
        {
            return FindByCondition(e => e.Id == id, tracked).Single();
        }
    }
}
