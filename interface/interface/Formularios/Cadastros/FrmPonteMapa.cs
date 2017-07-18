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
    public partial class FrmPonteMapa : Interface.Formularios.Modelos.FrmPonte
    {
        private MidiaBLL midiaBLL = new MidiaBLL();
        private FrmCadMapa frmCadMapaBase = new FrmCadMapa();
        private Mapa mapa = new Mapa();

        //Carrega o form ponte Mapa
        public FrmPonteMapa(FrmCadMapa frmCadMapa, string txtFrm)
        {
            try
            {
                InitializeComponent();
                frmCadMapaBase = frmCadMapa;
                mapa = frmCadMapaBase.Mapa;
                lblForm.Text += " - " + txtFrm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Carrega os dados do Mapa que serão passsados para o form de cadastro
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
                    mapa = midiaBLL.MapaConsultar_PorTombo(Convert.ToInt32(txtTexto.Text));
                    if (mapa.CodMidia == null || mapa.CodMidia == 0)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que o tombo do Mapa foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                    frmCadMapaBase.Mapa = mapa;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo do tombo do Mapa aceitar apenas números
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
