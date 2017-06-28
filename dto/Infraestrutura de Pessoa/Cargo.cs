namespace DTO.Infraestrutura_de_Pessoa
{
    public class Cargo
    {
        private int codCargo;
        private string descricao;

        public int CodCargo
        {
            get
            {
                return codCargo;
            }

            set
            {
                codCargo = value;
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
