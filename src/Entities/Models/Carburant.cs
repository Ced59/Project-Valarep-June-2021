using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public class Carburant
    {
        public Carburant()
        {
            Releves = new HashSet<Releve>();
            StationServiceCarburants = new HashSet<StationServiceCarburant>();
        }

        public Guid IdCa { get; set; }
        public string Libelle { get; set; }
        public string CodeEu { get; set; }

        public virtual ICollection<Releve> Releves { get; set; }
        public virtual ICollection<StationServiceCarburant> StationServiceCarburants { get; set; }
    }
}
