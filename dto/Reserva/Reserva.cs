using DTO.Midia;
using DTO.Pessoas;
using System;

namespace DTO.Reserva
{
    public class Reserva
    {
        private int codMidiaReserva;
        private Livro livro = new Livro();
        private Pessoa pessoa = new Pessoa();
        private DateTime dataRetirada;
        private string tipoMidia;

        public int CodMidiaReserva
        {
            get
            {
                return codMidiaReserva;
            }

            set
            {
                codMidiaReserva = value;
            }
        }

        public Livro Livro
        {
            get
            {
                return livro;
            }

            set
            {
                livro = value;
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

        public DateTime DataRetirada
        {
            get
            {
                return dataRetirada;
            }

            set
            {
                dataRetirada = value;
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
    }
}
