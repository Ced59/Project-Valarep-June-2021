using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class UserFavouritesStationsServices
    {
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public User User { get; set; }

        [ForeignKey(nameof(StationService))]
        public Guid FavouriteStationsServiceId { get; set; }

        public StationService FavouriteStationsService { get; set; }
    }
}
