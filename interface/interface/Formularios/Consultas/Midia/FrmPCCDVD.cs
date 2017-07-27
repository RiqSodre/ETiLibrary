using BLL;
using DTO.Midia;
using Interface.Formularios.Consultas.Pessoas;
using Interface.Formularios.Modelos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmPCCDVD : FrmPCBase
    {
        private AreaBLL areaBLL = new AreaBLL();
        private MidiaBLL midiaBLL = new MidiaBLL();
        private CD_DVDList cdvdList = new CD_DVDList();

        //Construtor padrão
        public FrmPCCDVD()
        {
            InitializeComponent();
        }
        //Botão Consulta por Área
        private void btnPesq1_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 320);
                HabilitaCombo(92, 268, cbPesq1);
                lblPesquisa.Text = "Selecione a área do CD/DVD:";
                cbPesq1.DisplayMember = "Descricao";
                cbPesq1.ValueMember = "CodArea";
                cbPesq1.DataSource = areaBLL.CarregaAreas();
                if (cbPesq1.Items.Count > 0)
                {
                    cbPesq1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Botão Consulta por Titulo
        private void btnPesq2_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 320);
                HabilitaText(92, 268);
                lblPesquisa.Text = "Digite o título do CD/DVD:";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Botão Consulta por Tombo
        private void btnPesq3_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                TamanhoForm(345, 320);
                HabilitaText(92, 268);
                lblPesquisa.Text = "Digite o tombo do CD/DVD:";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblPesquisa.Text.Contains("área"))
                {
                    if (cbPesq1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione a área do CD e DVD.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    cdvdList = midiaBLL.CDVDConsultar_PorArea((int)cbPesq1.SelectedValue);
                }
                else if (lblPesquisa.Text.Contains("título"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o título do CD ou DVD.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    cdvdList = midiaBLL.CDVDConsultar_PorTitulo(txtPesquisa.Text);
                }
                else
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o tombo do CD ou DVD.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    CD_DVD cdvd = midiaBLL.CDVDConsultar_PorTombo(Convert.ToInt32(txtPesquisa.Text));
                    if (cdvd.CodMidia == null)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                    }
                    cdvdList.Add(cdvd);
                }
                if (cdvdList.Count != 0)
                {
                    FrmConsultaCDVD frmConsultaCDVD = new FrmConsultaCDVD(cdvdList);
                    frmConsultaCDVD.MdiParent = this.MdiParent;
                    frmConsultaCDVD.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show(this, "Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        //Faz o campo de Pesquisa aceitar apenas os caracteres referentes a pesquisa
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (lblPesquisa.Text.Contains("tombo"))
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                    {
                        e.Handled = true;
                        MessageBox.Show("O campo de pesquisa aceita apenas números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
