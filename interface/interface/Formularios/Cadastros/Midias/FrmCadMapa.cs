using BLL;
using DTO.Emprestimos;
using DTO.Midia;
using Interface.Formularios.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadMapa : FrmCadBase
    {
        private AreaBLL areaBLL = new AreaBLL();
        private MidiaBLL midiaBLL = new MidiaBLL();
        private Mapa mapa = new Mapa();
        public Mapa Mapa
        {
            get
            {
                return mapa;
            }

            set
            {
                mapa = value;
            }
        }

        //Construtor padrão
        public FrmCadMapa()
        {
            try
            {
                InitializeComponent();
                txtObs.GotFocus += txtObservacao_Focus;
                cbArea.DataSource = areaBLL.CarregaAreas();
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
        //Construtor carregando cadastro do Mapa no form
        public FrmCadMapa(Mapa mapa) : this()
        {
            try
            {
                CarregaCampos(mapa);
                txtEspecifica.Focus();
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
                    if (txtEspecifica.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Especificação é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    if (txtEspecifica.Text.Length < 6)
                    {
                        MessageBox.Show(this, "A especificação deve conter no mínimo seis digitos.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Mapa.Especificacao = txtEspecifica.Text;
                    }
                    //Campo Lingua
                    Mapa.Lingua = cbLingua.Text;
                    //Validações campo Localização
                    if (txtLocaliza.Text.Length != 0)
                    {
                        if (txtLocaliza.Text.Length < 4)
                        {
                            MessageBox.Show(this, "O campo Localização deve conter no mínimo quatro digitos.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        Mapa.Localizacao = txtLocaliza.Text;
                    }
                    else
                    {
                        Mapa.Localizacao = "";
                    }
                    //Validações campo Área
                    if ((int)cbArea.SelectedValue < 0)
                    {
                        MessageBox.Show(this, "Selecione uma área da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Mapa.Area.CodArea = (int)cbArea.SelectedValue;
                    }
                    //Validações campo Tipo Tombo
                    if (cbTipoTombo.Text == "")
                    {
                        MessageBox.Show(this, "Selecione um tipo de tombo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Mapa.TipoTombo = cbTipoTombo.Text;
                    }
                    //CheckBox Disponivel
                    if (btnAcao.Text.Equals("Alterar"))
                    {
                        if (Mapa.Disponivel != checkDisp.Checked)
                        {
                            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
                            EmprestimoList emprestimoList = emprestimoBLL.EmprestimoConsultar_PorTombo(Mapa.Tombo, "Mapa");
                            foreach (Emprestimo emprestimo in emprestimoList)
                            {
                                if (emprestimo.Fechado == false)
                                {
                                    MidiaEmprestimoList midiaEmprestimoList = emprestimoBLL.EmprestimoMidiaConsultar_PorCodEmprestimo(emprestimo.CodEmprestimo);
                                    foreach (MidiaEmprestimo midia in midiaEmprestimoList)
                                    {
                                        if (midia.CodMidia == Mapa.CodMidia && midia.Devolvido == false)
                                        {
                                            if (MessageBox.Show(this, "Este Mapa encontra-se emprestado, por isso não é possivel alterar sua disponibilidade." +
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
                    Mapa.Disponivel = checkDisp.Checked;
                    //Campo Observação
                    Mapa.Observacao = txtObs.Text;
                    //Execução
                    if (btnAcao.Text.Equals("Salvar"))
                    {
                        resultado = midiaBLL.MapaInserir(Mapa);
                    }
                    else
                    {
                        resultado = midiaBLL.MapaAlterar(Mapa);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este Mapa?", "Atenção", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = midiaBLL.MidiaExcluir(Mapa.Tombo, "Mapa");
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
                txtEspecifica.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Abre o form ponte de Mapa e carrega o Mapa no form
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteMapa ponteMapa = new FrmPonteMapa(this, "Alterar");
                if (ponteMapa.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(Mapa);
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                    txtEspecifica.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Excluir - Abre o form ponte de Mapa e carrega o Mapa no form
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPonteMapa ponteMapa = new FrmPonteMapa(this, "Excluir");
                if (ponteMapa.ShowDialog() == DialogResult.OK)
                {
                    CarregaCampos(Mapa);
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
        private void CarregaCampos(Mapa mapa)
        {
            txtEspecifica.Text = mapa.Especificacao;
            txtTombo.Text = mapa.Tombo.ToString();
            txtLocaliza.Text = mapa.Localizacao;
            cbLingua.SelectedItem = mapa.Lingua;
            cbTipoTombo.SelectedItem = mapa.TipoTombo;
            cbArea.SelectedValue = mapa.Area.CodArea;
            txtObs.Text = mapa.Observacao;
            if (mapa.Disponivel)
            {
                checkDisp.Checked = true;
            }
            else
            {
                checkDisp.Checked = false;
            }
            toolExibe(txtEspecifica, txtEspecifica.Text);
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
        //Aumenta o tamanho do campo Observação
        private void txtObservacao_Focus(object sender, EventArgs e)
        {
            txtObs.Height = 75;
            pnlPrincipal.Height = 376;
            this.Height = 447;
            btnAcao.Location = new Point(149, 407);
            btnCancelar.Location = new Point(241, 407);
        }
        //Retorna o tamanho do campo Observação ao original
        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            if (txtObs.Text == "" || txtObs.Text == null)
            {
                txtObs.Height = 25;
                pnlPrincipal.Height = 326;
                this.Height = 397;
                btnAcao.Location = new Point(149, 355);
                btnCancelar.Location = new Point(241, 355);
            }
        }
    }
}
