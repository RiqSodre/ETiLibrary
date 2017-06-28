namespace DTO.Relatórios
{
    public class MidiasCadEmp
    {
        private string periodo;
        private int livros;
        private int cd_dvd;
        private int mapas;
        private int jornais;
        private int revistas;
        private int tcc;
        private int total;

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

        public int Livros
        {
            get
            {
                return livros;
            }

            set
            {
                livros = value;
            }
        }

        public int Cd_dvd
        {
            get
            {
                return cd_dvd;
            }

            set
            {
                cd_dvd = value;
            }
        }

        public int Mapas
        {
            get
            {
                return mapas;
            }

            set
            {
                mapas = value;
            }
        }

        public int Jornais
        {
            get
            {
                return jornais;
            }

            set
            {
                jornais = value;
            }
        }

        public int Revistas
        {
            get
            {
                return revistas;
            }

            set
            {
                revistas = value;
            }
        }

        public int Tcc
        {
            get
            {
                return tcc;
            }

            set
            {
                tcc = value;
            }
        }

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}
