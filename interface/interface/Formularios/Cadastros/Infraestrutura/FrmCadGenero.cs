using BLL;
using DTO.Infraestrutura_de_Midia;
using Interface.Formularios.Modelos;
using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros.Infraestrutura
{
    public partial class FrmCadGenero : FrmCadBase
    {
        private GeneroBLL generoBLL = new GeneroBLL();
        private Genero generoBase = new Genero();

        //Construtor padrao
        public FrmCadGenero()
        {
            try
            {
                InitializeComponent();
                LimparComponentes();
                Habilita(false);
                cbGenero.Enabled = true;
                CarregaGeneros();
                cbGenero.Focus();
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
                    if (txtGenero.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Gênero é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtGenero.Text.Length < 4)
                    {
                        MessageBox.Show(this, "O campo Gênero deve conter no mínimo 4 caracteres.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = generoBLL.GeneroInserir(txtGenero.Text);
                    }
                    else
                    {
                        generoBase.Descricao = txtGenero.Text;
                        resultado = generoBLL.GeneroAlterar(generoBase);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este gênero?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = generoBLL.GeneroExcluir(generoBase.CodGenero);
                    }
                }
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    CarregaGeneros();
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
                cbGenero.Text = "";
                cbGenero.Enabled = false;
                txtGenero.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Habilita a edição do genero
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione um gênero.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    generoBase = generoBLL.CarregaGenero(cbGenero.Text);
                    if (generoBase.Descricao.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um gênero da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    cbGenero.Enabled = false;
                    txtGenero.Text = cbGenero.Text;
                    txtGenero.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Habilita a exclusão do genero
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione um gênero.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    generoBase = generoBLL.CarregaGenero(cbGenero.Text);
                    if (generoBase.Descricao.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um gênero da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Excluir";
                    Habilita(false);
                    txtGenero.Text = cbGenero.Text;
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
                cbGenero.Enabled = true;
                cbGenero.Text = "DIGITE O GENÊRO";
                cbGenero.Focus();
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
        //Cria o autocomplete da combobox Gêneros
        private void CarregaGeneros()
        {
            AutoCompleteStringCollection dicGenero = new AutoCompleteStringCollection();
            foreach (Genero genero in generoBLL.CarregaGeneros())
            {
                dicGenero.Add(genero.Descricao);
            }
            cbGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbGenero.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbGenero.AutoCompleteCustomSource = dicGenero;
        }
        //Retorna o texto para maiusculo
        private void cbGenero_Leave(object sender, EventArgs e)
        {
            try
            {
                cbGenero.Text = cbGenero.Text.ToUpper();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
