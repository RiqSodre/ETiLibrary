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
    public partial class FrmCadTurma : FrmCadBaseInfraestrutura
    {
        public FrmCadTurma()
        {
            InitializeComponent();
        }

        private void FrmCadTurma_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastro: Turma";
            lblTexto.Text = "Turma:";
            lblTexto2.Text = "Lista de Turmas:";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPonteTurma ponteTurma = new FrmPonteTurma();
            ponteTurma.MdiParent = MdiParent;
            ponteTurma.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }
    }
}
