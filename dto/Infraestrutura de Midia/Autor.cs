namespace DTO.Infraestrutura_de_Midia
{
    public class Autor
    {
        private int codAutor;
        private string nome;
        private string sobrenome;
        private string notacaoAutor;

        public int CodAutor
        {
            get
            {
                return codAutor;
            }

            set
            {
                codAutor = value;
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

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }

        public string NotacaoAutor
        {
            get
            {
                return notacaoAutor;
            }

            set
            {
                notacaoAutor = value;
            }
        }
    }
}
