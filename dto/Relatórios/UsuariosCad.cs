namespace DTO.Relatórios
{
    public class UsuariosCad
    {
        private string periodo;
        private int alunosCad;
        private int funcionariosCad;
        private int totalCad;

        public string Periodo
        {
            get
            {
                return periodo;
            }

            set
            {
                periodo = value;
            }
        }

        public int AlunosCad
        {
            get
            {
                return alunosCad;
            }

            set
            {
                alunosCad = value;
            }
        }

        public int FuncionariosCad
        {
            get
            {
                return funcionariosCad;
            }

            set
            {
                funcionariosCad = value;
            }
        }

        public int TotalCad
        {
            get
            {
                return totalCad;
            }

            set
            {
                totalCad = value;
            }
        }
    }
}
