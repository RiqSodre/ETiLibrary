using BLL;
using DTO.Midia;
using Interface.Formularios.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadTCC : FrmCadBase
    {
        private AreaBLL areaBLL = new AreaBLL();
        private MidiaBLL midiaBLL = new MidiaBLL();
        private CursoBLL cursoBLL = new CursoBLL();
        private Tcc tccBase = new Tcc();
        public Tcc Tcc
        {
            get
            {
                return tccBase;
            }

            set
            {
                tccBase = value;
            }
        }

        //Construtor  padrão
        public FrmCadTCC()
        {
            try
            {
                InitializeComponent();
                txtObs.GotFocus += txtObservacao_Focus;
                cbArea.DataSource = areaBLL.CarregaAreas();
                cbCurso.DataSource = cursoBLL.CarregaCursos();
                Habilita(true);
                LimparComponentes();
                cbLingua.SelectedIndex = 42;
                cbTipoTombo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Construtor carregando cadastro do CD / DVD no form
        public FrmCadTCC(Tcc tcc)
        {
            try
            {
                CarregaCampos(tcc);
                txtTitulo.Focus();
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
                    //Validações campo Titulo
                    if (txtTitulo.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Título é obrigatório.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtTitulo.Text.Length < 6)
                    {
                        MessageBox.Show(this, "O campo Título deve conter no mínimo seis digitos.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Tcc.Titulo = txtTitulo.Text;
                    }
                    //Validações campo Data de Pulicação
                    if (dtDataPublicacao.Value > DateTime.Now)
                    {
                        MessageBox.Show(this, "Informe uma data válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Tcc.DataPublicacao = dtDataPublicacao.Value;
                    }
                    //Campo Lingua
                    Tcc.Lingua = cbLingua.Text;
                    //Validações campo Localização
                    if (txtLocaliza.Text.Length != 0)
                    {
                        if (txtLocaliza.Text.Length < 4)
                        {
                            MessageBox.Show(this, "O campo Localização deve conter no mínimo quatro digitos.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        Tcc.Localizacao = txtLocaliza.Text;
                    }
                    else
                    {
                        Tcc.Localizacao = "";
                    }
                    //Validações campo Área
                    if ((int)cbArea.SelectedValue < 0)
                    {
                        MessageBox.Show(this, "Selecione uma área da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Tcc.Area.CodArea = (int)cbArea.SelectedValue;
                    }
                    //Validações campo Jornal
                    if ((int)cbCurso.SelectedValue < 0)
                    {
                        MessageBox.Show(this, "Selecione um curso da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Tcc.Curso.CodCurso = (int)cbCurso.SelectedValue;
                    }
                    //Campo Observação
                    Tcc.Observacao = txtObs.Text;
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = midiaBLL.TCCInserir(Tcc);
                    }
                    else
                    {
                        resultado = midiaBLL.TCCAlterar(Tcc);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este TCC?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = midiaBLL.MidiaExcluir(Tcc.Tombo, "TCC");
                    }
                }
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    Habilita(false);
                    LimparComponentes();
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
                cbTipoTombo.SelectedIndex = 0;
                txtTitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Abre o form ponte de Jornal e carrega o exemplar no form
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteTCC pontetcc = new FrmPonteTCC(this, "Alterar");
                if (pontetcc.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(Tcc);
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
        //Botão Excluir - Abre o form ponte de Jornal e carrega o exemplar no form
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteTCC pontetcc = new FrmPonteTCC(this, "Excluir");
                if (pontetcc.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(Tcc);
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
        //Carrega o cadastro do TCC no form
        private void CarregaCampos(Tcc tcc)
        {
            txtTitulo.Text = tcc.Titulo;
            txtTombo.Text = tcc.Tombo.ToString();
            txtLocaliza.Text = tcc.Localizacao;
            cbLingua.SelectedItem = tcc.Lingua;
            cbArea.SelectedValue = tcc.Area.CodArea;
            cbTipoTombo.SelectedIndex = 0;
            cbCurso.SelectedValue = tcc.Curso.CodCurso;
            txtObs.Text = tcc.Observacao;
            toolExibe(txtTitulo, txtTitulo.Text);
        }
        //Mostra o conteúdo da combobox
        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                toolExibe(cbArea, cbArea.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Mostra o conteúdo da combobox
        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                toolExibe(cbCurso, cbCurso.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Aumenta o tamanho do campo Observação
        private void txtObservacao_Focus(object sender, EventArgs e)
        {
            txtObs.Height = 75;
            pnlPrincipal.Height = 424;
            this.Height = 495;
            btnAcao.Location = new Point(149, 453);
            btnCancelar.Location = new Point(241, 453);
        }
        //Retorna o tamanho do campo Observação ao original
        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            if (txtObs.Text == "" || txtObs.Text == null)
            {
                txtObs.Height = 25;
                pnlPrincipal.Height = 374;
                this.Height = 445;
                btnAcao.Location = new Point(149, 403);
                btnCancelar.Location = new Point(241, 403);
            }
        }
    }
}
