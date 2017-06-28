namespace DTO.Infraestrutura_de_Midia
{
    public class Assunto
    {
        private int codAssunto;
        private string descricao;

        public int CodAssunto
        {
            get
            {
                return codAssunto;
            }

            set
            {
                codAssunto = value;
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
    }
}
