using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesContrats.RepositoryInterfaces
{
    public interface IReleveRepo
    {
        void CreerReleve(Releve releve, Guid StationId, Guid CarburantId);

        Releve GetReleve(bool tracked, Guid StationId, Guid CarburantId);
    }
}
