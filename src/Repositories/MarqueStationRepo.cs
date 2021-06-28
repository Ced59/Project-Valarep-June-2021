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
    class MarqueStationRepo : RepositoryBase<MarqueStation>, IMarqueStationRepo
    {
        public MarqueStationRepo(RepoContext context) : base(context)
        {

        }
    }
}
