using CottonCompany.Presentation.View;

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
    public partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += (sender, args) => Invoke(Login);
        }

        public string Username { get { return txtUsername.Text; } }
        public string Password { get { return txtPassword.Text; } }

        public event Action Login;

        public void ShowError(string errorMessage)
        {
            lblError.Text = errorMessage;
        }

        public new void Show()
        {
            Application.Run(this);
        }
    }
}
