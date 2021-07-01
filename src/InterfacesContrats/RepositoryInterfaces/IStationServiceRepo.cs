using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesContrats.RepositoryInterfaces
{
    public interface IStationServiceRepo
    {
        IEnumerable<StationService> GetStationServices(bool tracked);

        StationService GetStationService(bool tracked, Guid id);
        IEnumerable<StationService> GetStationServicesByCarburant(Guid id);
    }
}
