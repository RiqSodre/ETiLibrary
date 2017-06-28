namespace DTO.Infraestrutura_de_Pessoa
{
    public class Curso
    {
        private int codCurso;
        private string descricao;

        public int CodCurso
        {
            get
            {
                return codCurso;
            }

            set
            {
                codCurso = value;
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
