using BLL;
using DTO.Pessoas;
using Interface.Formularios.Modelos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadFuncionario : FrmCadBase
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private Funcionario funcionario = new Funcionario();
        private CargoBLL cargoBLL = new CargoBLL();
        public Funcionario Funcionario
        {
            get
            {
                return funcionario;
            }

            set
            {
                funcionario = value;
            }
        }
        private string resultado;

        //Contrutor padrão
        public FrmCadFuncionario()
        {
            try
            {
                InitializeComponent();
                cbCargo.DataSource = cargoBLL.CarregaCargos();
                Habilita(true);
                LimparComponentes();
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Construtor carregando cadastro do funcionario no form
        public FrmCadFuncionario(Funcionario funcionario)
        {
            try
            {
                InitializeComponent();
                cbCargo.DataSource = cargoBLL.CarregaCargos();
                Habilita(true);
                CarregaCampos(funcionario);
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão de ação do form Salvar/Alterar/Excluir - Implementar
        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (btnAcao.Text == "&Salvar" || btnAcao.Text == "&Alterar")
            {
                if (txtNome.Text.Length == 0)
                {
                    MessageBox.Show(this, "O campo nome é obrigatório.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if (txtNome.Text.Length < 8)
                {
                    MessageBox.Show(this, "O campo nome deve conter no minimo oito letras.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if (txtNome.Text.Length > 50)
                {
                    MessageBox.Show(this, "O campo nome pode conter no maximo cinquenta caracteres.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Funcionario.Nome = txtNome.Text;
                }
                if (cbSexo.SelectedIndex == -1)
                {
                    MessageBox.Show(this, "Selecione o sexo do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Funcionario.Sexo = cbSexo.Text;
                }
                if (txtCpf.Text.Length == 0)
                {
                    MessageBox.Show(this, "O campo CPF é obrigatório.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if (txtCpf.Text.Length != 11)
                {
                    MessageBox.Show(this, "O campo CPF deve conter onze caracteres.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    funcionario.Cpf = txtCpf.Text;
                }
                if (cbCargo.SelectedIndex == -1)
                {
                    MessageBox.Show(this, "Selecione um cargo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    funcionario.Cargo.CodCargo = Convert.ToInt32(cbCargo.SelectedValue);
                }
                //Telefone e Celular
                if (txtTelefone.Text.Length == 0 && txtCelular.Text.Length == 0)
                {
                    MessageBox.Show(this, "É necessário inserir pelo menos um número para contato.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (txtTelefone.Text.Length == 0 || txtTelefone.Text.Length == 10)
                    {
                        Funcionario.Telefone.Numero = txtTelefone.Text;
                    }
                    else
                    {
                        MessageBox.Show(this, "O campo telefone deve conter dez digitos.", "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                        return;
                    }
                    if (txtCelular.Text.Length == 0 || txtCelular.Text.Length == 11)
                    {
                        Funcionario.Celular.Numero = txtCelular.Text;
                    }
                    else
                    {
                        MessageBox.Show(this, "O campo celular deve conter onze digitos.", "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (btnAcao.Text == "&Salvar")
                {
                    resultado = pessoaBLL.FuncionarioInserir(funcionario);
                    MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    if (resultado.Contains("sucesso"))
                    {
                        Habilita(false);
                        LimparComponentes();
                    }
                }
                else 
                {
                    resultado = pessoaBLL.FuncionarioAlterar(funcionario);
                    MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    if (resultado.Contains("sucesso"))
                    {
                        Habilita(false);
                        LimparComponentes();
                    }
                }
            }
            else
            {
                resultado = pessoaBLL.PessoaExcluir(funcionario.CodPessoa);
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    Habilita(false);
                    LimparComponentes();
                }
            }
        }
        //Botão Carcelar - limpa o form de trava os componentes
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparComponentes();
                Habilita(false);
                btnNovo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão que habilita e limpa os componentes do form
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                LimparComponentes();
                Habilita(true);
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
                    CarregaCampos(funcionario);
                    btnAcao.Text = "&Alterar";
                    Habilita(true);
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
                    CarregaCampos(funcionario);
                    btnAcao.Text = "&Excluir";
                    Habilita(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o Campo nome aceitar apenas letras
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Nome aceita apenas letras!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o Campo cpf aceitar apenas números
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo CPF aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o Campo rm aceitar apenas números
        private void txtRm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo RM aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o Campo telefone aceitar apenas números
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Telefone aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o Campo celular aceitar apenas números
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Celular aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                txtNome.Text = funcionario.Nome;
                cbSexo.SelectedItem = funcionario.Sexo;
                cbCargo.SelectedValue = funcionario.Cargo.CodCargo;
                txtCpf.Text = funcionario.Cpf;
                txtTelefone.Text = funcionario.Telefone.Numero;
                txtCelular.Text = funcionario.Celular.Numero;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
