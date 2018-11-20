using CottonCompany.Presentation.Comon;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CottonCompany.Presentation.UserInterface
{
    class LightInjectAdapder : IContainer
    {
        private readonly ServiceContainer container = new ServiceContainer();
        public bool IsRegistered<TService>()
        {
            return container.CanGetInstance(typeof(TService), string.Empty);
        }

        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            container.Register<TService, TImplementation>();
        }

        public void Register<TService>()
        {
            container.Register<TService>();
        }

        public void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory)
        {
            container.Register(serviceFactory => factory);
        }

        public void RegisterInstance<T>(T instance)
        {
            container.RegisterInstance(instance);
        }

        public TService Resolve<TService>()
        {
            return container.GetInstance<TService>();
        }
    }
}
