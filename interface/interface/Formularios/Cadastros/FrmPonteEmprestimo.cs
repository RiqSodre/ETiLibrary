using BLL;
using DTO.Emprestimos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteEmprestimo : Interface.Formularios.Modelos.FrmPonte
    {
        private EmprestimoList emprestimoList = new EmprestimoList();
        private EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private Emprestimo emprestimoBase = new Emprestimo();

        public FrmPonteEmprestimo()
        {
            InitializeComponent();
        }

        //Carrega o emprestimo ou abre um novo emprestimo e envia para o formulario seguinte
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTexto.Text.Length == 0)
                {
                    MessageBox.Show(this, "Digite o código do usuário no campo informado.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    emprestimoList = emprestimoBLL.EmprestimoConsultar(Convert.ToInt32(txtTexto.Text));
                    emprestimoBase.Usuario = pessoaBLL.AlunoConsulta_PorCod(Convert.ToInt32(txtTexto.Text));

                    if (emprestimoBase.Usuario.CodPessoa == null || emprestimoBase.Usuario.CodPessoa.ToString() == "")
                    {
                        emprestimoBase.Usuario = pessoaBLL.FuncionarioConsulta_PorCod(Convert.ToInt32(txtTexto.Text));
                        if (emprestimoBase.Usuario.CodPessoa == null || emprestimoBase.Usuario.CodPessoa.ToString() == "")
                        {
                            MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o código foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    foreach (Emprestimo emprestimo in emprestimoList)
                    {
                        emprestimo.Usuario = emprestimoBase.Usuario;
                        emprestimoBase = emprestimo;
                    }

                    FrmCadEmprestimo frmCadEmprestimo = new FrmCadEmprestimo(emprestimoBase);
                    frmCadEmprestimo.MdiParent = MdiParent;
                    frmCadEmprestimo.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: "+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Faz o Campo aceitar apenas números
        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo codigo aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
