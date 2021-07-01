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
    public class CarburantRepo : RepositoryBase<Carburant>, ICarburantRepo
    {
        public CarburantRepo(RepoContext context) : base(context)
        {

        }

        public Carburant GetCarburant(bool tracked, Guid id)
        {
            return FindByCondition(e=> e.IdCa == id, tracked).Single();
        }

        public IEnumerable<Carburant> GetCarburants(bool tracked)
        {
            return FindAll(tracked).ToList();
        }
    }
}
