using Entities.Repo;
using InterfacesContrats.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class GestionRepos : IGestionRepos
    {
        private RepoContext _context;
        private ICarburantRepo _carburantRepo;
        private IMarqueStationRepo _marqueStationRepo;
        private IReleveRepo _releveRepo;
        private IStationServiceRepo _stationServiceRepo;
        private IUserRepo _userRepo;

        public GestionRepos(RepoContext context)
        {
            _context = context;
        }

        public ICarburantRepo Carburant
        {
            get
            {
                if(_carburantRepo == null)
                {
                    _carburantRepo = new CarburantRepo(_context);
                }
                return _carburantRepo;
            }
        }

        public IMarqueStationRepo MarqueStation
        {
            get
            {
                if (_marqueStationRepo == null)
                {
                    _marqueStationRepo = new MarqueStationRepo(_context);
                }
                return _marqueStationRepo;
            }
        }

        public IReleveRepo Releve
        {
            get
            {
                if (_releveRepo == null)
                {
                    _releveRepo = new ReleveRepo(_context);
                }
                return _releveRepo;
            }
        }

        public IStationServiceRepo StationService
        {
            get
            {
                if (_stationServiceRepo == null)
                {
                    _stationServiceRepo = new StationServiceRepo(_context);
                }
                return _stationServiceRepo;
            }
        }

        public IUserRepo UserRepo
        {
            get
            {
                if (_userRepo == null)
                {
                    _userRepo = new UserRepo(_context);
                }
                return _userRepo;
            }
        }

        public void Save() => _context.SaveChanges();
    }
}