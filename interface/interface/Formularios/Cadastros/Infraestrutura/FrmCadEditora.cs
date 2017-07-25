using BLL;
using DTO.Infraestrutura_de_Midia;
using Interface.Formularios.Modelos;
using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros.Infraestrutura
{
    public partial class FrmCadEditora : FrmCadBase
    {
        private EditoraBLL editoraBLL = new EditoraBLL();
        private Editora editoraBase = new Editora();

        //Construtor padrão
        public FrmCadEditora()
        {
            try
            {
                InitializeComponent();
                LimparComponentes();
                Habilita(false);
                cbEditora.Enabled = true;
                CarregaEditoras();
                cbEditora.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Construtor carregando a editora
        public FrmCadEditora(Editora editora) : this()
        {
            try
            {
                cbEditora.Text = editora.Nome;
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
                if (btnAcao.Text.Equals("Salvar") || btnAcao.Text.Equals("Alterar"))
                {
                    //Validações campo Editora
                    if (txtEditora.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Editora é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtEditora.Text.Length < 4)
                    {
                        MessageBox.Show(this, "O campo Editora deve conter no minimo 4 caracteres.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = editoraBLL.EditoraInserir(txtEditora.Text);
                    }
                    else
                    {
                        editoraBase.Nome = txtEditora.Text;
                        resultado = editoraBLL.EditoraAlterar(editoraBase);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir esta Editora?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = editoraBLL.EditoraExcluir(editoraBase.CodEditora);
                    }
                }
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    CarregaEditoras();
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
                cbEditora.Text = "";
                cbEditora.Enabled = false;
                txtEditora.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Habilita a edição da editora
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione uma editora.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    editoraBase = editoraBLL.CarregaEditora(cbEditora.Text);
                    if (editoraBase.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione uma editora da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    cbEditora.Enabled = false;
                    txtEditora.Text = cbEditora.Text;
                    txtEditora.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Habilita a exclusão da editora
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione uma editora.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    editoraBase = editoraBLL.CarregaEditora(cbEditora.Text);
                    if (editoraBase.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione uma editora da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Excluir";
                    Habilita(false);
                    txtEditora.Text = cbEditora.Text;
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
                cbEditora.Enabled = true;
                cbEditora.Text = "Digite uma editora";
                cbEditora.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Mostra o conteúdo em uma toolTip
        private void exibe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(sender is MetroTextBox)
                {
                    toolExibe((sender as MetroTextBox), (sender as MetroTextBox).Text);
                }
                else
                {
                    toolExibe((sender as ComboBox), (sender as ComboBox).Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Cria o autocomplete da combobox Editora
        private void CarregaEditoras()
        {
            AutoCompleteStringCollection dicEditora = new AutoCompleteStringCollection();
            foreach (Editora editora in editoraBLL.CarregaEditoras())
            {
                dicEditora.Add(editora.Nome);
            }
            cbEditora.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEditora.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEditora.AutoCompleteCustomSource = dicEditora;
        }
    }
}
