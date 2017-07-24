using BLL;
using DTO.Infraestrutura_de_Midia;
using Interface.Formularios.Modelos;
using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros.Infraestrutura
{
    public partial class FrmCadAutor : FrmCadBase
    {
        private AutorBLL autorBLL = new AutorBLL();

        //Construtor padrão
        public FrmCadAutor()
        {
            try
            {
                InitializeComponent();
                LimparComponentes();
                Habilita(false);
                cbAutor.Enabled = true;
                CarregaAutores();
                cbAutor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Construtor carregando o autor
        public FrmCadAutor(Autor autor) : this()
        {
            try
            {
                cbAutor.Text = autor.Nome;
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
                Autor autor = new Autor();
                if(cbAutor.Text != "")
                {
                    autor = autorBLL.CarregaAutor(cbAutor.Text);
                }
                if (btnAcao.Text.Equals("Salvar") || btnAcao.Text.Equals("Alterar"))
                {
                    //Validações campo Nome
                    if (txtNome.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Nome é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNome.Text.Length < 3)
                    {
                        MessageBox.Show(this, "O campo Nome deve conter no minimo 3 caracteres.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        autor.Nome = txtNome.Text;
                    }
                    //Validações Sobrenome
                    if (txtSobrenome.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Sobrenome é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtSobrenome.Text.Length < 3)
                    {
                        MessageBox.Show(this, "O campo Sobrenome deve conter no minimo 3 caracteres.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        autor.Sobrenome = txtSobrenome.Text;
                    }
                    //Validações Notação
                    if (txtNotacao.Text.Length != 0)
                    {
                        if (txtNotacao.Text.Length < 3)
                        {
                            MessageBox.Show(this, "O campo Notação deve conter no minimo 3 caracteres.", "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                            return;
                        }
                        autor.NotacaoAutor = txtNotacao.Text;
                    }
                    else
                    {
                        autor.NotacaoAutor = "N/I";
                    }
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = autorBLL.AutorInserir(autor);
                    }
                    else
                    {
                        resultado = autorBLL.AutorAlterar(autor);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este autor?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = autorBLL.AutorExcluir(autor.CodAutor);
                    }
                }
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    CarregaAutores();
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
                cbAutor.Text = "";
                cbAutor.Enabled = false;
                txtNome.Focus();
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
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione um autor.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Autor autor = autorBLL.CarregaAutor(cbAutor.Text);
                    if (autor.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um autor da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    cbAutor.Enabled = false;
                    txtNome.Text = autor.Nome.Substring(autor.Nome.IndexOf(",")+2);
                    txtSobrenome.Text = autor.Nome.Substring(0, autor.Nome.IndexOf(",")-1);
                    txtNotacao.Text = autor.NotacaoAutor;
                    txtNome.Focus();
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
                    MessageBox.Show(this, "Selecione um autor.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Autor autor = autorBLL.CarregaAutor(cbAutor.Text);
                    if (autor.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um autor da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Excluir";
                    Habilita(false);
                    txtNome.Text = autor.Nome.Substring(autor.Nome.IndexOf(",") + 2);
                    txtSobrenome.Text = autor.Nome.Substring(0, autor.Nome.IndexOf(",") - 1);
                    txtNotacao.Text = autor.NotacaoAutor;
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
                cbAutor.Enabled = true;
                cbAutor.Text = "Digite o nome do autor";
                cbAutor.Focus();
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
                if (sender is MetroTextBox)
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
        //Cria o autocomplete da combobox Autores
        public void CarregaAutores()
        {
            AutoCompleteStringCollection dicAutor = new AutoCompleteStringCollection();
            foreach (Autor autor in autorBLL.CarregaAutores())
            {
                dicAutor.Add(autor.Nome);
            }
            cbAutor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAutor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbAutor.AutoCompleteCustomSource = dicAutor;
        }
    }
}
