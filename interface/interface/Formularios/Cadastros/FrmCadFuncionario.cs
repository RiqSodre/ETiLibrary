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
        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            cbSexo.SelectedIndex = 0;
            //cbCargo.DataSource = cargoBLL.CarregaCargos();
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           /* FrmPonteAluno ponteAluno = new FrmPonteAluno(this);
            if (ponteAluno.ShowDialog() == DialogResult.OK)
            {
                txtNome.Text = funcionario.Nome;
                cbSexo.SelectedItem = funcionario.Sexo;
                txtCpf.Text = funcionario.Cpf;
                txtTelefone.Text = funcionario.Telefone.Numero;
                txtCelular.Text = funcionario.Celular.Numero;

                btnAcao.Text = "Alterar";
            }*/
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            /*
            FrmPonteAluno ponteAluno = new FrmPonteAluno(this);
            if (ponteAluno.ShowDialog() == DialogResult.OK)
            {
                txtNome.Text = funcionario.Nome;
                cbSexo.SelectedItem = funcionario.Sexo;
                txtCpf.Text = funcionario.Cpf;
                txtTelefone.Text = funcionario.Telefone.Numero;
                txtCelular.Text = funcionario.Celular.Numero;

                btnAcao.Text = "Excluir";
            }*/
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int parsable;

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
            else if (int.TryParse(txtNome.Text, out parsable))
            {
                MessageBox.Show(this, "Insira um nome valido.", "Atenção", MessageBoxButtons.OK,
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

            Funcionario.Sexo = cbSexo.Text;

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
                Funcionario.Celular.Numero = txtCelular.Text;
            }

            if (btnAcao.Text == "Salvar")
            {
                MessageBox.Show(pessoaBLL.FuncionarioInserir(Funcionario));
            }
            else if (btnAcao.Text == "Alterar")
            {
                MessageBox.Show(pessoaBLL.FuncionarioAlterar(Funcionario));
            }
            else
            {
                MessageBox.Show(pessoaBLL.PessoaExcluir(Funcionario.CodPessoa));
            }

            if (txtTelefone.Text.Length == 0 && txtCelular.Text.Length == 0)
            {
                MessageBox.Show(this, "É necessário inserir pelo menos um número para contato.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtTelefone.Text.Length < 10)
                {
                    MessageBox.Show(this, "O campo telefone deve conter onze digitos.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Funcionario.Telefone.Numero = txtTelefone.Text;
                }

                if (txtCelular.Text.Length < 11)
                {
                    MessageBox.Show(this, "O campo telefone deve conter onze digitos.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Funcionario.Celular.Numero = txtCelular.Text;
                }
            }
            LimparComponentes();

            Habilita();

            }

            public void Desabilita()
            {
            //Desabilita os campos quando o cadastro é realizado
            txtNome.Enabled = false;
            cbSexo.Enabled = false;
            txtCpf.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            }

            public void Habilita()
            {
            //Habilita os campos para novo cadastro
            txtNome.Enabled = true;
            cbSexo.Enabled = true;
            txtCpf.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbCargo.DataSource = cargoBLL.CarregaCargos(Convert.ToInt32(cbCargo.SelectedValue));
            //cbCargo.SelectedIndex = 0;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("O campo CPF aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("O campo Telefone aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("O campo Celular aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
