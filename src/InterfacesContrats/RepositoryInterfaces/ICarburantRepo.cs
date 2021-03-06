using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesContrats.RepositoryInterfaces
{
    public interface ICarburantRepo
    {
        IEnumerable<Carburant> GetCarburants(bool tracked);

        Carburant GetCarburant(bool tracked, Guid id);
    }
}
