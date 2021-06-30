using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Releve
    {
        public Guid IdRe { get; set; }
        public DateTime Date { get; set; }
        public decimal Prix { get; set; }
        public Guid CarburantId { get; set; }
        public Guid StationServiceId { get; set; }
        public Guid UserId { get; set; }

        public virtual Carburant Carburant { get; set; }
        public virtual StationService StationService { get; set; }
        public virtual User User { get; set; }
    }
}
