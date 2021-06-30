using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class StationServiceDto
    {
        public Guid Id { get; set; }

        public string Adresse { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public MarqueDto Marque { get; set; }

        public ICollection<CarburantDto> Carburants { get; set; }
    }
}
