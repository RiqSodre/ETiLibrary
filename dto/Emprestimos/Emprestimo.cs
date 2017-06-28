using DTO.Infraestrutura_de_Midia;
using DTO.Pessoas;
using System;

namespace DTO.Emprestimos
{
    public class Emprestimo
    {
        private int codEmprestimo;
        private Pessoa usuario = new Pessoa();
        private Pessoa funcionario = new Pessoa();
        private DateTime data;
        private bool multa;
        private bool fechado;
        private MidiaEmprestimoList midiaEmprestimoList = new MidiaEmprestimoList();

        public int CodEmprestimo
        {
            get
            {
                return codEmprestimo;
            }

            set
            {
                codEmprestimo = value;
            }
        }

        public Pessoa Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public Pessoa Funcionario
        {
            get
            {
                return funcionario;
            }

            set
            {
                funcionario = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public bool Multa
        {
            get
            {
                return multa;
            }

            set
            {
                multa = value;
            }
        }

        public bool Fechado
        {
            get
            {
                return fechado;
            }

            set
            {
                fechado = value;
            }
        }

        public MidiaEmprestimoList MidiaEmprestimoList
        {
            get
            {
                return midiaEmprestimoList;
            }

            set
            {
                midiaEmprestimoList = value;
            }
        }
    }
}
