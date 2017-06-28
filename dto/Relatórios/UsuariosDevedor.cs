using DTO.Pessoas;

namespace DTO.Relatórios
{
    public class UsuariosDevedor
    {
        private Pessoa pessoa = new Pessoa();
        private bool multa;

        public Pessoa Pessoa
        {
            get
            {
                return pessoa;
            }

            set
            {
                pessoa = value;
            }
        }

        public bool Multa
        {
            get
            {
                return multa;
            }

            set
            {
                multa = value;
            }
        }
    }
}
