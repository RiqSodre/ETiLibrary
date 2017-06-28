using DTO.Infraestrutura_de_Midia;

namespace DTO.Midia
{
    public class RevistaEx : Midia
    {
        private Revista revista_ = new Revista();
        private string titulo;
        private string edicao;

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Edicao
        {
            get
            {
                return edicao;
            }

            set
            {
                edicao = value;
            }
        }

        public Revista Revista_
        {
            get
            {
                return revista_;
            }

            set
            {
                revista_ = value;
            }
        }
    }
}
