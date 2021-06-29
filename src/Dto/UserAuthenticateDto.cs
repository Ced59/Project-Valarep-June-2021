using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class UserAuthenticateDto
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Pseudo { get; set; }
        public string Token { get; set; }
    }
}
