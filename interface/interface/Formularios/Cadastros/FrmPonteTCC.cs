using BLL;
using DTO.Midia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteTCC : Interface.Formularios.Modelos.FrmPonte
    {
        private MidiaBLL midiaBLL = new MidiaBLL();
        private FrmCadTCC frmCadTCCBase = new FrmCadTCC();
        private Tcc tcc = new Tcc();

        //Carrega o form ponte TCC
        public FrmPonteTCC(FrmCadTCC frmCadTCC, string txtForm)
        {
            try
            {
                InitializeComponent();
                frmCadTCCBase = frmCadTCC;
                tcc = frmCadTCCBase.Tcc;
                lblForm.Text += " - " + txtForm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Carrega os dados do TCC que serão passsados para o form de cadastro
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTexto.Text.Length == 0)
                {
                    MessageBox.Show(this, "Digite o tombo do TCC no campo informado.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    tcc = midiaBLL.TCCConsultar_PorTombo(Convert.ToInt32(txtTexto.Text));
                    if (tcc.CodMidia == null || tcc.CodMidia == 0)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o tombo do TCC foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                    frmCadTCCBase.Tcc = tcc;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo do tombo do TCC aceitar apenas números
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
