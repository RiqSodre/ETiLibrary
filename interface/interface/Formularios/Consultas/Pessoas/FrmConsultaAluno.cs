using System;
using System.Windows.Forms;
using Interface.Formularios.Modelos;
using DTO.Pessoas;
using Interface.Formularios.Cadastros;
using BLL;

namespace Interface.Formularios.Consultas
{
    public partial class FrmConsultaAluno : FrmConsultaBase
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private string numero;
        private string telefoneTipo;
        private string nome;

        //Carrega Resultado no datagrid
        public FrmConsultaAluno(AlunoList alunoList)
        {
            try
            {
                InitializeComponent();
                foreach (Aluno aluno in alunoList)
                {
                    if (aluno.Telefone.Numero == null)
                    {
                        numero = aluno.Celular.Numero;
                        telefoneTipo = aluno.Celular.TelefoneTipo;
                    }
                    else
                    {
                        numero = aluno.Telefone.Numero;
                        telefoneTipo = aluno.Telefone.TelefoneTipo;
                    }
                    nome = aluno.Nome;
                    CorrigeAtributos();
                    dataGridAlunos.Rows.Add(aluno.CodPessoa, nome, aluno.Sexo, aluno.Cpf, aluno.Rm,
                    aluno.DataCadastro, aluno.Turma.Curso.CodCurso, aluno.Turma.Curso.Descricao, aluno.Turma.CodTurma,
                    aluno.Turma.Periodo, numero, telefoneTipo);
                }
                dataGridAlunos.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                Close();
            }
        }
        //Botão que seleciona o aluno
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
                if(((string)dataGridAlunos.CurrentRow.Cells["clnTelefoneTipo"].Value).Equals("Telefone"))
                {
                    aluno.Telefone.Numero = (string)dataGridAlunos.CurrentRow.Cells["clnTelefone"].Value;
                    aluno.Celular = pessoaBLL.PessoaTelefone(aluno.CodPessoa);
                }
                else
                {
                    aluno.Celular.Numero = (string)dataGridAlunos.CurrentRow.Cells["clnTelefone"].Value;
                    aluno.Telefone = pessoaBLL.PessoaTelefone(aluno.CodPessoa);
                }
                FrmCadAluno frmCadAluno = new FrmCadAluno(aluno);
                frmCadAluno.MdiParent = this.MdiParent;
                frmCadAluno.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Valida os números
        private void CorrigeAtributos()
        {
            if (numero.Contains("/"))
            {
                numero = numero.Substring(0, numero.IndexOf("/"));
            }
            if(numero.StartsWith("0"))
            {
                numero = numero.Substring(1, numero.Length-1);
            }
            if (numero.StartsWith("8") || numero.StartsWith("9") ||
                 numero.StartsWith("158") || numero.StartsWith("159") ||
                  numero.StartsWith("118") || numero.StartsWith("119"))
            {
                telefoneTipo = "Celular";
            }
            //Retira o espaço do começo dos nomes
            if(nome.StartsWith(" "))
            {
                nome = nome.Substring(1, nome.Length - 1);
            }
        }
    }
}
