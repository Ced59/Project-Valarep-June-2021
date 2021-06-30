using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class UserFavouritesStationsService
    {
        public Guid UserId { get; set; }
        public Guid FavouriteStationsServiceId { get; set; }

        public virtual StationService FavouriteStationsService { get; set; }
        public virtual User User { get; set; }
    }
}
