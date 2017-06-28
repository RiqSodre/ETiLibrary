using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.Formularios.Modelos;
using BLL;
using DTO.Midia;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmPonteLivro : FrmPonte
    {
        private MidiaBLL midiaBLL = new MidiaBLL();
        private FrmCadLivro frmCadLivroBase = new FrmCadLivro();
        private Livro livro = new Livro();

        //Carrega o form
        public FrmPonteLivro(FrmCadLivro frmCadLivro, string txtFrm)
        {
            InitializeComponent();

            frmCadLivroBase = frmCadLivro;
            livro = frmCadLivroBase.Livro;
            lblForm.Text += " - " + txtFrm;
        }

        //Carrega o Livro
        private void btnAcao_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtTexto.Text.Length == 0)
                {
                    MessageBox.Show(this, "Digite o tombo do livro no campo informado.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    livro = midiaBLL.LivroConsultar_PorTombo(Convert.ToInt32(txtTexto.Text));

                    if (livro.CodMidia == 0)
                    {
                        MessageBox.Show(this, "Nenhum registro encontrado, certifique-se que tombo foi digitado corretamente.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }

                    frmCadLivroBase.Livro = livro;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Faz o Campo aceitar apenas números
        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo tombo aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTexto_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}
