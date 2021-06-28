using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesContrats.RepositoryInterfaces
{
    public interface IGestionRepos
    {
        ICarburantRepo Carburant { get; }
        IMarqueStationRepo MarqueStation { get; }
        IReleveRepo Releve { get; }
        IStationServiceRepo StationService { get; }
        IUserRepo UserRepo { get; }
        void Save();
    }
}