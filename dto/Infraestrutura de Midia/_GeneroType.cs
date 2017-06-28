using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Infraestrutura_de_Midia
{
    public class _GeneroType
    {
        private int codGenero;
        private bool principal;

        public int CodGenero
        {
            get
            {
                return codGenero;
            }

            set
            {
                codGenero = value;
            }
        }

        public bool Principal
        {
            get
            {
                return principal;
            }

            set
            {
                principal = value;
            }
        }
    }
}
