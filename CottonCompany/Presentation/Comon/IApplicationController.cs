

namespace CottonCompany.Presentation.Comon
{
    internal interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>() where TImplementation : class, TView where TView : IView;
        IApplicationController RegisterService<TService, TImplementation>() where TImplementation : class, TService;
        void Run<TPresenter>() where TPresenter : class, IPresenter;
    }
}