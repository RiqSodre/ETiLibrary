using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_Lab.Formularios.Cadastros
{
    public partial class FrmTransicaoE : MetroFramework.Forms.MetroForm
    {
        public FrmTransicaoE()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            bool existe = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "FrmCadEmprestimo")
                {
                    form.Activate();
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                FrmCadEmprestimo cademprestimo = new FrmCadEmprestimo();
                cademprestimo.MdiParent = MdiParent;
                cademprestimo.Show();
            }
            else
            {
                MessageBox.Show("Você já abriu essa janela!");
            }
            this.Dispose();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
