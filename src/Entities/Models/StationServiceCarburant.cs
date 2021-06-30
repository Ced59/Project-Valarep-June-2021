using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class StationServiceCarburant
    {
        public Guid StationServiceId { get; set; }
        public Guid CarburantId { get; set; }

        public virtual Carburant Carburant { get; set; }
        public virtual StationService StationService { get; set; }
    }
}
