using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimForms.Classes
{
    public class Login
    {
        private string _usuario = "admin";
        private string _senha = "1234";

        public string Usuario
        {
            get { return _usuario; }
        }

        public string Senha
        {
            get { return _senha; }
        }
    }
}
