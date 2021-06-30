using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class StationService
    {
        public StationService()
        {
            Releves = new HashSet<Releve>();
            StationServiceCarburants = new HashSet<StationServiceCarburant>();
            UserFavouritesStationsServices = new HashSet<UserFavouritesStationsService>();
        }

        public Guid IdSt { get; set; }
        public string Adresse { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Guid MarqueId { get; set; }

        public virtual Marque Marque { get; set; }
        public virtual ICollection<Releve> Releves { get; set; }
        public virtual ICollection<StationServiceCarburant> StationServiceCarburants { get; set; }
        public virtual ICollection<UserFavouritesStationsService> UserFavouritesStationsServices { get; set; }
    }
}
