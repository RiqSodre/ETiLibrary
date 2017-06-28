using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Pessoa
    {
        private int codPessoa;

        public int CodPessoa
        {
            get { return codPessoa; }
            set { codPessoa = value; }
        }

        private string Nome;

        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string cpf;

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
    }
}
