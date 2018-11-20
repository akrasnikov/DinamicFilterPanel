using CottonCompany.Domain;
using CottonCompany.Presentation;
using CottonCompany.Presentation.Comon;
using CottonCompany.Presentation.UserInterface;
using CottonCompany.Presentation.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CottonCompany
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder());
              

            //controller.Run<LoginPresenter>();
        }
    }
}
