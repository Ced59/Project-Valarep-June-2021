using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CarburantDto
    {
        public Guid Id { get; set; }

        public string Libelle { get; set; }

        public string CodeEu { get; set; }
    }
}
