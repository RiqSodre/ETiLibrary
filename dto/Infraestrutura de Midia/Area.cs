namespace DTO.Infraestrutura_de_Midia
{
    public class Area
    {
        private int codArea;
        private string descricao;

        public int CodArea
        {
            get
            {
                return codArea;
            }

            set
            {
                codArea = value;
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
