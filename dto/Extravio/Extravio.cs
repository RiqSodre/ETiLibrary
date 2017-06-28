using DTO.Emprestimos;
using DTO.Pessoas;
using System;

namespace DTO.Extravio
{
    public class Extravio
    {
        private int codExtravio;
        private Pessoa pessoa;
        private MidiaEmprestimo midiaEmprestimo = new MidiaEmprestimo();
        private DateTime dataCadastro;
        private bool pago;
        private string pagTipo;
        private float? valor = null;
        private string observacao;

        public int CodExtravio
        {
            get
            {
                return codExtravio;
            }

            set
            {
                codExtravio = value;
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

        public MidiaEmprestimo MidiaEmprestimo
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
    }
}
