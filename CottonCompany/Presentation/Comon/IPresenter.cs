using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottonCompany.Presentation.Comon
{
    interface IPresenter
    {
        void Run();
    }
    interface IPresenter<in TArg>
    {
        void Run(TArg argument);
    }
}
