using BLL;
using DTO.Infraestrutura_de_Midia;
using Interface.Formularios.Modelos;
using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros.Infraestrutura
{
    public partial class FrmCadAssunto : FrmCadBase
    {
        private AssuntosBLL assuntoBLL = new AssuntosBLL();

        //Construtor padrão
        public FrmCadAssunto()
        {
            try
            {
                InitializeComponent();
                LimparComponentes();
                Habilita(false);
                cbAssunto.Enabled = true;
                CarregaAssuntos();
                cbAssunto.Focus();
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
                Assunto assunto = new Assunto();
                if(cbAssunto.Text != "")
                {
                    assunto = assuntoBLL.CarregaAssunto(cbAssunto.Text);
                }
                if (btnAcao.Text.Equals("Salvar") || btnAcao.Text.Equals("Alterar"))
                {
                    //Validações campo Assunto
                    if (txtAssunto.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Assunto é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtAssunto.Text.Length < 4)
                    {
                        MessageBox.Show(this, "O campo Assunto deve conter no minimo 4 caracteres.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = assuntoBLL.AssuntoInserir(txtAssunto.Text);
                    }
                    else
                    {
                        assunto.Descricao = txtAssunto.Text;
                        resultado = assuntoBLL.AssuntoAlterar(assunto);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este assunto?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = assuntoBLL.AssuntoExcluir(assunto.CodAssunto);
                    }
                }
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    CarregaAssuntos();
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
                cbAssunto.Text = "";
                cbAssunto.Enabled = false;
                txtAssunto.Focus();
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
                    MessageBox.Show(this, "Selecione um assunto.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Assunto assunto = assuntoBLL.CarregaAssunto(cbAssunto.Text);
                    if (assunto.Descricao.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um assunto da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    cbAssunto.Enabled = false;
                    txtAssunto.Text = cbAssunto.Text;
                    txtAssunto.Focus();
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
                    MessageBox.Show(this, "Selecione um assunto.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Assunto assunto = assuntoBLL.CarregaAssunto(cbAssunto.Text);
                    if (assunto.Descricao.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um assunto da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Excluir";
                    Habilita(false);
                    txtAssunto.Text = cbAssunto.Text;
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
                cbAssunto.Enabled = true;
                cbAssunto.Text = "Digite um assunto";
                cbAssunto.Focus();
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
        //Cria o autocomplete da combobox Assuntos
        private void CarregaAssuntos()
        {
            AutoCompleteStringCollection dicAssunto = new AutoCompleteStringCollection();
            foreach (Assunto assunto in assuntoBLL.CarregaAssuntos())
            {
                dicAssunto.Add(assunto.Descricao);
            }
            cbAssunto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAssunto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbAssunto.AutoCompleteCustomSource = dicAssunto;
        }
    }
}
