using System;

namespace DTO.Infraestrutura_de_Midia
{
    public class Editora
    {
        private int codEditora;
        private string nome;

        public int CodEditora
        {
            get
            {
                return codEditora;
            }

            set
            {
                codEditora = value;
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

        public static implicit operator Editora(Area v)
        {
            throw new NotImplementedException();
        }
    }
}
