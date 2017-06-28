using BLL;
using DTO.Emprestimos;
using Interface.Formularios.Modelos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmConsultaEmprestimo : FrmConsultaBase
    {
        EmprestimoBLL emprestimoBLL = new EmprestimoBLL();

        public FrmConsultaEmprestimo()
        {
            InitializeComponent();
        }

        //Carrega Resultado no datagrid
        public FrmConsultaEmprestimo(EmprestimoList emprestimoList)
        {
            try
            {
                InitializeComponent();
                string condicao;

                foreach (Emprestimo emprestimo in emprestimoList)
                {
                    if (emprestimo.Fechado.Equals(true))
                    {
                        condicao = "Fechado";
                    }
                    else
                    {
                        condicao = "Aberto";
                    }

                    dataGridEmprestimo.Rows.Add(emprestimo.Usuario.CodPessoa, emprestimo.Usuario.Nome, emprestimo.CodEmprestimo,
                    emprestimo.Funcionario.CodPessoa, emprestimo.Funcionario.Nome, emprestimo.Data.ToShortDateString(), emprestimo.Multa, condicao);
                }
                dataGridEmprestimo.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message+ " "+ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        
        //Botão Fechar
        private void btnFechar2_Click(object sender, EventArgs e)
        {
            btnFechar_Click(sender, e);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridEmprestimo.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhum empréstimo selecionado.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                Emprestimo emprestimo = new Emprestimo();

                emprestimo.CodEmprestimo = (int)dataGridEmprestimo.CurrentRow.Cells["clnCodEmprestimo"].Value;
                emprestimo.MidiaEmprestimoList = emprestimoBLL.EmprestimoMidiaConsultar_PorCodEmprestimo(emprestimo.CodEmprestimo);

                FrmConsultaMidiaEmprestimo frmMidiaEmprestimo = new FrmConsultaMidiaEmprestimo(emprestimo);
                frmMidiaEmprestimo.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void dataGridEmprestimo_DoubleClick(object sender, EventArgs e)
        {
            btnSelecionar_Click(sender, e);
        }
    }
}
