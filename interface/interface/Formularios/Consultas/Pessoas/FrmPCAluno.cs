﻿using BLL;
using DTO.Pessoas;
using Interface.Formularios.Modelos;
using MetroFramework.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmPCAluno : FrmPCBase
    {


        private CursoBLL cursoBLL = new CursoBLL();
        private TurmaBLL turmaBLL = new TurmaBLL();
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private AlunoList alunoList = new AlunoList();

        public FrmPCAluno()
        {
            InitializeComponent();
        }
        
        //Botão Consulta por Código
        private void btnPesquisa1_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Digite o código do Aluno:";
                TamanhoForm(345, 358);
                HabilitaText(92, 310);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão Consulta por Curso
        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 408);
                lblPesquisa.Text = "Selecione o curso do Aluno:";
                cbPesquisa1.DisplayMember = "Descricao";
                cbPesquisa1.ValueMember = "CodCurso";

                cbPesquisa1.DataSource = cursoBLL.CarregaCursos();
                if (cbPesquisa1.Items.Count > 0)
                {
                    cbPesquisa1.SelectedIndex = 0;
                }

                TamanhoForm(345, 358);
                HabilitaCombo(92, 310);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão Consulta por Nome
        private void btnPesquisa3_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Digite aqui o nome do Aluno:";
                TamanhoForm(345, 358);
                HabilitaText(92, 310);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão Consulta por RM
        private void btnPesquisa4_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Digite aqui o RM do Aluno:";
                TamanhoForm(345, 358);
                HabilitaText(92, 310);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //botão Consulta por Turma
        private void btnPesquisa5_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                btnPesquisa2_Click(sender, e);
                HabilitaCombo(92, 348);
                lblPesquisa.Text = "Selecione a turma:";
                cbPesquisa2.Visible = true;
                cbPesquisa2.DisplayMember = "Descricao";
                cbPesquisa2.ValueMember = "CodTurma";
                cbPesquisa2.DataSource = turmaBLL.CarregaTurmas(Convert.ToInt32(cbPesquisa1.SelectedValue));

                if (cbPesquisa2.Items.Count > 0)
                {
                    cbPesquisa2.SelectedIndex = 0;
                }

                TamanhoForm(345, 391);
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
                    alunoList.Add(aluno);
                }
                else if (lblPesquisa.Text.Contains("curso"))
                {
                    if (cbPesquisa1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione o curso do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    alunoList = pessoaBLL.AlunoConsulta_PorCurso((int)cbPesquisa1.SelectedValue);
                }
                else if (lblPesquisa.Text.Contains("nome"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Digite o nome do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    alunoList = pessoaBLL.AlunoConsulta_PorNome(txtPesquisa.Text);
                }
                else if (lblPesquisa.Text.Contains("RM"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Digite o rm do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    Aluno aluno = pessoaBLL.AlunoConsulta_PorRM(txtPesquisa.Text);
                    alunoList.Add(aluno);
                }
                else
                {
                    if (cbPesquisa1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione o curso do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (cbPesquisa2.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione a turma do aluno.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    alunoList = pessoaBLL.AlunoConsulta_PorTurma((int)cbPesquisa2.SelectedValue);
                }

                FrmConsultaAluno frmConsultaAluno = new FrmConsultaAluno(alunoList);
                frmConsultaAluno.MdiParent = this.MdiParent;
                frmConsultaAluno.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void cbPesquisa1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cbPesquisa2.DataSource = turmaBLL.CarregaTurmas(Convert.ToInt32(cbPesquisa1.SelectedValue));

                if (cbPesquisa2.Items.Count > 0)
                {
                    cbPesquisa2.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(lblPesquisa.Text.Contains("código") || lblPesquisa.Text.Contains("RM"))
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                    {
                        e.Handled = true;
                        MessageBox.Show("O campo de pesquisa aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
                    {
                        e.Handled = true;
                        MessageBox.Show("O campo de pesquisa aceita apenas letras!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
