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
    public partial class FrmPonteCurso : FrmPonte
    {
        public FrmPonteCurso()
        {
            InitializeComponent();
        }

        private void FrmPonteCurso_Load(object sender, EventArgs e)
        {
            lblTexto.Text = "Digite o código do Curso:";
        }
    }
}
