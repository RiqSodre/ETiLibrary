using BLL;
using DTO.Infraestrutura_de_Midia;
using Interface.Formularios.Modelos;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros.Infraestrutura
{
    public partial class FrmCadRevista : FrmCadBase
    {
        private RevistaBLL revistaBLL = new RevistaBLL();
        private EditoraBLL editoraBLL = new EditoraBLL();
        private Revista revistaBase = new Revista();

        //Construtor padrão
        public FrmCadRevista()
        {
            try
            {
                InitializeComponent();
                LimparComponentes();
                Habilita(false);
                cbRevista.Enabled = true;
                CarregaCampos();
                cbRevista.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Construtor carregando a revista
        public FrmCadRevista(Revista revista) : this()
        {
            try
            {
                cbRevista.Text = revista.Nome;
                cbEditora.Text = revista.Editora.Nome;
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
                    if (txtRevista.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Revista é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtRevista.Text.Length < 3)
                    {
                        MessageBox.Show(this, "O campo Revista deve conter no minimo 3 caracteres.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        revistaBase.Nome = txtRevista.Text;
                    }
                    //Validações campo Editora
                    revistaBase.Editora = editoraBLL.CarregaEditora(cbEditora.Text);
                    if (revistaBase.Editora.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione uma editora da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = revistaBLL.RevistaInserir(revistaBase);
                    }
                    else
                    {
                        resultado = revistaBLL.RevistaAlterar(revistaBase);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir esta revista?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = revistaBLL.RevistaExcluir(revistaBase.CodRevista);
                    }
                }
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    CarregaCampos();
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
                cbRevista.Text = "";
                cbRevista.Enabled = false;
                txtRevista.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Habilita a edição da revista
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione uma revista.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    revistaBase = revistaBLL.CarregarRevista(cbRevista.Text);
                    if (revistaBase.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione uma revista da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    cbRevista.Enabled = false;
                    txtRevista.Text = cbRevista.Text;
                    cbEditora.Text = revistaBase.Editora.Nome;
                    txtRevista.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Habilita a exclusão da revista
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione uma revista.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    revistaBase = revistaBLL.CarregarRevista(cbRevista.Text);
                    if (revistaBase.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione uma revista da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Excluir";
                    Habilita(false);
                    txtRevista.Text = cbRevista.Text;
                    cbEditora.Text = revistaBase.Editora.Nome;
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
                cbRevista.Enabled = true;
                cbRevista.Text = "Digite a revista";
                cbEditora.Text = "Digite a editora";
                cbRevista.Focus();
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
        //Cria o autocomplete das combobox
        private void CarregaCampos()
        {
            //Cria o autocomplete das combobox Editora
            AutoCompleteStringCollection dicEditora = new AutoCompleteStringCollection();
            foreach (Editora editora in editoraBLL.CarregaEditoras())
            {
                dicEditora.Add(editora.Nome);
            }
            cbEditora.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEditora.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEditora.AutoCompleteCustomSource = dicEditora;
            //Cria o autocomplete das combobox Revista
            AutoCompleteStringCollection dicRevista = new AutoCompleteStringCollection();
            foreach (Revista revista in revistaBLL.CarregarRevistas())
            {
                dicRevista.Add(revista.Nome);
            }
            cbRevista.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbRevista.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbRevista.AutoCompleteCustomSource = dicRevista;
        }
    }
}
