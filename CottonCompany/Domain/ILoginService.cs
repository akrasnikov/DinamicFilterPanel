using CottonCompany.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottonCompany.Domain
{
    interface ILoginService
    {
        bool Login(User user); 
    }
}
