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
        private Autor autorBase = new Autor();

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
                        autorBase.Nome = txtNome.Text;
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
                        autorBase.Sobrenome = txtSobrenome.Text;
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
                        autorBase.NotacaoAutor = txtNotacao.Text;
                    }
                    else
                    {
                        autorBase.NotacaoAutor = "N/I";
                    }
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = autorBLL.AutorInserir(autorBase);
                    }
                    else
                    {
                        resultado = autorBLL.AutorAlterar(autorBase);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este autor?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = autorBLL.AutorExcluir(autorBase.CodAutor);
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
        //Botão Alterar - Habilita a edição do autor
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
                    autorBase = autorBLL.CarregaAutor(cbAutor.Text);
                    if (autorBase.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um autor da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    cbAutor.Enabled = false;
                    txtNome.Text = autorBase.Nome.Substring(autorBase.Nome.IndexOf(",")+2);
                    txtSobrenome.Text = autorBase.Nome.Substring(0, autorBase.Nome.IndexOf(",")-1);
                    txtNotacao.Text = autorBase.NotacaoAutor;
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Habilita a exclusão do autor
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
                    autorBase = autorBLL.CarregaAutor(cbAutor.Text);
                    if (autorBase.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um autor da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Excluir";
                    Habilita(false);
                    txtNome.Text = autorBase.Nome.Substring(autorBase.Nome.IndexOf(",") + 2);
                    txtSobrenome.Text = autorBase.Nome.Substring(0, autorBase.Nome.IndexOf(",") - 1);
                    txtNotacao.Text = autorBase.NotacaoAutor;
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
