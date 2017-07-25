using BLL;
using DTO.Infraestrutura_de_Midia;
using Interface.Formularios.Modelos;
using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros.Infraestrutura
{
    public partial class FrmCadJornal : FrmCadBase
    {
        private JornalBLL jornalBLL = new JornalBLL();
        private Jornal jornalBase = new Jornal();

        //Construtor padrão
        public FrmCadJornal()
        {
            try
            {
                InitializeComponent();
                LimparComponentes();
                Habilita(false);
                cbJornal.Enabled = true;
                CarregaJornais();
                cbJornal.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Construtor carregando o jornal
        public FrmCadJornal(Jornal jornal) : this()
        {
            try
            {
                cbJornal.Text = jornal.Nome;
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
                    //Validações campo Jornal
                    if (txtJornal.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Jornal é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtJornal.Text.Length < 3)
                    {
                        MessageBox.Show(this, "O campo Jornal deve conter no minimo 3 caracteres.", "Atenção", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                        return;
                    }
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = jornalBLL.JornalInserir(txtJornal.Text);
                    }
                    else
                    {
                        jornalBase.Nome = txtJornal.Text;
                        resultado = jornalBLL.JornalAlterar(jornalBase);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este jornal?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = jornalBLL.JornalExcluir(jornalBase.CodJornal);
                    }
                }
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    CarregaJornais();
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
                cbJornal.Text = "";
                cbJornal.Enabled = false;
                txtJornal.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Habilita a edição do jornal
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione um jornal.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    jornalBase = jornalBLL.CarregaJornal(cbJornal.Text);
                    if (jornalBase.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um jornal da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    cbJornal.Enabled = false;
                    txtJornal.Text = cbJornal.Text;
                    txtJornal.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Habilita a exclusão do jornal
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                    MessageBox.Show(this, "Selecione um jornal.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    jornalBase = jornalBLL.CarregaJornal(cbJornal.Text);
                    if (jornalBase.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um jornal da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnAcao.Text = "Excluir";
                    Habilita(false);
                    txtJornal.Text = cbJornal.Text;
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
                cbJornal.Enabled = true;
                cbJornal.Text = "Digite um jornal";
                cbJornal.Focus();
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
        //Cria o autocomplete da combobox Jornal
        private void CarregaJornais()
        {
            AutoCompleteStringCollection dicJornal = new AutoCompleteStringCollection();
            foreach (Jornal jornal in jornalBLL.CarregaJornais())
            {
                dicJornal.Add(jornal.Nome);
            }
            cbJornal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbJornal.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbJornal.AutoCompleteCustomSource = dicJornal;
        }
    }
}
