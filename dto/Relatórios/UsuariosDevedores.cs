using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO.Pessoa;

namespace DTO.Relatórios
{
    public class UsuariosDevedores
    {
        private Pessoa.Pessoa pessoa;
        private bool multa;

        public Pessoa.Pessoa Pessoa
        {
            get
            {
                return pessoa;
            }

            set
            {
                pessoa = value;
            }
        }

        public bool Multa
        {
            get
            {
                return multa;
            }

            set
            {
                multa = value;
            }
        }
    }
}
