namespace DTO.Infraestrutura_de_Pessoa
{
    public class Turma
    {
        private int codTurma;
        private string descricao;
        private string periodo;
        private Curso curso = new Curso();

        public int CodTurma
        {
            get
            {
                return codTurma;
            }

            set
            {
                codTurma = value;
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

        public Curso Curso
        {
            get
            {
                return curso;
            }

            set
            {
                curso = value;
            }
        }
    }
}
