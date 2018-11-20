using CottonCompany.Model;
using CottonCompany.Presentation.Comon;

namespace CottonCompany.Presentation.View
{
    internal interface IDeliveryView : IView
    {
        string FormName { get; set; }
       

        void FilterPanelLoading(NFilter nFilter);
        void DataGrideLoading(NDelivery nDelivery);
    }
}