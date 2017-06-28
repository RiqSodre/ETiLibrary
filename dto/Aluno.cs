using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Aluno : Pessoa
    {
        private string rm;

        public string Rm
        {
            get { return rm; }
            set { rm = value; }
        }

        private int codTurma;

        public int CodTurma
        {
            get { return codTurma; }
            set { codTurma = value; }
        }

    }
}
