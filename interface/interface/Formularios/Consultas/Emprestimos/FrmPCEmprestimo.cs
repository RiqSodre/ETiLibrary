using BLL;
using DTO.Emprestimos;
using Interface.Formularios.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmPCEmprestimo : FrmPCBase
    {
        EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
        EmprestimoList emprestimoList = new EmprestimoList();


        public FrmPCEmprestimo()
        {
            InitializeComponent();
        }


        //Botão consulta Data
        private void btnPesquisa1_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 358);
                lblPesquisa.Text = "Selecione a data do empréstimo:";
                HabilitaData(92, 310);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Estado
        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 358);
                lblPesquisa.Text = "Selecione o estado do empréstimo:";
                cbPesquisa1.Items.Add("Aberto");
                cbPesquisa1.Items.Add("Fechado");
                HabilitaCombo(92, 310);
                cbPesquisa1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Multa
        private void btnPesquisa3_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 358);
                lblPesquisa.Text = "Selecione se o empréstimo possui multa:";
                cbPesquisa1.Items.Add("Com multa");
                cbPesquisa1.Items.Add("Sem multa");
                HabilitaCombo(92, 310);
                cbPesquisa1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Pessoa
        private void btnPesquisa4_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 358);
                lblPesquisa.Text = "Digite o código do usuário:";
                HabilitaText(92, 310);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Tombo
        private void btnPesquisa5_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 358);
                lblPesquisa.Text = "Digite o código do tombo:";
                HabilitaText(92, 310);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblPesquisa.Text.Contains("data"))
                {
                    if (dtPesquisa2.Value < dtPesquisa1.Value)
                    {
                        MessageBox.Show(this, "Insira um periodo válido.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    emprestimoList = emprestimoBLL.EmprestimoConsultar_PorData(dtPesquisa1.Value, dtPesquisa2.Value);
                }
                else if (lblPesquisa.Text.Contains("estado"))
                {
                    if (cbPesquisa1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione o estado do empréstimo.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    bool estado = true;

                    if (cbPesquisa1.Text == "Aberto")
                    {
                        estado = false;
                    }
                    emprestimoList = emprestimoBLL.EmprestimoConsultar_PorEstado(estado);
                }
                else if (lblPesquisa.Text.Contains("multa"))
                {
                    if (cbPesquisa1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione o estado da multa.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    bool estado = false;

                    if (cbPesquisa1.Text == "Com multa")
                    {
                        estado = true;
                    }
                    emprestimoList = emprestimoBLL.EmprestimoConsultar_PorMulta(estado);
                }
                else if (lblPesquisa.Text.Contains("usuário"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o código do usuário.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    emprestimoList = emprestimoBLL.EmprestimoConsultar_PorPessoa(Convert.ToInt32(txtPesquisa.Text));
                }
                else
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o tombo da mídia.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    emprestimoList = emprestimoBLL.EmprestimoConsultar_PorTombo(Convert.ToInt32(txtPesquisa.Text), "Livro");
                }

                if(emprestimoList.Count == 0)
                {
                    MessageBox.Show(this, "Nenhum empréstimo encontrado.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                    return;
                }

                FrmConsultaEmprestimo frmConsultaEmprestimo = new FrmConsultaEmprestimo(emprestimoList);
                frmConsultaEmprestimo.MdiParent = this.MdiParent;
                frmConsultaEmprestimo.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Formatação Textbox
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo de pesquisa aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

