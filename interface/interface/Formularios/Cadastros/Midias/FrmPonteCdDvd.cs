using System;
using Interface.Formularios.Modelos;
using DTO.Midia;
using BLL;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteCdDvd : FrmPonte
    {
        private MidiaBLL midiaBLL = new MidiaBLL();
        private FrmCadCdDvd frmCadCdDvdBase = new FrmCadCdDvd();
        private CD_DVD cdvd = new CD_DVD();

        //Carrega o form ponte CD/DVD
        public FrmPonteCdDvd(FrmCadCdDvd frmCadCDvd, string txtFrm)
        {
            try
            {
                InitializeComponent();
                frmCadCdDvdBase = frmCadCDvd;
                cdvd = frmCadCdDvdBase.CD_DVD;
                lblForm.Text += " - " + txtFrm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Carrega os dados do CD/DVD que serão passsados para o form de cadastro
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTexto.Text.Length == 0)
                {
                    MessageBox.Show(this, "Digite o tombo do CD/DVD no campo informado.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    cdvd = midiaBLL.CDVDConsultar_PorTombo(Convert.ToInt32(txtTexto.Text));
                    if (cdvd.CodMidia == null || cdvd.CodMidia == 0)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o tombo do CD/DVD foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                    frmCadCdDvdBase.CD_DVD = cdvd;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo do tombo do CD/DVD aceitar apenas números
        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo do tombo aceita apenas números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
