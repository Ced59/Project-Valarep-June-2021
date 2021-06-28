using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Releve
    {
        [Column("Id_RE")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "La date du relevé est requise")]
        public DateTime date { get; set; }

        [Required(ErrorMessage = "Le prix de la pompe est requise")]
        public decimal prix { get; set; }
    }
}
