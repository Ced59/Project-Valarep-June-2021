using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StationServiceCarburant
    {
        [ForeignKey(nameof(StationService))]
        public Guid StationServiceId { get; set; }

        public StationService StationService { get; set; }

        [ForeignKey(nameof(Carburant))]
        public Guid CarburantId { get; set; }

        public Carburant Carburant {get; set;}
    }
}
