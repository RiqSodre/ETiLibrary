using BLL;
using DTO.Midia;
using Interface.Formularios.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadCdDvd : FrmCadBase
    {
        AreaBLL areaBLL = new AreaBLL();
        MidiaBLL midiaBLL = new MidiaBLL();
        private CD_DVD cdvdBase = new CD_DVD();
        public CD_DVD CD_DVD
        {
            get
            {
                return cdvdBase;
            }

            set
            {
                cdvdBase = value;
            }
        }
        private string resultado;

        //Construtor Padrão
        public FrmCadCdDvd()
        {
            try
            {
                InitializeComponent();
                cbArea.DataSource = areaBLL.CarregaAreas();
                Habilita(true);
                LimparComponentes();
                cbLingua.SelectedIndex = 42;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Construtor carregando cadastro do CD / DVD no form
        public FrmCadCdDvd(CD_DVD cdvd)
        {
            try
            {
                CarregaCampos(cdvd);
                txtTitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão de ação do form Salvar/Alterar/Excluir
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAcao.Text.Equals("Salvar") || btnAcao.Text.Equals("Alterar"))
                {
                    //Validações campo Titulo
                    if (txtTitulo.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Titulo é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    if (txtTitulo.Text.Length < 6)
                    {
                        MessageBox.Show(this, "O titulo deve conter no minimo seis digitos", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        CD_DVD.Titulo = txtTitulo.Text;
                    }
                    //Campo Lingua
                    CD_DVD.Lingua = cbLingua.Text;
                    //Validações Localização
                    if (txtLocalizacao.Text.Length != 0)
                    {
                        if (txtLocalizacao.Text.Length < 4)
                        {
                            MessageBox.Show(this, "O campo Localização deve conter no minimo quatro digitor", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        CD_DVD.Localizacao = txtLocalizacao.Text;
                    }
                    else
                    {
                        CD_DVD.Localizacao = "";
                    }
                    //Validações Área
                    if ((int)cbArea.SelectedValue < 0)
                    {
                        MessageBox.Show(this, "Selecione uma area da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        CD_DVD.Area.CodArea = (int)cbArea.SelectedValue;
                    }
                    if(cbTipoTombo.Text == "")
                    {
                        MessageBox.Show(this, "Selecione um tipo de tombo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        CD_DVD.TipoTombo = cbTipoTombo.Text;
                    }
                    //CheckBox Disponivel
                    CD_DVD.Disponivel = checkDisponivel.Checked;
                    //Campo Observação
                    CD_DVD.Observacao = txtObservacao.Text;
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = midiaBLL.CDVDInserir(CD_DVD);
                        MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                        if (resultado.Contains("sucesso"))
                        {
                            Habilita(false);
                            LimparComponentes();
                        }
                    }
                    else
                    {
                        resultado = midiaBLL.CDVDAlterar(CD_DVD);
                        MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                        if (resultado.Contains("sucesso"))
                        {
                            Habilita(false);
                            LimparComponentes();
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este CD/DVD?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = midiaBLL.MidiaExcluir(CD_DVD.CodMidia, "CD_DVD");
                        MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                        if (resultado.Contains("sucesso"))
                        {
                            Habilita(false);
                            LimparComponentes();
                        }
                    }
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
                Habilita(true);
                LimparComponentes();
                cbLingua.SelectedIndex = 42;
                txtTitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Abre o form ponte de aluno e carrega o aluno no form
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteCdDvd ponteCdvd = new FrmPonteCdDvd(this, "Alterar");
                if(ponteCdvd.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(CD_DVD);
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    txtTitulo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Abre o form ponte de aluno e carrega o aluno no form
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteCdDvd ponteCdvd = new FrmPonteCdDvd(this, "Excluir");
                if (ponteCdvd.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(CD_DVD);
                    btnAcao.Text = "Excluir";
                    Habilita(true);
                    btnAcao.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Carrega o cadastro do CD ou DVD no form
        private void CarregaCampos(CD_DVD cdvd)
        {
            try
            {
                txtTitulo.Text = cdvd.Titulo;
                txtTombo.Text = cdvd.Tombo.ToString();
                txtLocalizacao.Text = cdvd.Localizacao;
                cbLingua.SelectedItem = cdvd.Lingua;
                cbTipoTombo.SelectedItem = cdvd.TipoTombo;
                cbArea.SelectedValue = cdvd.Area.CodArea;
                txtObservacao.Text = cdvd.Observacao;
                if(cdvd.Disponivel)
                {
                    checkDisponivel.Checked = true;
                }
                else
                {
                    checkDisponivel.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Aumenta o tamanho do Campo Observação
        private void txtObservacao_Click(object sender, EventArgs e)
        {
            txtObservacao.Height = 75;
            pnlPrincipal.Height = 324;
            this.Height = 395;
            btnAcao.Location = new Point(149, 353);
            btnCancelar.Location = new Point(241, 353);
        }
        //Retorna o tamanho do Campo Observação ao original
        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            if (txtObservacao.Text == "" || txtObservacao.Text == null)
            {
                txtObservacao.Height = 25;
                pnlPrincipal.Height = 274;
                this.Height = 345;
                btnAcao.Location = new Point(149, 303);
                btnCancelar.Location = new Point(241, 303);
            }
        }
    }
}
