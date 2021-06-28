using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Carburant
    {
        [Column("Id_CA")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le nom du carburant est requis")]
        public string Libelle { get; set; }

        [Required(ErrorMessage = "Le Code Européen du Carburant est requis")]
        public string CodeEu { get; set; }
    }
}
