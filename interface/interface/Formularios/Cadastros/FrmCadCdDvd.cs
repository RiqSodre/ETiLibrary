using BLL;
using DTO.Midia;
using Interface.Formularios.Modelos;
using System;
using System.Drawing;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadCdDvd : FrmCadBase
    {
        AreaBLL areaBLL = new AreaBLL();
        MidiaBLL midiaBLL = new MidiaBLL();
        private CD_DVD cdvdBase;
        public CD_DVD CD_DVD
        {
            get
            {
                return cdvdBase;
            }

            set
            {
                cdvdBase = value;
            }
        }

        //Construtor Padrão
        public FrmCadCdDvd()
        {
            InitializeComponent();
            cbArea.DataSource = areaBLL.CarregaAreas();
            Habilita(true);
            LimparComponentes();
        }
        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Habilita(false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilita(true);
        }

        //Aumenta o tamanho do Campo Observação
        private void txtObservacao_Click(object sender, EventArgs e)
        {
            txtObservacao.Height = 75;
            pnlPrincipal.Height = 324;
            this.Height = 395;
            btnAcao.Location = new Point(149, 353);
            btnCancelar.Location = new Point(241, 353);
        }
        //Retorna o tamanho do Campo Observação ao original
        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            if (txtObservacao.Text == "" || txtObservacao.Text == null)
            {
                txtObservacao.Height = 25;
                pnlPrincipal.Height = 274;
                this.Height = 345;
                btnAcao.Location = new Point(149, 303);
                btnCancelar.Location = new Point(241, 303);
            }
        }
    }
}
