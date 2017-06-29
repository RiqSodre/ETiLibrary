﻿using BLL;
using DTO.Pessoas;
using Interface.Formularios.Modelos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadAluno : FrmCadBase
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private CursoBLL cursoBLL = new CursoBLL();
        private TurmaBLL turmaBLL = new TurmaBLL();
        private Aluno alunoBase = new Aluno();
        private string resultado;
        public Aluno Aluno
        {
            get
            {
                return alunoBase;
            }

            set
            {
                alunoBase = value;
            }
        }

        //Construtor padrão
        public FrmCadAluno()
        {
            try
            {
                InitializeComponent();
                cbCurso.DataSource = cursoBLL.CarregaCursos();
                Habilita(true);
                LimparComponentes();
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Construtor carregando cadastro do aluno no form
        public FrmCadAluno(Aluno aluno)
        {
            try
            {
                InitializeComponent();
                cbCurso.DataSource = cursoBLL.CarregaCursos();
                Habilita(true);
                CarregaCampos(aluno);
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão de ação do form Salvar/Alterar/Excluir
        private void btnAcao_Click(object sender, EventArgs e)
        {
            try
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
                        Aluno.Nome = txtNome.Text;
                    }
                    if (cbSexo.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione o sexo do aluno.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Aluno.Sexo = cbSexo.Text;
                    }
                    if (txtCpf.Text.Length != 0)
                    {
                        if (txtCpf.Text.Length != 11)
                        {
                            MessageBox.Show(this, "O campo CPF deve conter onze caracteres.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        Aluno.Cpf = txtCpf.Text;
                    }
                    else
                    {
                        Aluno.Cpf = "";
                    }
                    if (txtRm.Text.Length > 0)
                    {
                        Aluno.Rm = txtRm.Text;
                    }
                    else
                    {
                        Aluno.Rm = "";
                    }
                    if (cbCurso.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione um curso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (cbTurma.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione uma turma.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Aluno.Turma.CodTurma = Convert.ToInt32(cbTurma.SelectedValue);
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
                            Aluno.Telefone.Numero = txtTelefone.Text;
                        }
                        else
                        {
                            MessageBox.Show(this, "O campo telefone deve conter dez digitos.", "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                            return;
                        }
                        if (txtCelular.Text.Length == 0 || txtCelular.Text.Length == 11)
                        {
                            Aluno.Celular.Numero = txtCelular.Text;
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
                        resultado = pessoaBLL.AlunoInserir(Aluno);
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
                        resultado = pessoaBLL.AlunoAlterar(Aluno);
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
                    resultado = pessoaBLL.PessoaExcluir(Aluno.CodPessoa);
                    MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    if (resultado.Contains("sucesso"))
                    {
                        Habilita(false);
                        LimparComponentes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //Botão Alterar - Abre o form ponte de aluno e carrega o aluno no form
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteAluno ponteAluno = new FrmPonteAluno(this, "Alterar");
                if (ponteAluno.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(alunoBase);
                    btnAcao.Text = "&Alterar";
                    Habilita(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Abre o form ponte de aluno e carrega o aluno no form
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteAluno ponteAluno = new FrmPonteAluno(this, "Excluir");
                if (ponteAluno.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(alunoBase);
                    btnAcao.Text = "Excluir";
                    Habilita(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        //Carrega as turmas do curso selecionado na combobox de turmas
        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbTurma.DataSource = turmaBLL.CarregaTurmas(Convert.ToInt32(cbCurso.SelectedValue));
                if (cbTurma.Items.Count > 0)
                {
                    cbTurma.SelectedIndex = 0;
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
        //Carrega o cadastro do aluno no form
        private void CarregaCampos(Aluno aluno)
        {
            try
            {
                txtNome.Text = aluno.Nome;
                cbSexo.SelectedItem = aluno.Sexo;
                txtCpf.Text = aluno.Cpf;
                txtRm.Text = aluno.Rm;
                cbCurso.SelectedValue = aluno.Turma.Curso.CodCurso;
                cbTurma.SelectedValue = aluno.Turma.CodTurma;
                txtTelefone.Text = aluno.Telefone.Numero;
                txtCelular.Text = aluno.Celular.Numero;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*Botão de Cadastrar por RM - Carrega o aluno no form através de seu rm 
         * pelo arquivo XML disponibilizado pela ETEC*/
        private void btnCadastraRM_Click(object sender, EventArgs e)
        {
            try
            {
                alunoBase = pessoaBLL.AlunoCarregarXML(txtRm.Text);
                if (alunoBase.Nome == "" || alunoBase.Nome == null)
                {
                    MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o R.M foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    CarregaCampos(alunoBase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

