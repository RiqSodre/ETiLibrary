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
    public partial class FrmCadArea : FrmCadBaseInfraestrutura
    {
        public FrmCadArea()
        {
            InitializeComponent();
        }

        private void FrmCadArea_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastrar: Área";
            lblTexto.Text = "Área:";
            lblTexto2.Text = "Lista de Áreas:";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPonte ponteArea = new FrmPonte();
            ponteArea.MdiParent = MdiParent;
            ponteArea.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }
    }
}
