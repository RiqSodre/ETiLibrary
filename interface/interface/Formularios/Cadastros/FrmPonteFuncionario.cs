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
        private FrmCadFuncionario frmCadFuncionarioBase = new FrmCadFuncionario();
        private FrmCadFuncionarioBiblioteca frmCadFuncionarioBibliotecaBase = new FrmCadFuncionarioBiblioteca();
        private Funcionario funcionario = new Funcionario();
        private bool funcBiblioteca;

        //Carrega o form ponte funcionario
        public FrmPonteFuncionario(FrmCadFuncionario frmCadFuncionario, string textoFrm)
        {
            InitializeComponent();
            frmCadFuncionarioBase = frmCadFuncionario;
            funcionario = frmCadFuncionario.Funcionario;
            funcBiblioteca = false;
            lblForm.Text +=" - "+textoFrm;
        }
        //Carrega o form ponte funcionario Biblioteca
        public FrmPonteFuncionario(FrmCadFuncionarioBiblioteca frmCadFuncionarioBiblioteca, string textoFrm)
        {
            InitializeComponent();
            frmCadFuncionarioBibliotecaBase = frmCadFuncionarioBiblioteca;
            funcionario = frmCadFuncionarioBiblioteca.Funcionario;
            funcBiblioteca = true;
            lblForm.Text += " Biblioteca - " + textoFrm;
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
                    if (funcBiblioteca)
                    {
                        funcionario = pessoaBLL.FuncionarioBiblioSelect(Convert.ToInt32(txtTexto.Text));
                        if (funcionario.CodPessoa == null || funcionario.Cargo.CodCargo != 3)
                        {
                            MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o código do funcionário foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            return;
                        }
                        pessoaTelefone();
                        frmCadFuncionarioBibliotecaBase.Funcionario = funcionario;
                    }
                    else
                    {
                        funcionario = pessoaBLL.FuncionarioConsulta_PorCod(Convert.ToInt32(txtTexto.Text));
                        if (funcionario.CodPessoa == null || funcionario.Cargo.CodCargo == 3)
                        {
                            MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o código do funcionário foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            return;
                        }
                        pessoaTelefone();
                        frmCadFuncionarioBase.Funcionario = funcionario;
                    }
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
        //Busca o(s) telefones do funcionário
        private void pessoaTelefone()
        {
            try
            {
                if (funcionario.Celular.Numero == null)
                {
                    funcionario.Celular = pessoaBLL.PessoaTelefone(funcionario.CodPessoa);
                }
                else
                {
                    funcionario.Telefone = pessoaBLL.PessoaTelefone(funcionario.CodPessoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
