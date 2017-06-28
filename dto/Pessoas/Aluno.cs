using DTO.Infraestrutura_de_Pessoa;

namespace DTO.Pessoas
{
    public class Aluno : Pessoa
    {
        private string rm = null;
        private Turma turma = new Turma();

        public string Rm
        {
            get
            {
                return rm;
            }

            set
            {
                rm = value;
            }
        }

        public Turma Turma
        {
            get
            {
                return turma;
            }

            set
            {
                turma = value;
            }
        }
    }
}
