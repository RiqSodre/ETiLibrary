namespace DTO.Infraestrutura_de_Midia
{
    public class Genero
    {
        private int codGenero;
        private string descricao;
        private bool principal;

        public int CodGenero
        {
            get
            {
                return codGenero;
            }

            set
            {
                codGenero = value;
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

        public bool Principal
        {
            get
            {
                return principal;
            }

            set
            {
                principal = value;
            }
        }
    }
}
