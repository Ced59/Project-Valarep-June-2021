using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class User
    {
        public User()
        {
            Releves = new HashSet<Releve>();
            UserFavouritesStationsServices = new HashSet<UserFavouritesStationsService>();
        }

        public Guid IdUs { get; set; }
        public string Login { get; set; }
        public string Pseudo { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Releve> Releves { get; set; }
        public virtual ICollection<UserFavouritesStationsService> UserFavouritesStationsServices { get; set; }
    }
}
