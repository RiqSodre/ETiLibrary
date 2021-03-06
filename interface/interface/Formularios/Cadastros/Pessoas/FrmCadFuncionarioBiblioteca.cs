﻿using System.Windows.Forms;
using Interface.Formularios.Modelos;
using System;
using DTO.Pessoas;
using BLL;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadFuncionarioBiblioteca : FrmCadBase
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private AutenticacaoBLL autenticaBLL = new AutenticacaoBLL();
        private Funcionario funcBase = new Funcionario();
        public Funcionario Func
        {
            get
            {
                return funcBase;
            }

            set
            {
                funcBase = value;
            }
        }

        //Construtor padrão
        public FrmCadFuncionarioBiblioteca()
        {
            try
            {
                InitializeComponent();
                Habilita(true);
                LimparComponentes();
                cbCargo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Construtor carregando cadastro do funcionario no form
        public FrmCadFuncionarioBiblioteca(Funcionario funcionario) : this()
        {
            try
            {
                CarregaCampos(funcionario);
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Botão de ação do form Salvar/Alterar/Excluir - Implementar
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            if (btnAcao.Text == "Salvar" || btnAcao.Text == "Alterar")
            {
                //Validações campo Nome
                if (txtNome.Text.Length == 0)
                {
                    MessageBox.Show(this, "O campo Nome é obrigatório.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if (txtNome.Text.Length < 8)
                {
                    MessageBox.Show(this, "O campo Nome deve conter no mínimo oito letras.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Func.Nome = txtNome.Text;
                }
                //Validações campo Sexo
                if (cbSexo.SelectedIndex == -1)
                {
                    MessageBox.Show(this, "Selecione o sexo do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Func.Sexo = cbSexo.Text;
                }
                //Validações campo Cpf
                if (txtCpf.Text.Length == 0)
                {
                    MessageBox.Show(this, "O campo CPF é obrigatório.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if (txtCpf.Text.Length != 11)
                {
                    MessageBox.Show(this, "O campo CPF deve conter onze números.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (autenticaBLL.ValidarCPF(txtCpf.Text))
                    {
                        Func.Cpf = txtCpf.Text;
                    }
                    else
                    {
                        MessageBox.Show(this, "Informe um CPF válido.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }
                Func.CodCargo = 3;
                //Validações campos Telefone e Celular
                if (txtTelefone.Text.Length == 0 && txtCelular.Text.Length == 0)
                {
                    MessageBox.Show(this, "É necessário inserir pelo menos um número para contato.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (txtTelefone.Text.Length == 0 || txtTelefone.Text.Length == 10)
                    {
                        Func.Telefone.Numero = txtTelefone.Text;
                    }
                    else
                    {
                        MessageBox.Show(this, "O campo Telefone deve conter dez números.", "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                        return;
                    }
                    if (txtCelular.Text.Length == 0 || txtCelular.Text.Length == 11)
                    {
                        Func.Celular.Numero = txtCelular.Text;
                    }
                    else
                    {
                        MessageBox.Show(this, "O campo Celular deve conter onze números.", "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                        return;
                    }
                }
                //Validações campo Email
                if (txtEmail.Text.Length == 0)
                {
                    MessageBox.Show(this, "O campo Email é obrigatório.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if (!autenticaBLL.ValidarEmail(txtEmail.Text))
                {
                    MessageBox.Show(this, "Digite um email valido.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Func.Email = txtEmail.Text;
                }
                //Validações campo Login
                if (txtLogin.Text.Length == 0)
                {
                    MessageBox.Show(this, "O campo Login é obrigatório.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if (txtLogin.Text.Length < 6)
                {
                    MessageBox.Show(this, "O campo Login deve conter no mínimo 6 caracteres.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Func.Login = txtLogin.Text;
                }
                //Validações campo Senha
                if (txtSenha.Text.Length == 0)
                {
                    MessageBox.Show(this, "O campo Senha é obrigatório.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if (txtSenha.Text.Length < 6)
                {
                    MessageBox.Show(this, "O campo Senha deve conter no mínimo 6 caracteres.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Func.Senha = autenticaBLL.CripSenha(txtSenha.Text);
                }
                //Validações campo Admin
                if (checkAdmin.Checked)
                {
                    Func.Admin = true;
                }
                else
                {
                    Func.Admin = false;
                }
                //Execução
                if (btnAcao.Text == "Salvar")
                {
                    resultado = pessoaBLL.FuncionarioBiblioInserir(Func);
                }//Execução
                else
                {
                    resultado = pessoaBLL.FuncionarioBiblioAlterar(Func);
                }
            }
            else
            {
                if (MessageBox.Show(this, "Deseja excluir este funcionário(a)?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    resultado = pessoaBLL.PessoaExcluir(Func.CodPessoa);
                }
            }
            MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            if (resultado.Contains("sucesso"))
            {
                Habilita(false);
                LimparComponentes();
            }
            if (resultado.Contains("sucesso"))
            {
                Habilita(false);
                LimparComponentes();
            }
        }
        //Botão que habilita e limpa os componentes do form
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                Habilita(true);
                LimparComponentes();
                cbCargo.SelectedIndex = 0;
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Abre o form ponte de funcionário e carrega o funcionário no form 
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteFuncionario ponteFuncionario = new FrmPonteFuncionario(this, "Alterar");
                if (ponteFuncionario.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(Func);
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Abre o form ponte de funcionário e carrega o funcionário no form 
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteFuncionario ponteFuncionario = new FrmPonteFuncionario(this, "Excluir");
                if (ponteFuncionario.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(Func);
                    btnAcao.Text = "Excluir";
                    Habilita(true);
                    btnAcao.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo Nome aceitar apenas letras
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Nome aceita apenas letras.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo Cpf aceitar apenas números
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo CPF aceita apenas números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo Telefone aceitar apenas números
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Telefone aceita apenas números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo Celular aceitar apenas números
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Celular aceita apenas números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo Login aceitar apenas letras e numeros
        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Login aceita apenas letras e números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo Senha aceitar apenas letras e numeros
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Senha aceita apenas letras e números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Libera a visualização da senha de acordo com a checkbox
        private void checkMSenha_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkMSenha.Checked)
                {
                    txtSenha.PasswordChar = '\0';
                }
                else
                {
                    txtSenha.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Carrega o cadastro do funcionário no form
        private void CarregaCampos(Funcionario funcionario)
        {
            txtNome.Text = funcionario.Nome;
            cbSexo.SelectedItem = funcionario.Sexo;
            cbCargo.SelectedIndex = 0;
            txtCpf.Text = funcionario.Cpf;
            txtTelefone.Text = funcionario.Telefone.Numero;
            txtCelular.Text = funcionario.Celular.Numero;
            txtEmail.Text = funcionario.Email;
            txtLogin.Text = funcionario.Login;
            txtSenha.Text = autenticaBLL.DecripSenha(funcionario.Senha);
            if (funcionario.Admin)
            {
                checkAdmin.Checked = true;
            }
            else
            {
                checkAdmin.Checked = false;
            }
            toolExibe(txtNome, txtNome.Text);
            toolExibe(txtEmail, txtEmail.Text);
        }
    }
}
