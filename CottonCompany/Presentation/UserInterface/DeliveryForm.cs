using CottonCompany.Domain;
using CottonCompany.Model;
using CottonCompany.Presentation.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CottonCompany.Presentation.UserInterface
{
    
    public partial class DeliveryForm : Form, IDeliveryView
    {
        private int rowMaxNumberElements = 4;
        Dictionary<string, Control> controlType;

        public DeliveryForm()
        {
            InitializeComponent();

            controlType = new Dictionary<string, Control>(5)
            {
                //[""] =new Control(),
                { "Label", new Label() },
                { " TextBox",  new TextBox() },
                { "ComboBox", new ComboBox() },
                { "DateTimePicker", new DateTimePicker() },
                { "Button", new Button()}
            };
        }

        public string FormName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DataGrideLoading(NDelivery nDelivery)
        {
            CottonContext db = new CottonContext();
            System.Reflection.MemberInfo[] memberlist = typeof(CottonContext).GetMembers();

            var mySet = db.Set(Type.GetType("<Your Entity Name>"));

            PropertyDescriptor descr = TypeDescriptor.GetProperties(db)["NDelivery"];
            descr.SetValue(db, 777);
           

        }

        private Control[] filtertype = new Control[] {
            new Label(),
            new TextBox(),
            new ComboBox(),
            new DateTimePicker(),
            new Button()
        };

        public void FilterPanelLoading(NFilter[] nFilter, IFormationControl formationControl, CottonContext context)
        {


            int columPosition = 0;
            int rowPosition = 0;

            for (int i = 0; i < tlpFilter.Controls.Count; i++)
            {
                var control = filtertype[formationControl.Type];
                control.Name = formationControl.Name;
                control.Text = formationControl.Text;
                control.Click += formationControl.Click;
                tlpFilter.Controls.Add(control, columPosition, rowPosition);

                columPosition++;
                rowPosition = i > rowMaxNumberElements ? (rowPosition = 0) : (rowPosition = 1);

            }


            foreach (var filter in nFilter)
            {
                var control = controlType[filter.Filtertype];
                control.Name = filter.Filtername;
                using (CottonContext cc = new CottonContext())
                {
                    control.Text = cc
                }
                    

                    control.Click += filter.Click;
                tlpFilter.Controls.Add(control, columPosition, rowPosition);

                columPosition++;
                rowPosition = i > rowMaxNumberElements ? (rowPosition = 0) : (rowPosition = 1);
            }
        }
}
}
