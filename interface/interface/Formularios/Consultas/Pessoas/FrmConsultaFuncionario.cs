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

namespace Interface.Formularios.Consultas
{
    public partial class FrmConsultaFuncionario : FrmConsultaBase
    {
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void FrmConsultaFuncionário_Load(object sender, EventArgs e)
        {
            lblForm.Text = "Consulta: Funcionário";
        }
    }
}
