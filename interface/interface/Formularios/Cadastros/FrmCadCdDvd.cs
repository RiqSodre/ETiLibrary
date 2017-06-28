using BLL;
using DTO.Midia;
using Interface.Formularios.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadCdDvd : FrmCadBase
    {


        public FrmCadCdDvd()
        {
            InitializeComponent();
        }
        
        private void FrmCadCdDvd_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastro: CD e DVD";
        }

        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            if (txtObservacao.Text == "" || txtObservacao.Text == null)
            {
                txtObservacao.Width = 290;
                txtObservacao.Height = 25;
                this.Height = 348;
                btnAcao.Location = new Point(149, 302);
                btnCancelar.Location = new Point(241, 302);
            }
        }

        private void txtObservacao_Click(object sender, EventArgs e)
        {
            txtObservacao.Width = 290;
            txtObservacao.Height = 90;
            this.Height = 416;
            btnAcao.Location = new Point(149, 372);
            btnCancelar.Location = new Point(241, 372);
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
    }
}
