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
    public partial class FrmCadEditora : FrmCadBaseInfraestrutura
    {
        public FrmCadEditora()
        {
            InitializeComponent();
        }

        private void FrmCadEditora_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastro: Editora";
            lblTexto.Text = "Editora:";
            lblTexto2.Text = "Lista de Editoras:";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPonte ponteEditora = new FrmPonte();
            ponteEditora.MdiParent = MdiParent;
            ponteEditora.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }
    }
}
