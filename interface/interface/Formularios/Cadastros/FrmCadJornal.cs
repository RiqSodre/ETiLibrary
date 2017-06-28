using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.Formularios.Modelos;
using Interface.Formularios.Cadastros;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadJornal : FrmCadBase
    {
        public FrmCadJornal()
        {
            InitializeComponent();
        }

        private void FrmCadJornal_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastro: Jornal";
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
            FrmPonteCurso ponteJornal = new FrmPonteCurso();
            ponteJornal.MdiParent = MdiParent;
            ponteJornal.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }
    }
}
