using BLL;
using DTO.Pessoas;
using Interface.Formularios.Modelos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteAluno : FrmPonte
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private FrmCadAluno frmCadAlunoBase = new FrmCadAluno();
        private Aluno aluno = new Aluno();

        //Carrega o form ponte aluno
        public FrmPonteAluno(FrmCadAluno frmCadAluno, string txtFrm)
        {
            try
            {
                InitializeComponent();
                frmCadAlunoBase = frmCadAluno;
                aluno = frmCadAlunoBase.Aluno;
                lblForm.Text += " - " + txtFrm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        //Carrega os dados do aluno que serão passsados para o form de cadastro
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTexto.Text.Length == 0)
                {
                    MessageBox.Show(this, "Digite o código do aluno no campo informado.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    aluno = pessoaBLL.AlunoConsulta_PorCod(Convert.ToInt32(txtTexto.Text));
                    if (aluno.CodPessoa == null)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o código do aluno foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                    if (aluno.Celular.Numero == null)
                    {
                        aluno.Celular = pessoaBLL.PessoaTelefone(aluno.CodPessoa);
                    }
                    else
                    {
                        aluno.Telefone = pessoaBLL.PessoaTelefone(aluno.CodPessoa);
                    }
                    frmCadAlunoBase.Aluno = aluno;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o Campo do código do aluno aceitar apenas números
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
