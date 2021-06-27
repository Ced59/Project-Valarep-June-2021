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

        public GestionRepos(RepoContext context)
        {
            _context = context;
        }

        public void Save() => _context.SaveChanges();
    }
}