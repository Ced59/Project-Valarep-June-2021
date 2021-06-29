using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Marque
    {
        [Column("Id_MA")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le nom de la marque est requis")]
        public string Libelle { get; set; }

        public ICollection<StationService> StationServices { get; set; }
    }
}
