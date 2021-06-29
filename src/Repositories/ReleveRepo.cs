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
    public class ReleveRepo : RepositoryBase<Releve>, IReleveRepo
    {
        public ReleveRepo(RepoContext context) : base(context)
        {

        }

        public void CreerReleve(Releve releve, Guid StationId, Guid CarburantId)
        {
            //releve.StationId = StationId;
            //releve.CarburantId = CarburantId;
            Create(releve);
        }

        public Releve GetReleve(bool tracked, Guid StationId, Guid CarburantId)
        {
            return null;
            //return FindByCondition(e => e.StationId == StationId && e.CarburantId == CarburantId).OrderBy(e => e.Date);
        }
    }
}
