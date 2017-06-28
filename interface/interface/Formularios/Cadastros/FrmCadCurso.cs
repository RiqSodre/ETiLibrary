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
    public partial class FrmCadCurso : FrmCadBaseInfraestrutura
    {
        public FrmCadCurso()
        {
            InitializeComponent();
        }

        private void FrmCadCurso_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Cadastro: Curso";
            lblTexto.Text = "Curso:";
            lblTexto2.Text = "Lista de Cursos:";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPonteCurso ponteCurso = new FrmPonteCurso();
            ponteCurso.MdiParent = MdiParent;
            ponteCurso.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(sender, e);
        }
    }
}
