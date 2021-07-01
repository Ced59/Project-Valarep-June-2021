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
    public class StationServiceRepo : RepositoryBase<StationService>, IStationServiceRepo
    {
        public StationServiceRepo(RepoContext context) : base(context)
        {

        }

        public StationService GetStationService(bool tracked, Guid id)
        {
            return FindStationServiceById(id); ;
        }

        public IEnumerable<StationService> GetStationServices(bool tracked)
        {
            return FindAllStationsServices();
        }

        public IEnumerable<StationService> GetStationServicesByCarburant(Guid id)
        {
            return FindStationsServiceByCarburant(id);
        }
    }
}
