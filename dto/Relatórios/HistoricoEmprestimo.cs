using DTO.Pessoas;
using DTO.Emprestimos;

namespace DTO.Relatórios
{
    public class HistoricoEmprestimo
    {
        private Pessoa aluno = new Pessoa();
        private Pessoa funcionario = new Pessoa();
        private Emprestimo emprestimo = new Emprestimo();

        public Pessoa Aluno
        {
            get
            {
                return aluno;
            }

            set
            {
                aluno = value;
            }
        }

        public Pessoa Funcionario
        {
            get
            {
                return funcionario;
            }

            set
            {
                funcionario = value;
            }
        }

        public Emprestimo Emprestimo
        {
            get
            {
                return emprestimo;
            }

            set
            {
                emprestimo = value;
            }
        }
    }
}
