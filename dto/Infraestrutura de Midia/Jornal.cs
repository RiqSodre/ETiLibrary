namespace DTO.Infraestrutura_de_Midia
{
    public class Jornal
    {
        private int codJornal;
        private string nome;

        public int CodJornal
        {
            get
            {
                return codJornal;
            }

            set
            {
                codJornal = value;
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
    }
}
