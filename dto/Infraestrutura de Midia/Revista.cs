namespace DTO.Infraestrutura_de_Midia
{
    public class Revista
    {
        private int codRevista;
        private string nome;
        private Editora editora = new Editora();

        public int CodRevista
        {
            get
            {
                return codRevista;
            }

            set
            {
                codRevista = value;
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
    }
}
