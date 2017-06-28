using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.Formularios.Modelos;
using DTO.Pessoas;
using Interface.Formularios.Cadastros;

namespace Interface.Formularios.Consultas
{
    public partial class FrmConsultaAluno : FrmConsultaBase
    {
        public FrmConsultaAluno()
        {
            InitializeComponent();
        }
        
        //Carrega Resultado no datagrid
        public FrmConsultaAluno(AlunoList alunoList)
        {
            try
            {
                InitializeComponent();

                foreach (Aluno aluno in alunoList)
                {
                    string numero;
                    string telefoneTipo;

                    if (aluno.Telefone.Numero.Equals(""))
                    {
                        numero = aluno.Celular.Numero;
                        telefoneTipo = aluno.Celular.TelefoneTipo;
                    }
                    else
                    {
                        numero = aluno.Telefone.Numero;
                        telefoneTipo = aluno.Telefone.TelefoneTipo;
                    }
                    dataGridAlunos.Rows.Add(aluno.CodPessoa, aluno.Nome, aluno.Sexo, aluno.Cpf, aluno.Rm,
                    aluno.DataCadastro, aluno.Turma.Curso.CodCurso, aluno.Turma.Curso.Descricao, aluno.Turma.CodTurma,
                    aluno.Turma.Periodo, numero, telefoneTipo);
                }
                dataGridAlunos.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão Fechar
        private void btnFechar2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAlunos.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhum aluno selecionado.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                Aluno aluno = new Aluno();

                aluno.CodPessoa = (int)dataGridAlunos.CurrentRow.Cells["clnCodAluno"].Value;
                aluno.Nome = (string)dataGridAlunos.CurrentRow.Cells["clnNome"].Value;
                aluno.Sexo = (string)dataGridAlunos.CurrentRow.Cells["clnSexo"].Value;
                aluno.Cpf = (string)dataGridAlunos.CurrentRow.Cells["clnCPF"].Value;
                aluno.Rm = (string)dataGridAlunos.CurrentRow.Cells["clnRM"].Value;
                aluno.DataCadastro = (DateTime)dataGridAlunos.CurrentRow.Cells["clnDataCadastro"].Value;
                aluno.Turma.Curso.CodCurso = (int)dataGridAlunos.CurrentRow.Cells["clnCodCurso"].Value;
                aluno.Turma.Curso.Descricao = (string)dataGridAlunos.CurrentRow.Cells["clnCurso"].Value;
                aluno.Turma.CodTurma = (int)dataGridAlunos.CurrentRow.Cells["clnCodTurma"].Value;
                aluno.Turma.Periodo = (string)dataGridAlunos.CurrentRow.Cells["clnPeriodo"].Value;
                aluno.Telefone.Numero = (string)dataGridAlunos.CurrentRow.Cells["clnTelefone"].Value;
                aluno.Telefone.TelefoneTipo = (string)dataGridAlunos.CurrentRow.Cells["clnTelefoneTipo"].Value;

                FrmCadAluno frmCadAluno = new FrmCadAluno(aluno);
                frmCadAluno.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
