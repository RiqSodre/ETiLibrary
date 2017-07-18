using MetroFramework.Controls;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Interface.Formularios.Modelos
{
    public partial class FrmCadBase : MetroFramework.Forms.MetroForm
    {
        protected string resultado;
        //Variaveis utilizadas para mover o form através dos paineis
        protected int WM_NCLBUTTONDOWN = 0xA1;
        protected int HT_CAPTION = 0x2;

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
                else if (control is MetroTextBox)
                {
                    (control as MetroTextBox).Text = "";
                }
                else if (control is MaskedTextBox)
                {
                    (control as MaskedTextBox).Text = "";
                }
                else if (control is ComboBox)
                {
                    (control as ComboBox).SelectedIndex = -1;
                }
                else if (control is ListBox)
                {
                    (control as ListBox).SelectedIndex = -1;
                }
                else if (control is RadioButton)
                {
                    (control as RadioButton).Checked = false;
                }
                else if (control is CheckBox)
                {
                    (control as CheckBox).Checked = false;
                }
                else if (control is DataGridView)
                {
                    (control as DataGridView).Rows.Clear();
                }
                else if (control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
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
        //Métodos para mover o form através dos paneis
        [DllImportAttribute("user32.dll")]
        protected static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        protected static extern bool ReleaseCapture();
        //Move o form através do painel
        private void pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //Exibe o conteudo completo da combobox na tooltip
        protected void toolExibe(Control ctrl, string txtTool)
        {
            toolBase.SetToolTip(ctrl, txtTool);
        }
    }
}

