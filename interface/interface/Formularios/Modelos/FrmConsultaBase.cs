using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Formularios.Modelos
{
    public partial class FrmConsultaBase : MetroFramework.Forms.MetroForm
    {
        public FrmConsultaBase()
        {
            InitializeComponent();
        }

        //Botão Fechar
        protected void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Botão Minimizar
        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
