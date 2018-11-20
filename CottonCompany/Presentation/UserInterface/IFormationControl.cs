using System;

namespace CottonCompany.Presentation.UserInterface
{
    public interface IFormationControl
    {
        string Label { get; }
        int Type { get; }
        string Name { get; }
        string Text { get; }

        void Click(object sender, EventArgs e);
    }
}