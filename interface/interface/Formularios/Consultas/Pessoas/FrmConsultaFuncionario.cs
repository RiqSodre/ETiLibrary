using System;
using System.Windows.Forms;
using Interface.Formularios.Modelos;
using DTO.Pessoas;
using BLL;
using Interface.Properties;
using Interface.Formularios.Cadastros;

namespace Interface.Formularios.Consultas
{
    public partial class FrmConsultaFuncionario : FrmConsultaBase
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private string numero;
        private string telefoneTipo;

        //Carrega Resultado no datagrid
        public FrmConsultaFuncionario(FuncionariosList funcionarioList)
        {
            try
            {
                InitializeComponent();
                foreach(Funcionario func in funcionarioList)
                {
                    if (func.Telefone.Numero == null)
                    {
                        numero = func.Celular.Numero;
                        telefoneTipo = func.Celular.TelefoneTipo;
                    }
                    else
                    {
                        numero = func.Telefone.Numero;
                        telefoneTipo = func.Telefone.TelefoneTipo;
                    }
                    dataGridFuncionarios.Rows.Add(func.CodPessoa, func.Nome, func.Sexo, func.Cpf,
                    func.CodCargo, func.Cargo, numero, telefoneTipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                Close();
            }
        }
        //Botão que seleciona o funcionário
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario func = new Funcionario();
                if (dataGridFuncionarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhum funcionário selecionado.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }
                if((int)dataGridFuncionarios.CurrentRow.Cells["clnCodCargo"].Value == 3)
                {
                    if(Settings.Default.Admin == false)
                    {
                        MessageBox.Show(this, "Somente o administrador tem acesso a este cadastro.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    func = pessoaBLL.FuncionarioBiblioSelect((int)dataGridFuncionarios.CurrentRow.Cells["clnCodFuncionario"].Value);
                    if (func.Celular.Numero == null)
                    {
                        func.Celular = pessoaBLL.PessoaTelefone(func.CodPessoa);
                    }
                    else
                    {
                        func.Telefone = pessoaBLL.PessoaTelefone(func.CodPessoa);
                    }
                    FrmCadFuncionarioBiblioteca frmCadFunc = new FrmCadFuncionarioBiblioteca(func);
                    frmCadFunc.MdiParent = this.MdiParent;
                    frmCadFunc.Show();
                }
                else
                {
                    func.CodPessoa = (int)dataGridFuncionarios.CurrentRow.Cells["clnCodFuncionario"].Value;
                    func.Nome = (string)dataGridFuncionarios.CurrentRow.Cells["clnNome"].Value;
                    func.Sexo = (string)dataGridFuncionarios.CurrentRow.Cells["clnSexo"].Value;
                    func.Cpf = (string)dataGridFuncionarios.CurrentRow.Cells["clnCPF"].Value;
                    func.Cargo = (string)dataGridFuncionarios.CurrentRow.Cells["clnCargo"].Value;
                    func.CodCargo = (int)dataGridFuncionarios.CurrentRow.Cells["clnCodCargo"].Value;
                    if (((string)dataGridFuncionarios.CurrentRow.Cells["clnTelefoneTipo"].Value).Equals("Telefone"))
                    {
                        func.Telefone.Numero = (string)dataGridFuncionarios.CurrentRow.Cells["clnTelefone"].Value;
                        func.Celular = pessoaBLL.PessoaTelefone(func.CodPessoa);
                    }
                    else
                    {
                        func.Celular.Numero = (string)dataGridFuncionarios.CurrentRow.Cells["clnTelefone"].Value;
                        func.Telefone = pessoaBLL.PessoaTelefone(func.CodPessoa);
                    }
                    FrmCadFuncionario frmCadFunc = new FrmCadFuncionario(func);
                    frmCadFunc.MdiParent = this.MdiParent;
                    frmCadFunc.Show();
                }
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
