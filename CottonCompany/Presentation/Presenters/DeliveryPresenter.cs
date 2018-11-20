using CottonCompany.Domain;
using CottonCompany.Presentation.Comon;
using CottonCompany.Presentation.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottonCompany.Presentation.Presenters
{
    class DeliveryPresenter : IPresenter
    {
        private readonly IDeliveryView view;
        private readonly IDeliveryService service;

        public DeliveryPresenter(IDeliveryView view, IDeliveryService service)
        {
            this.view = view;
            this.service = service;

        }

        public void Run()
        {
            view.Show();
        }

       
    }
}
