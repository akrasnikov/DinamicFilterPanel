using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CottonCompany.Presentation.Comon
{
    class ApplicationController : IApplicationController
    {
        private readonly IContainer container;
        public ApplicationController(IContainer container)
        {
            this.container = container;
            this.container.RegisterInstance<IApplicationController>(this);
        }

        public IApplicationController RegisterService<TService, TImplementation>() where TImplementation : class, TService
        {
            container.Register<TService, TImplementation>();
            return this;
        }

        public IApplicationController RegisterView<TView, TImplementation>()
            where TView : IView
            where TImplementation : class, TView
        {
            container.Register<TView, TImplementation>();
            return this;
        }

        void IApplicationController.Run<TPresenter>()
        {
            if (!container.IsRegistered<TPresenter>())
                container.Register<TPresenter>();

            var presenter = container.Resolve<TPresenter>();
            presenter.Run();
        }
    }
}
