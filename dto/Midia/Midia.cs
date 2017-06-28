using DTO.Infraestrutura_de_Midia;
using System;

namespace DTO.Midia
{
    public class Midia
    {
        private int codMidia;
        private int tombo;
        private Area area = new Area();
        private bool disponivel;
        private string localizacao;
        private string lingua;
        private string tipoTombo;
        private string tipoMidia;
        private DateTime dataCadastro;
        private string observacao;
        private int quantidade;

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

        public Area Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public bool Disponivel
        {
            get
            {
                return disponivel;
            }

            set
            {
                disponivel = value;
            }
        }

        public string Localizacao
        {
            get
            {
                return localizacao;
            }

            set
            {
                localizacao = value;
            }
        }

        public string Lingua
        {
            get
            {
                return lingua;
            }

            set
            {
                lingua = value;
            }
        }

        public string TipoTombo
        {
            get
            {
                return tipoTombo;
            }

            set
            {
                tipoTombo = value;
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

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }
    }
}
