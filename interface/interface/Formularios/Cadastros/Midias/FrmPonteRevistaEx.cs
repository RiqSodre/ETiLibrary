using BLL;
using DTO.Midia;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteRevistaEx : Interface.Formularios.Modelos.FrmPonte
    {
        private MidiaBLL midiaBLL = new MidiaBLL();
        private FrmCadRevistaEx frmCadRevistaExBase = new FrmCadRevistaEx();
        private RevistaEx revistaEx = new RevistaEx();

        //Carrega o form ponte RevistaEx
        public FrmPonteRevistaEx(FrmCadRevistaEx frmCadRevistaEx, string txtForm)
        {
            try
            {
                InitializeComponent();
                frmCadRevistaExBase = frmCadRevistaEx;
                revistaEx = frmCadRevistaExBase.RevistaEx;
                lblForm.Text += " - " + txtForm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Carrega os dados da Revista que serão passsados para o form de cadastro
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTexto.Text.Length == 0)
                {
                    MessageBox.Show(this, "Digite o tombo da Revista no campo informado.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    revistaEx = midiaBLL.RevistaConsultar_PorTombo(Convert.ToInt32(txtTexto.Text));
                    if (revistaEx.CodMidia == null || revistaEx.CodMidia == 0)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o tombo da Revista foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                    frmCadRevistaExBase.RevistaEx = revistaEx;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo do tombo do Jornal aceitar apenas números
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
