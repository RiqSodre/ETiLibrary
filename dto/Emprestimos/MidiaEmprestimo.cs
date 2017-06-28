using DTO.Infraestrutura_de_Midia;
using System;

namespace DTO.Emprestimos
{
    public class MidiaEmprestimo 
    {
        private int codMidiaEmprestimo;
        private string descricao;
        private string tipoMidia;
        private int codMidia;
        private int tombo;
        private DateTime dataDevolucao;
        private bool devolvido;

        public int CodMidiaEmprestimo
        {
            get
            {
                return codMidiaEmprestimo;
            }

            set
            {
                codMidiaEmprestimo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string TipoMidia
        {
            get
            {
                return tipoMidia;
            }

            set
            {
                tipoMidia = value;
            }
        }

        public int CodMidia
        {
            get
            {
                return codMidia;
            }

            set
            {
                codMidia = value;
            }
        }

        public int Tombo
        {
            get
            {
                return tombo;
            }

            set
            {
                tombo = value;
            }
        }

        public DateTime DataDevolucao
        {
            get
            {
                return dataDevolucao;
            }

            set
            {
                dataDevolucao = value;
            }
        }

        public bool Devolvido
        {
            get
            {
                return devolvido;
            }

            set
            {
                devolvido = value;
            }
        }
    }
}
