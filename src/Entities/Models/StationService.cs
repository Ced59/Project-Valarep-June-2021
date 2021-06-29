using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StationService
    {
        [Column("Id_ST")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "L'adresse est requise pour la station service")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "La latitude est requise")]
        public string Latitude { get; set; }

        [Required(ErrorMessage = "La longitude est requise")]
        public string Longitude { get; set; }

        [ForeignKey(nameof(Marque))]
        public Guid MarqueId { get; set; }

        public Marque Marque { get; set; }
    }
}
