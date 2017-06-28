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
    public partial class FrmCadCargo : FrmCadBaseInfraestrutura
    {
        public FrmCadCargo()
        {
            InitializeComponent();
        }

        private void FrmCadCargo_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastro: Cargo";
            lblTexto.Text = "Cargo:";
            lblTexto2.Text = "Lista de Cargos:";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPonte ponteCargo = new FrmPonte();
            ponteCargo.MdiParent = MdiParent;
            ponteCargo.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }
    }
}
