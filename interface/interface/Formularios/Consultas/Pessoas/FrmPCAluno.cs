using BLL;
using DTO.Pessoas;
using Interface.Formularios.Modelos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmPCAluno : FrmPCBase
    {
        private CursoBLL cursoBLL = new CursoBLL();
        private TurmaBLL turmaBLL = new TurmaBLL();
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private AlunoList alunoList = new AlunoList();

        //Construtor padrão
        public FrmPCAluno()
        {
            InitializeComponent();
        }
        //Botão Consulta por código
        private void btnPesq1_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 358);
                HabilitaText(92, 310);
                txtPesquisa.TabIndex = 5;
                lblPesquisa.Text = "Digite o código do Aluno:";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Botão Consulta por curso
        private void btnPesq2_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 358);
                HabilitaCombo(92, 310, cbPesq1);
                cbPesq1.TabIndex = 5;
                lblPesquisa.Text = "Selecione o curso do Aluno:";
                cbPesq1.DisplayMember = "Descricao";
                cbPesq1.ValueMember = "CodCurso";
                cbPesq1.DataSource = cursoBLL.CarregaCursos();
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
        //Botão Consulta por nome
        private void btnPesq3_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 358);
                HabilitaText(92, 310);
                txtPesquisa.TabIndex = 5;
                lblPesquisa.Text = "Digite o nome do Aluno:";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Botão Consulta por RM
        private void btnPesq4_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 358);
                HabilitaText(92, 310);
                txtPesquisa.TabIndex = 5;
                lblPesquisa.Text = "Digite o RM do Aluno:";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //botão Consulta por turma
        private void btnPesq5_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                btnPesq2_Click(sender, e);
                TamanhoForm(345, 391);
                HabilitaCombo(92, 348, cbPesq2);
                cbPesq2.TabIndex = 6;
                lblPesquisa.Text = "Selecione a turma:";
                cbPesq2.DisplayMember = "Descricao";
                cbPesq2.ValueMember = "CodTurma";
                cbPesq2.DataSource = turmaBLL.CarregaTurmas(Convert.ToInt32(cbPesq1.SelectedValue));
                if (cbPesq2.Items.Count > 0)
                {
                    cbPesq2.SelectedIndex = 0;
                }
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
                if (lblPesquisa.Text.Contains("código"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o código do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    Aluno aluno = pessoaBLL.AlunoConsulta_PorCod(Convert.ToInt32(txtPesquisa.Text));
                    if(aluno.CodPessoa == null)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                        return;
                    }
                    alunoList.Add(aluno);
                }
                else if (lblPesquisa.Text.Contains("curso"))
                {
                    if (cbPesq1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione o curso do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    alunoList = pessoaBLL.AlunoConsulta_PorCurso((int)cbPesq1.SelectedValue);
                }
                else if (lblPesquisa.Text.Contains("nome"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o nome do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    alunoList = pessoaBLL.AlunoConsulta_PorNome(txtPesquisa.Text);
                }
                else if (lblPesquisa.Text.Contains("RM"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o rm do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    Aluno aluno = pessoaBLL.AlunoConsulta_PorRM(txtPesquisa.Text);
                    if (aluno.CodPessoa == null)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                        return;
                    }
                    alunoList.Add(aluno);
                }
                else
                {
                    if (cbPesq1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione o curso do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (cbPesq2.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione a turma do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    alunoList = pessoaBLL.AlunoConsulta_PorTurma((int)cbPesq2.SelectedValue);
                }
                if(alunoList.Count != 0)
                {
                    FrmConsultaAluno frmConsultaAluno = new FrmConsultaAluno(alunoList);
                    frmConsultaAluno.MdiParent = this.MdiParent;
                    frmConsultaAluno.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show(this, "Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Carrega as turmas do curso selecionado na combobox de turmas
        private void cbPesquisa1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbPesq2.Visible == true)
                {
                    cbPesq2.DataSource = turmaBLL.CarregaTurmas(Convert.ToInt32(cbPesq1.SelectedValue));
                    if (cbPesq2.Items.Count > 0)
                    {
                        cbPesq2.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
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
                if(lblPesquisa.Text.Contains("código") || lblPesquisa.Text.Contains("RM"))
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
