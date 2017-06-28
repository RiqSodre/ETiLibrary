using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Infraestrutura_de_Midia;

namespace DTO.Emprestimo
{
    public class Emprestimo
    {
        private int codEmprestimo;
        private int codPessoa;
        private string pessoa;
        private int codFuncionario;
        private string funcionario;
        private DateTime data;
        private bool multa;
        private bool fechado;
        private _MidiasType midiaList = new _MidiasType();
        private MidiaEmprestimoList midiaEmprestimo = new MidiaEmprestimoList();

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

        public string Pessoa
        {
            get
            {
                return pessoa;
            }

            set
            {
                pessoa = value;
            }
        }

        public int CodFuncionario
        {
            get
            {
                return codFuncionario;
            }

            set
            {
                codFuncionario = value;
            }
        }

        public string Funcionario
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

        internal _MidiasType MidiaList
        {
            get
            {
                return midiaList;
            }

            set
            {
                midiaList = value;
            }
        }

        internal MidiaEmprestimoList MidiaEmprestimo
        {
            get
            {
                return midiaEmprestimo;
            }

            set
            {
                midiaEmprestimo = value;
            }
        }
    }
}
