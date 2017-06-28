using DTO.Infraestrutura_de_Midia;
using System;

namespace DTO.Midia
{
    public class Livro:Midia
    {
        private Editora editora = new Editora();
        private string titulo;
        private string subtitulo;
        private string serie_Colecao;
        private string edicao;
        private string volume;
        private string npags;
        private string local;
        private DateTime? dataPublicacao = null;
        private float? valor = null;
        private string tipoLivro;
        private string genero;
        private GeneroList generoList = new GeneroList();
        private string autores;
        private AutorList autoreList = new AutorList();
        private string assuntos;
        private AssuntoList assuntoList = new AssuntoList();

        public Editora Editora
        {
            get
            {
                return editora;
            }

            set
            {
                editora = value;
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

        public string Subtitulo
        {
            get
            {
                return subtitulo;
            }

            set
            {
                subtitulo = value;
            }
        }

        public string Serie_Colecao
        {
            get
            {
                return serie_Colecao;
            }

            set
            {
                serie_Colecao = value;
            }
        }

        public string Edicao
        {
            get
            {
                return edicao;
            }

            set
            {
                edicao = value;
            }
        }

        public string Volume
        {
            get
            {
                return volume;
            }

            set
            {
                volume = value;
            }
        }

        public string Npags
        {
            get
            {
                return npags;
            }

            set
            {
                npags = value;
            }
        }

        public string Local
        {
            get
            {
                return local;
            }

            set
            {
                local = value;
            }
        }

        public DateTime? DataPublicacao
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

        public string TipoLivro
        {
            get
            {
                return tipoLivro;
            }

            set
            {
                tipoLivro = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public GeneroList GeneroList
        {
            get
            {
                return generoList;
            }

            set
            {
                generoList = value;
            }
        }

        public string Autores
        {
            get
            {
                return autores;
            }

            set
            {
                autores = value;
            }
        }

        public string Assuntos
        {
            get
            {
                return assuntos;
            }

            set
            {
                assuntos = value;
            }
        }

        public AssuntoList AssuntoList
        {
            get
            {
                return assuntoList;
            }

            set
            {
                assuntoList = value;
            }
        }

        public AutorList AutoreList
        {
            get
            {
                return autoreList;
            }

            set
            {
                autoreList = value;
            }
        }
    }
}
