using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesContrats.RepositoryInterfaces
{
    public interface IMarqueRepo
    {
        Marque GetMarque(bool tracked, Guid id);
    }
}
