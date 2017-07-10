using Interface.Formularios.Modelos;
using BLL;
using DTO.Midia;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteJornalEx : FrmPonte
    {
        private MidiaBLL midiaBLL = new MidiaBLL();
        private FrmCadJornalEx frmCadJornalExBase = new FrmCadJornalEx();
        private JornalEx jornalEx = new JornalEx();

        //Carrega o form ponte JornalEx
        public FrmPonteJornalEx(FrmCadJornalEx frmCadJornalEx, string txtForm)
        {
            InitializeComponent();
            frmCadJornalExBase = frmCadJornalEx;
            jornalEx = frmCadJornalExBase.JornalEx;
            lblForm.Text += " - " + txtForm;
        }
        //Carrega os dados do Jornal que serão passsados para o form de cadastro
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTexto.Text.Length == 0)
                {
                    MessageBox.Show(this, "Digite o tombo do Jornal no campo informado.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    jornalEx = midiaBLL.JornalConsultar_PorTombo(Convert.ToInt32(txtTexto.Text));
                    if (jornalEx.CodMidia == null)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o tombo do Jornal foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                    frmCadJornalExBase.JornalEx = jornalEx;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o Campo do tombo do Jornal aceitar apenas números
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
