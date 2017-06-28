using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Infraestrutura_de_Midia;

namespace DTO.Emprestimo
{
    public class MidiaEmprestimo : _MidiaType
    {
        private int codMidiaEmprestimo;
        private string descricao;
        private string tipoMidia;

        public int CodMidiaEmprestimo
        {
            get
            {
                return codMidiaEmprestimo;
            }

            set
            {
                codMidiaEmprestimo = value;
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

        public string TipoMidia
        {
            get
            {
                return tipoMidia;
            }

            set
            {
                tipoMidia = value;
            }
        }
    }
}
