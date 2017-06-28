using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Midia
    {
        private int codMidia;

        public int CodMidia
        {
            get { return codMidia; }
            set { codMidia = value; }
        }

        private int codArea;

        public int CodArea
        {
            get { return codArea; }
            set { codArea = value; }
        }

        private bool disponivel;

        public bool Disponivel
        {
            get { return disponivel; }
            set { disponivel = value; }
        }

        private string localizacao;

        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        private string lingua;

        public string Lingua
        {
            get { return lingua; }
            set { lingua = value; }
        }

        private string tipoTombo;

        public string TipoTombo
        {
            get { return tipoTombo; }
            set { tipoTombo = value; }
        }

        private string tipoMidia;

        public string TipoMidia
        {
            get { return tipoMidia; }
            set { tipoMidia = value; }
        }

        private string observacao;

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
    }
}
