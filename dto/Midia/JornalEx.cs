using DTO.Infraestrutura_de_Midia;
using System;

namespace DTO.Midia
{
    public class JornalEx : Midia
    {
        private Jornal jornal_ = new Jornal();
        private string manchete;
        private DateTime dataPublicacao;

        public Jornal Jornal_
        {
            get
            {
                return jornal_;
            }

            set
            {
                jornal_ = value;
            }
        }

        public string Manchete
        {
            get
            {
                return manchete;
            }

            set
            {
                manchete = value;
            }
        }

        public DateTime DataPublicacao
        {
            get
            {
                return dataPublicacao;
            }

            set
            {
                dataPublicacao = value;
            }
        }
    }
}
