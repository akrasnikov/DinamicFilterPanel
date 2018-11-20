using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CottonCompany.Model;

namespace CottonCompany.Domain
{
    class LoginService : ILoginService
    {
        public bool Login(User user)
        {
            return !string.IsNullOrEmpty(user.Name);
        }
    }
}
