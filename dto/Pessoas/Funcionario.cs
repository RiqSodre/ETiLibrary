using DTO.Infraestrutura_de_Pessoa;

namespace DTO.Pessoas
{
    public class Funcionario : Pessoa
    {
        private string cargo;
        private int codCargo;
        private string login;
        private string senha;
        private bool admin;
        private bool habilitado;
        private string email;

        public string Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                cargo = value;
            }
        }
        public int CodCargo
        {
            get
            {
                return codCargo;
            }

            set
            {
                codCargo = value;
            }
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }
        public bool Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }
        public bool Habilitado
        {
            get
            {
                return habilitado;
            }
            set
            {
                habilitado = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
