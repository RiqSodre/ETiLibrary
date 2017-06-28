using BLL;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Interface.Formularios.Sistema
{
    public partial class FrmRecSenha : MetroFramework.Forms.MetroForm
    {
        AutenticacaoBLL autenticaBLL = new AutenticacaoBLL();
        private string retorno;

        public FrmRecSenha()
        {
            InitializeComponent();
        }
        //Fechar formulario
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Método para recuperar senha
        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (ValidarEmail(txtEmail.Text))
                {
                    retorno = autenticaBLL.RecuperarUsuario(txtEmail.Text);
                    MessageBox.Show(this, retorno, "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (retorno.Equals("Dados do usuario enviado para o email solicitado."))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Digite um email valido.", "Atenção",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        //Validar Email
        private bool ValidarEmail(string email)
        {
            try
            {
                try
                {
                    var mail = new MailAddress(email);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
