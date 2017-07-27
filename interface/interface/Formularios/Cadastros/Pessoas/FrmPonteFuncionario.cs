using System;
using Interface.Formularios.Modelos;
using BLL;
using DTO.Pessoas;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteFuncionario : FrmPonte
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private FrmCadFuncionario frmCadFuncBase = new FrmCadFuncionario();
        private FrmCadFuncionarioBiblioteca frmCadFuncBBase = new FrmCadFuncionarioBiblioteca();
        private Funcionario func = new Funcionario();
        private bool funcB;

        //Carrega o form ponte funcionario
        public FrmPonteFuncionario(FrmCadFuncionario frmCadFunc, string txtFrm)
        {
            try
            {
                InitializeComponent();
                frmCadFuncBase = frmCadFunc;
                func = frmCadFunc.Func;
                funcB = false;
                lblForm.Text += " - " + txtFrm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Carrega o form ponte funcionario Biblioteca
        public FrmPonteFuncionario(FrmCadFuncionarioBiblioteca frmCadFuncB, string txtFrm)
        {
            try
            {
                InitializeComponent();
                frmCadFuncBBase = frmCadFuncB;
                func = frmCadFuncB.Func;
                funcB = true;
                lblForm.Text += " Biblioteca - " + txtFrm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Carrega os dados do funcionario que serão passsados para o form de cadastro
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTexto.Text.Length == 0)
                {
                    MessageBox.Show(this, "Digite o código do funcionário no campo informado.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (funcB)
                    {
                        func = pessoaBLL.FuncionarioBiblioSelect(Convert.ToInt32(txtTexto.Text));
                        if (func.CodPessoa == null || func.CodCargo != 3)
                        {
                            MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o código do funcionário foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            return;
                        }
                        pessoaTelefone();
                        frmCadFuncBBase.Func = func;
                    }
                    else
                    {
                        func = pessoaBLL.FuncionarioConsulta_PorCod(Convert.ToInt32(txtTexto.Text));
                        if (func.CodPessoa == null || func.CodCargo == 3)
                        {
                            MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o código do funcionário foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            return;
                        }
                        pessoaTelefone();
                        frmCadFuncBase.Func = func;
                    }
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo do código do funcionário aceitar apenas números
        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo codigo aceita apenas números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Busca o(s) telefones do funcionário
        private void pessoaTelefone()
        {
            try
            {
                if (func.Celular.Numero == null)
                {
                    func.Celular = pessoaBLL.PessoaTelefone(func.CodPessoa);
                }
                else
                {
                    func.Telefone = pessoaBLL.PessoaTelefone(func.CodPessoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
