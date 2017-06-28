using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Infraestrutura_de_Pessoa;

namespace DTO.Pessoa
{
    public class Funcionario : Pessoa
    {
        private Cargo cargo = new Cargo();

        public Cargo Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }
    }
}
