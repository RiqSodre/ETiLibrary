using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Modelos
{
    public partial class FrmCadBase : MetroFramework.Forms.MetroForm
    {
        //Construtor padrão
        public FrmCadBase()
        {
            InitializeComponent();
        }
        //Botao responsável pela ação
        protected virtual void btnAcao_Click(object sender, EventArgs e)
        {
            //Implementar método   
        }
        //Botão Carcelar - limpa o form e trava os componentes
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparComponentes();
                Habilita(false);
                btnNovo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão que fecha o form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Limpar componentes do form
        protected void LimparComponentes()
        {
            foreach (Control control in pnlPrincipal.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = "";
                }

                if (control is MetroTextBox)
                {
                    (control as MetroTextBox).Text = "";
                }

                if (control is MaskedTextBox)
                {
                    (control as MaskedTextBox).Text = "";
                }

                if (control is ComboBox)
                {
                    (control as ComboBox).SelectedIndex = -1;
                }

                if (control is ListBox)
                {
                    (control as ListBox).SelectedIndex = -1;
                }

                if (control is RadioButton)
                {
                    (control as RadioButton).Checked = false;
                }

                if (control is CheckBox)
                {
                    (control as CheckBox).Checked = false;
                }
                if (control is DataGridView)
                {
                    (control as DataGridView).Rows.Clear();
                }
            }
            btnAcao.Text = "Salvar";
        }
        //Habilitar/Desabilitar componentes do form
        protected void Habilita(bool estado)
        {
            foreach (Control control in pnlPrincipal.Controls)
            {
                control.Enabled = estado;
            }
            foreach (Control btn in Controls)
            {
                if(btn is MetroButton)
                {
                    (btn as MetroButton).Enabled = estado;
                }
            }
        }
    }
}

