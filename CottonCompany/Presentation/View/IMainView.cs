using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottonCompany.Presentation.View
{
    interface IMainView
    {
        void SetUserInfo(string username, string password);
        event Action ChangeUsername;
    }
}
