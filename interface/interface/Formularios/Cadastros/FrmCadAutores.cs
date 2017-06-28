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
    public partial class FrmCadAutores : FrmCadBaseInfraestrutura
    {
        public FrmCadAutores()
        {
            InitializeComponent();
        }

        private void FrmCadAutores_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastro: Autores";
            lblTexto.Text = "Autores:";
            lblTexto2.Text = "Lista de Autores:";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPonte ponteInfraestrutura = new FrmPonte();
            ponteInfraestrutura.MdiParent = MdiParent;
            ponteInfraestrutura.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }
    }
}
