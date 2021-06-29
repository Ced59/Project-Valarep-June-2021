using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class UserCreationDto
    {
        public string Login { get; set; }

        public string Pseudo { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }
    }
}
