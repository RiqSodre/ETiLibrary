using DTO.Infraestrutura_de_Pessoa;

namespace DTO.Pessoas
{
    public class Funcionario : Pessoa
    {
        private Cargo cargo = new Cargo();

        public Cargo Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }
    }
}
