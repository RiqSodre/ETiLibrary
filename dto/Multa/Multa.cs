using DTO.Pessoas;
using System;

namespace DTO.Multa
{
    public class Multa
    {
        private int codMulta;
        private int codEmprestimo;
        private Pessoa pessoa = new Pessoa();
        private Funcionario funcionario = new Funcionario();
        private DateTime dataCadastro;
        private bool pago;
        private string pagTipo;
        private float? valor = null;
        private bool cancelada;
        private string observacao;

        public int CodMulta
        {
            get
            {
                return codMulta;
            }

            set
            {
                codMulta = value;
            }
        }

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

        public Funcionario Funcionario
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

        public bool Pago
        {
            get
            {
                return pago;
            }

            set
            {
                pago = value;
            }
        }

        public string PagTipo
        {
            get
            {
                return pagTipo;
            }

            set
            {
                pagTipo = value;
            }
        }

        public float? Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public bool Cancelada
        {
            get
            {
                return cancelada;
            }

            set
            {
                cancelada = value;
            }
        }

        public string Observacao
        {
            get
            {
                return observacao;
            }

            set
            {
                observacao = value;
            }
        }

        public Pessoa Pessoa
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
    }
}
