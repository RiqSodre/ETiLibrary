using BLL;
using DTO.Pessoas;
using Interface.Formularios.Modelos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmPCFuncionario : FrmPCBase
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private FuncionariosList funcionarioList = new FuncionariosList();

        //Construtor padrão
        public FrmPCFuncionario()
        {
            InitializeComponent();
        }
        //Botão consulta cargo
        private void btnPesq1_Click(object sender, EventArgs e)
        {
            try
            {
                var cargos = new[] {
                new { Descricao = "Professor", CodCargo = 1 }, new { Descricao = "Funcionário" , CodCargo = 2 },
                    new { Descricao = "Funcionário Biblioteca", CodCargo = 3} };
                LimpaForm();
                TamanhoForm(345, 349);
                HabilitaCombo(92, 297, cbPesq1);
                cbPesq1.TabIndex = 4;
                lblPesquisa.Text = "Selecione o cargo do Funcionário:";
                cbPesq1.DisplayMember = "Descricao";
                cbPesq1.ValueMember = "CodCargo";
                cbPesq1.DataSource = cargos;
                if (cbPesq1.Items.Count > 0)
                {
                    cbPesq1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Botão consulta código
        private void btnPesq2_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 349);
                HabilitaText(92, 297);
                txtPesquisa.TabIndex = 4;
                lblPesquisa.Text = "Digite o código do Funcionário:";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Botão consulta CPF
        private void btnPesq3_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 349);
                HabilitaText(92, 297);
                txtCPF.TabIndex = 4;
                lblPesquisa.Text = "Digite o CPF do Funcionário:";
                txtPesquisa.Visible = false;
                txtCPF.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Botão consutlta nome
        private void btnPesq4_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 349);
                HabilitaText(92, 297);
                txtPesquisa.TabIndex = 4;
                lblPesquisa.Text = "Digite o nome do Funcionário:";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblPesquisa.Text.Contains("cargo"))
                {
                    if (cbPesq1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione o cargo do funcionário.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    funcionarioList = pessoaBLL.FuncionarioConsulta_PorCargo((int)cbPesq1.SelectedValue);
                }
                else if (lblPesquisa.Text.Contains("código"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o código do funcionário.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    Funcionario func = pessoaBLL.FuncionarioConsulta_PorCod(Convert.ToInt32(txtPesquisa.Text));
                    if(func.CodPessoa == null)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                    }
                    funcionarioList.Add(func);
                }
                else if (lblPesquisa.Text.Contains("CPF"))
                {
                    if (txtCPF.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o CPF do funcionário.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    Funcionario func = pessoaBLL.FuncionarioConsulta_PorCPF(txtCPF.Text);
                    if (func.CodPessoa == null)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                    }
                    funcionarioList.Add(func);
                }
                else
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o nome do funcionário.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    funcionarioList = pessoaBLL.FuncionarioConsulta_PorNome(txtPesquisa.Text);
                }
                if (funcionarioList.Count != 0)
                {
                    FrmConsultaFuncionario frmConsultaFunc = new FrmConsultaFuncionario(funcionarioList);
                    frmConsultaFunc.MdiParent = this.MdiParent;
                    frmConsultaFunc.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show(this, "Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Faz o campo de Pesquisa aceitar apenas os caracteres referentes a pesquisa
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (lblPesquisa.Text.Contains("código") || lblPesquisa.Text.Contains("CPF"))
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                    {
                        e.Handled = true;
                        MessageBox.Show("O campo de pesquisa aceita apenas números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
                    {
                        e.Handled = true;
                        MessageBox.Show("O campo de pesquisa aceita apenas letras.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
