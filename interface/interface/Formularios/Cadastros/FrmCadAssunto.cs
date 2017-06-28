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

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadAssunto : FrmCadBaseInfraestrutura
    {
        public FrmCadAssunto()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPonte ponteAssunto = new FrmPonte();
            ponteAssunto.MdiParent = MdiParent;
            ponteAssunto.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }

        private void FrmCadAssunto_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastrar: Assunto";
            lblTexto.Text = "Assunto:";
            lblTexto2.Text = "Lista de Assuntos:";
        }
    }
}
