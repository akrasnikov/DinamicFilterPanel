using CottonCompany.Domain;
using CottonCompany.Model;
using CottonCompany.Presentation.Comon;
using CottonCompany.Presentation.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottonCompany.Presentation.Presenters
{
    class LoginPresenter : IPresenter
    {
        private readonly ILoginView view;
        private readonly ILoginService service;

        public LoginPresenter(ILoginView view, ILoginService service)
        {
            this.view = view;
            this.service = service;

            this.view.Login += () => Login(this.view.Username, this.view.Password);
        }

        public void Run()
        {
            view.Show();
        }

        private void Login(string username, string password)
        {
            if (username == null)
                throw new ArgumentNullException("username");
            if (password == null)
                throw new ArgumentNullException("password");

            var user = new User { Name = username, Password = password };
            if (!service.Login(user))
            {
                view.ShowError("Invalid username or password");
            }
            else
            {
                // успешная авторизация, запуск главного экрана (?)
            }
        }
        
    }
}
