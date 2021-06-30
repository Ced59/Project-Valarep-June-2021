using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Marque
    {
        public Marque()
        {
            StationServices = new HashSet<StationService>();
        }

        public Guid IdMa { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<StationService> StationServices { get; set; }
    }
}
