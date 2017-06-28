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
    public partial class FrmPonteFuncionario : FrmPonte
    {
        public FrmPonteFuncionario()
        {
            InitializeComponent();
        }

        private void FrmPonteFuncionario_Load(object sender, EventArgs e)
        {
            lblTexto.Text = "Digite o código do Funcionário:";
        }
    }
}
