using BLL;
using DTO.Infraestrutura_de_Pessoa;
using Interface.Formularios.Modelos;
using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros.Infraestrutura
{
    public partial class FrmCadCursoT : FrmCadBase
    {
        private CursoBLL cursoBLL = new CursoBLL();
        private TurmaBLL turmaBLL = new TurmaBLL();
        private int[] codTurmas;
        private Turma turmaBase = new Turma();
        public Turma Turma
        {
            get
            {
                return turmaBase;
            }

            set
            {
                turmaBase = value;
            }
        }

        //Construtor padrão
        public FrmCadCursoT()
        {
            try
            {
                InitializeComponent();
                Habilita(false);
                dataGridTurmas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                dataGridTurmas.Enabled = true;
                cbCurso.Enabled = true;
                cbCurso.DataSource = cursoBLL.CarregaCursos();
                cbCurso.SelectedIndex = 0;
                cbCurso.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Construtor carregando o curso
        public FrmCadCursoT(Curso curso) : this()
        {
            try
            {
                cbCurso.SelectedValue = curso.CodCurso;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Botão de ação do form Salvar/Alterar/Excluir
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnAcao.Text.Equals("Salvar") || btnAcao.Text.Equals("Alterar"))
                {
                    //Validações campo Curso
                    if(txtCurso.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Curso é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if(txtCurso.Text.Length < 4)
                    {
                        MessageBox.Show(this, "O campo Curso deve conter no minimo 4 caracteres.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }
                    //Validações Turma
                    if(dataGridTurmas.RowCount < 1)
                    {
                        MessageBox.Show(this, "O curso deve conter pelo menos uma turma.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }
                    if(btnAcao.Text.Equals("Salvar"))
                    {
                        //Variavel para guardar o código do Curso
                        int codCurso;
                        //Execução
                        resultado = cursoBLL.CursoInserir(txtCurso.Text);
                        codCurso = cursoBLL.CursoConsultarCod_PorNome(txtCurso.Text);
                        foreach (DataGridViewRow dataRow in dataGridTurmas.Rows)
                        {
                            Turma turmaAdd = new Turma();
                            turmaAdd.Descricao = (string)dataRow.Cells["clnTurma"].Value;
                            turmaAdd.Periodo = (string)dataRow.Cells["clnPeriodo"].Value;
                            turmaAdd.Curso.CodCurso = codCurso;
                            turmaBLL.TurmaInserir(turmaAdd);
                        }
                    }
                    else 
                    {
                        //Variaveis 
                        bool novo = true;
                        Curso cursoAlt = new Curso();
                        cursoAlt.Descricao = txtCurso.Text;
                        cursoAlt.CodCurso = (int)cbCurso.SelectedValue;
                        //Execução
                        resultado = cursoBLL.CursoAlterar(cursoAlt);
                        foreach (DataGridViewRow dataRow in dataGridTurmas.Rows)
                        {
                            Turma turma = new Turma();
                            turma.Descricao = (string)dataRow.Cells["clnTurma"].Value;
                            turma.Periodo = (string)dataRow.Cells["clnPeriodo"].Value;
                            turma.Curso.CodCurso = cursoAlt.CodCurso;
                            for(int cont = 0; cont<codTurmas.GetLength(0); cont++)
                            {
                                if(codTurmas[cont] == (int)dataRow.Cells["clnCodTurma"].Value && (int)dataRow.Cells["clnCodTurma"].Value != 0)
                                {
                                    codTurmas[cont] = 0;
                                    novo = false;
                                }
                            }
                            if(!novo)
                            {
                                turmaBLL.TurmaAlterar(turma);
                            }
                            else
                            {
                                turmaBLL.TurmaInserir(turma);
                            }
                            novo = true;
                        }
                        //Excluir turmas retiradas
                        for (int cont = 0; cont < codTurmas.GetLength(0); cont++)
                        {
                            if (codTurmas[cont] != 0)
                            {
                                turmaBLL.TurmaExcluir(codTurmas[cont]);
                            }
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este Curso e suas Turmas?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = cursoBLL.CursoExcluir((int)cbCurso.SelectedValue);
                    }
                }
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    cbCurso.DataSource = cursoBLL.CarregaCursos();
                    btnCancelar_Click(sender, e);
                }
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
                cbCurso.Enabled = false;
                txtCurso.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Habilita a edição do curso e suas turmas
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione um curso.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    cbCurso.Enabled = false;
                    txtCurso.Text = cbCurso.Text;
                    txtCurso.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Habilita a exclusão do curso e suas turmas
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione um curso.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnAcao.Text = "Excluir";
                    Habilita(false);
                    txtCurso.Text = cbCurso.Text;
                    dataGridTurmas.Enabled = true;
                    btnAcao.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnAcao.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Carcelar - limpa o form e trava os componentes
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparComponentes();
                Habilita(false);
                dataGridTurmas.Enabled = true;
                cbCurso.Enabled = true;
                cbCurso.SelectedIndex = 0;
                cbCurso.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Carrega as turmas no datagrid e mostra o conteúdo da combobox
        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridTurmas.Rows.Clear();
                if ((sender as ComboBox).SelectedIndex != -1)
                {
                    int cont = 0;
                    toolExibe(cbCurso, cbCurso.Text);
                    foreach (Turma turma in turmaBLL.CarregaTurmas((int)cbCurso.SelectedValue))
                    {
                        dataGridTurmas.Rows.Add(turma.CodTurma, turma.Descricao, turma.Periodo);
                        cont++;
                    }
                    codTurmas = new int[cont];
                    cont = 0;
                    foreach(DataGridViewRow dataRow in dataGridTurmas.Rows)
                    {
                        codTurmas[cont] = (int)dataRow.Cells["clnCodTurma"].Value;
                        cont++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Mostra o conteudo da textbox
        private void txtCurso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toolExibe(txtCurso, txtCurso.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro de turma para adicionar uma turma
        private void btnTurmaAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteTurma frmCadTurma = new FrmPonteTurma(this);
                if(frmCadTurma.ShowDialog() == DialogResult.OK)
                {
                    bool resultado = true;
                    foreach (DataGridViewRow dataRow in dataGridTurmas.Rows)
                    {
                        if (Turma.Descricao == dataRow.Cells["clnTurma"].Value.ToString())
                        {
                            resultado = false;
                        }
                    }
                    if(resultado)
                    {
                        dataGridTurmas.Rows.Add(0, Turma.Descricao, Turma.Periodo);
                    }
                    else
                    {
                        MessageBox.Show(this, "Turma ja selecionada para este curso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Remove a turma selecionada do curso
        private void btnTurmaRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridTurmas.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Selecione uma turma.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dataGridTurmas.Rows.Remove(dataGridTurmas.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
