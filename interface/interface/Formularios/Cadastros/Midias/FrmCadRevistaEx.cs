using BLL;
using DTO.Emprestimos;
using DTO.Midia;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadRevistaEx : Interface.Formularios.Modelos.FrmCadBase
    {
        private AreaBLL areaBLL = new AreaBLL();
        private MidiaBLL midiaBLL = new MidiaBLL();
        private RevistaBLL revistaBLL = new RevistaBLL();
        private RevistaEx revistaExBase = new RevistaEx();
        public RevistaEx RevistaEx
        {
            get
            {
                return revistaExBase;
            }

            set
            {
                revistaExBase = value;
            }
        }

        //Construtor padrão
        public FrmCadRevistaEx()
        {
            try
            {
                InitializeComponent();
                txtObs.GotFocus += txtObservacao_Focus;
                cbArea.DataSource = areaBLL.CarregaAreas();
                cbRevista.DataSource = revistaBLL.CarregarRevistas();
                Habilita(true);
                LimparComponentes();
                cbLingua.SelectedIndex = 42;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Construtor carregando cadastro da Revista no form
        public FrmCadRevistaEx(RevistaEx revista) : this()
        {
            try
            {
                CarregaCampos(revista);
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
                        RevistaEx.Titulo = txtTitulo.Text;
                    }
                    //Campo Edição
                    if(!txtEdicao.Text.Equals(""))
                    {
                        RevistaEx.Edicao = txtEdicao.Text;
                    }
                    else
                    {
                        RevistaEx.Edicao = "";
                    }
                    //Campo Lingua
                    RevistaEx.Lingua = cbLingua.Text;
                    //Validações campo Localização
                    if (txtLocaliza.Text.Length != 0)
                    {
                        if (txtLocaliza.Text.Length < 4)
                        {
                            MessageBox.Show(this, "O campo Localização deve conter no mínimo quatro digitos", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        RevistaEx.Localizacao = txtLocaliza.Text;
                    }
                    else
                    {
                        RevistaEx.Localizacao = "";
                    }
                    //Validações campo Área
                    if ((int)cbArea.SelectedValue < 0)
                    {
                        MessageBox.Show(this, "Selecione uma área da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        RevistaEx.Area.CodArea = (int)cbArea.SelectedValue;
                    }
                    //Validações campo Tipo Tombo
                    if (cbTipoTombo.Text == "")
                    {
                        MessageBox.Show(this, "Selecione um tipo de tombo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        RevistaEx.TipoTombo = cbTipoTombo.Text;
                    }
                    //CheckBox Disponivel
                    if (btnAcao.Text.Equals("Alterar"))
                    {
                        if (RevistaEx.Disponivel != checkDisp.Checked)
                        {
                            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
                            EmprestimoList emprestimoList = emprestimoBLL.EmprestimoConsultar_PorTombo(RevistaEx.Tombo, "Revista");
                            foreach (Emprestimo emprestimo in emprestimoList)
                            {
                                if (emprestimo.Fechado == false)
                                {
                                    MidiaEmprestimoList midiaEmprestimoList = emprestimoBLL.EmprestimoMidiaConsultar_PorCodEmprestimo(emprestimo.CodEmprestimo);
                                    foreach (MidiaEmprestimo midia in midiaEmprestimoList)
                                    {
                                        if (midia.CodMidia == RevistaEx.CodMidia && midia.Devolvido == false)
                                        {
                                            if (MessageBox.Show(this, "Esta Revista encontra-se emprestado, por isso não é possivel alterar sua disponibilidade." +
                                                "Deseja abrir a paginá do empréstimo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                            {
                                                FrmCadEmprestimo frmCadEmprestimo = new FrmCadEmprestimo(emprestimo);
                                                frmCadEmprestimo.MdiParent = this.MdiParent;
                                                frmCadEmprestimo.Show();
                                            }
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    RevistaEx.Disponivel = checkDisp.Checked;
                    //Validações campo Jornal
                    if ((int)cbRevista.SelectedValue < 0)
                    {
                        MessageBox.Show(this, "Selecione uma Revista da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        RevistaEx.Revista_.CodRevista = (int)cbRevista.SelectedValue;
                    }
                    //Campo Observação
                    RevistaEx.Observacao = txtObs.Text;
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = midiaBLL.RevistaInserir(RevistaEx);
                    }
                    else
                    {
                        resultado = midiaBLL.RevistaAlterar(RevistaEx);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir esta Revista?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = midiaBLL.MidiaExcluir(RevistaEx.Tombo, "Revista");
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
                FrmPonteRevistaEx ponteRevistaEx = new FrmPonteRevistaEx(this, "Alterar");
                if (ponteRevistaEx.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(RevistaEx);
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
                FrmPonteRevistaEx ponteRevistaEx = new FrmPonteRevistaEx(this, "Excluir");
                if (ponteRevistaEx.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(RevistaEx);
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
        //Carrega o cadastro do Jornal no form
        private void CarregaCampos(RevistaEx revista)
        {
            txtTitulo.Text = revista.Titulo;
            txtEdicao.Text = revista.Edicao;
            txtTombo.Text = revista.Tombo.ToString();
            txtLocaliza.Text = revista.Localizacao;
            cbLingua.SelectedItem = revista.Lingua;
            cbTipoTombo.SelectedItem = revista.TipoTombo;
            cbArea.SelectedValue = revista.Area.CodArea;
            cbRevista.SelectedValue = revista.Revista_.CodRevista;
            txtObs.Text = revista.Observacao;
            if (revista.Disponivel)
            {
                checkDisp.Checked = true;
            }
            else
            {
                checkDisp.Checked = false;
            }
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
        private void cbRevista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                toolExibe(cbRevista, cbRevista.Text);
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
