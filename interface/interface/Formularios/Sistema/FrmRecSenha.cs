using BLL;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Sistema
{
    public partial class FrmRecSenha : MetroForm
    {
        private AutenticacaoBLL autenticaBLL = new AutenticacaoBLL();
        private string retorno;

        //Construtor Padrão
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
                if (autenticaBLL.ValidarEmail(txtEmail.Text))
                {
                    retorno = autenticaBLL.RecuperarUsuario(txtEmail.Text);
                    MessageBox.Show(this, retorno, "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (retorno.Equals("Dados do usuário enviados para o email solicitado."))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Digite um email válido.", "Atenção",
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
    }
}
