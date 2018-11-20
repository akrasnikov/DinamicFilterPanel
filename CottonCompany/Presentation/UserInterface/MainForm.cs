using CottonCompany.Presentation.View;
using System;
using System.Windows.Forms;

namespace CottonCompany.Presentation.UserInterface
{
    public partial class MainForm : Form, IMainView
    {
        private readonly ApplicationContext _context;
        public MainForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            btnChangeUsername.Click += (sender, args) => Invoke(ChangeUsername);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public event Action ChangeUsername;

        public void SetUserInfo(string username, string password)
        {
            lblUsername.Text = username;
            lblPassword.Text = password;
        }
    }
}
