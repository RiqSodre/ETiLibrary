using DTO.Emprestimos;
using Interface.Formularios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmConsultaMidiaEmprestimo : MetroFramework.Forms.MetroForm
    {
        //Carrega midias do empréstimo
        public FrmConsultaMidiaEmprestimo(Emprestimo emprestimo)
        {
            InitializeComponent();

            foreach (MidiaEmprestimo midiaEmprestimo in emprestimo.MidiaEmprestimoList)
            {
                dataGridMidias.Rows.Add(midiaEmprestimo.CodMidia, midiaEmprestimo.Tombo, midiaEmprestimo.Descricao, midiaEmprestimo.TipoMidia,
                    midiaEmprestimo.DataDevolucao.ToShortDateString(), midiaEmprestimo.Devolvido);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
