using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Infraestrutura_de_Pessoa;

namespace DTO.Pessoa
{
    public class Pessoa
    {
        private int codPessoa;
        private string nome;
        private string sexo;
        private string cpf;
        private DateTime dataCadastro;
        private Telefone telefone = new Telefone();
        private Telefone celular = new Telefone();

        public int CodPessoa
        {
            get
            {
                return codPessoa;
            }

            set
            {
                codPessoa = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public DateTime DataCadastro
        {
            get
            {
                return dataCadastro;
            }

            set
            {
                dataCadastro = value;
            }
        }

        public Telefone Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public Telefone Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }
    }
}
