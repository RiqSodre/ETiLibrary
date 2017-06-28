namespace DTO.Infraestrutura_de_Pessoa
{
    public class Telefone
    {
        private string numero;
        private string telefoneTipo;

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string TelefoneTipo
        {
            get
            {
                return telefoneTipo;
            }

            set
            {
                telefoneTipo = value;
            }
        }
    }
}
