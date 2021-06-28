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
    class CarburantRepo : RepositoryBase<Carburant>, ICarburantRepo
    {
        public CarburantRepo(RepoContext context) : base(context)
        {

        }
    }
}
