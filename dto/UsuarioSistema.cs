using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsuarioSistema : Funcionario
    {
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private bool admin;

        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }

        private bool habilitado;

        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
