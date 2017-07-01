using System.Windows.Forms;
using Interface.Formularios.Modelos;
using System;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadFuncionarioBiblioteca : FrmCadBase
    {
        //Construtor Padrão
        public FrmCadFuncionarioBiblioteca()
        {
            InitializeComponent();
        }
        //Libera a visualização da senha de acordo com a checkbox
        private void checkMSenha_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (checkMSenha.Checked)
                {
                    txtSenha.PasswordChar = '\0';
                }
                else
                {
                    txtSenha.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
