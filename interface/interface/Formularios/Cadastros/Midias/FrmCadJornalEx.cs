using System;
using System.Drawing;
using Interface.Formularios.Modelos;
using BLL;
using System.Windows.Forms;
using DTO.Midia;
using DTO.Emprestimos;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadJornalEx : FrmCadBase
    {
        private AreaBLL areaBLL = new AreaBLL();
        private MidiaBLL midiaBLL = new MidiaBLL();
        private JornalBLL jornalBLL = new JornalBLL();
        private JornalEx jornalExBase = new JornalEx();
        public JornalEx JornalEx
        {
            get
            {
                return jornalExBase;
            }

            set
            {
                jornalExBase = value;
            }
        }

        //Construtor padrão
        public FrmCadJornalEx()
        {
            try
            {
                InitializeComponent();
                txtObservacao.GotFocus += txtObservacao_Focus;
                cbArea.DataSource = areaBLL.CarregaAreas();
                cbJornal.DataSource = jornalBLL.CarregaJornais();
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
        //Construtor carregando cadastro do Jornal no form
        public FrmCadJornalEx(JornalEx jornal) : this()
        {
            try
            {
                CarregaCampos(jornal);
                txtManchete.Focus();
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
                    //Validações campo Manchete
                    if (txtManchete.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Manchete é obrigatório.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtManchete.Text.Length < 10)
                    {
                        MessageBox.Show(this, "O campo Manchete deve conter no mínimo dez digitos.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        JornalEx.Manchete = txtManchete.Text;
                    }
                    //Validações campo Data de Pulicação
                    if (dtDataPublicacao.Value > DateTime.Now)
                    {
                        MessageBox.Show(this, "Informe uma data valida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        JornalEx.DataPublicacao = dtDataPublicacao.Value;
                    }
                    //Campo Lingua
                    JornalEx.Lingua = cbLingua.Text;
                    //Validações campo Localização
                    if (txtLocalizacao.Text.Length != 0)
                    {
                        if (txtLocalizacao.Text.Length < 4)
                        {
                            MessageBox.Show(this, "O campo Localização deve conter no minimo quatro digitos", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        JornalEx.Localizacao = txtLocalizacao.Text;
                    }
                    else
                    {
                        JornalEx.Localizacao = "";
                    }
                    //Validações campo Área
                    if ((int)cbArea.SelectedValue < 0)
                    {
                        MessageBox.Show(this, "Selecione uma area da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        JornalEx.Area.CodArea = (int)cbArea.SelectedValue;
                    }
                    //Validações campo Tipo Tombo
                    if (cbTipoTombo.Text == "")
                    {
                        MessageBox.Show(this, "Selecione um tipo de tombo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        JornalEx.TipoTombo = cbTipoTombo.Text;
                    }
                    //CheckBox Disponivel
                    if (btnAcao.Text.Equals("Alterar"))
                    {
                        if (JornalEx.Disponivel != checkDisponivel.Checked)
                        {
                            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
                            EmprestimoList emprestimoList = emprestimoBLL.EmprestimoConsultar_PorTombo(JornalEx.Tombo, "Jornal");
                            foreach (Emprestimo emprestimo in emprestimoList)
                            {
                                if (emprestimo.Fechado == false)
                                {
                                    MidiaEmprestimoList midiaEmprestimoList = emprestimoBLL.EmprestimoMidiaConsultar_PorCodEmprestimo(emprestimo.CodEmprestimo);
                                    foreach (MidiaEmprestimo midia in midiaEmprestimoList)
                                    {
                                        if (midia.CodMidia == JornalEx.CodMidia && midia.Devolvido == false)
                                        {
                                            if (MessageBox.Show(this, "Este Jornal encontra-se emprestado, por isso não é possivel alterar sua disponibilidade." +
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
                    JornalEx.Disponivel = checkDisponivel.Checked;
                    //Validações campo Jornal
                    if ((int)cbJornal.SelectedValue < 0)
                    {
                        MessageBox.Show(this, "Selecione um jornal da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        JornalEx.Jornal_.CodJornal = (int)cbJornal.SelectedValue;
                    }
                    //Campo Observação
                    JornalEx.Observacao = txtObservacao.Text;
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = midiaBLL.JornalInserir(JornalEx);
                    }
                    else
                    {
                        resultado = midiaBLL.JornalAlterar(JornalEx);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este Jornal?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = midiaBLL.MidiaExcluir(JornalEx.Tombo, "Jornal");
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
                txtManchete.Focus();
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
                FrmPonteJornalEx ponteJornalEx = new FrmPonteJornalEx(this, "Alterar");
                if (ponteJornalEx.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(JornalEx);
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    txtManchete.Focus();
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
                FrmPonteJornalEx ponteJornalEx = new FrmPonteJornalEx(this, "Excluir");
                if (ponteJornalEx.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(JornalEx);
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
        private void CarregaCampos(JornalEx jornal)
        {
            txtManchete.Text = jornal.Manchete;
            txtTombo.Text = jornal.Tombo.ToString();
            txtLocalizacao.Text = jornal.Localizacao;
            cbLingua.SelectedItem = jornal.Lingua;
            cbTipoTombo.SelectedItem = jornal.TipoTombo;
            cbArea.SelectedValue = jornal.Area.CodArea;
            cbJornal.SelectedValue = jornal.Jornal_.CodJornal;
            txtObservacao.Text = jornal.Observacao;
            if (jornal.Disponivel)
            {
                checkDisponivel.Checked = true;
            }
            else
            {
                checkDisponivel.Checked = false;
            }
            toolExibe(txtManchete, txtManchete.Text);
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
        private void cbJornal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                toolExibe(cbJornal, cbJornal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Aumenta o tamanho do campo Observação
        private void txtObservacao_Focus(object sender, EventArgs e)
        {
            txtObservacao.Height = 75;
            pnlPrincipal.Height = 424;
            this.Height = 495;
            btnAcao.Location = new Point(149, 453);
            btnCancelar.Location = new Point(241, 453);
        }
        //Retorna o tamanho do campo Observação ao original
        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            if (txtObservacao.Text == "" || txtObservacao.Text == null)
            {
                txtObservacao.Height = 25;
                pnlPrincipal.Height = 374;
                this.Height = 445;
                btnAcao.Location = new Point(149, 403);
                btnCancelar.Location = new Point(241, 403);
            }
        }
    }
}
