using System;
using DTO.Infraestrutura_de_Pessoa;

namespace DTO.Midia
{
    public class Tcc : Midia
    {
        private Curso curso = new Curso();
        private string titulo;
        private DateTime dataPublicacao;

        public Curso Curso
        {
            get
            {
                return curso;
            }

            set
            {
                curso = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public DateTime DataPublicacao
        {
            get
            {
                return dataPublicacao;
            }

            set
            {
                dataPublicacao = value;
            }
        }
    }
}
