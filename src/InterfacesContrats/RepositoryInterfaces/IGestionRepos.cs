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
        IMarqueRepo MarqueStation { get; }
        IReleveRepo Releve { get; }
        IStationServiceRepo StationService { get; }
        IUserRepo User { get; }
        void Save();
    }
}