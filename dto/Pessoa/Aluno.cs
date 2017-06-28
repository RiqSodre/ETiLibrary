using DTO.Infraestrutura_de_Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Pessoa
{
    public class Aluno : Pessoa
    {
        private string rm;
        private Turma turma = new Turma();

        public string Rm
        {
            get
            {
                return rm;
            }

            set
            {
                rm = value;
            }
        }

        public Turma Turma
        {
            get
            {
                return turma;
            }

            set
            {
                turma = value;
            }
        }
    }
}
