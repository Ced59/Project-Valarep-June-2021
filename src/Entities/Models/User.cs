using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User
    {
        [Column("Id_US")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "L'email est requis")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Le pseudo est requis")]
        public string Pseudo { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        [JsonIgnore]
        public string Password { get; set; }

        public ICollection<Releve> Releves { get; set; }

        public ICollection<UserFavouritesStationsServices> StationServicesFavourites { get; set; }

    }
}
