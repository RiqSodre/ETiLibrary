using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface.Formularios.Modelos
{
    public partial class FrmPCBase : MetroForm
    {
        //Variaveis utilizadas para mover o form através dos paineis
        protected int WM_NCLBUTTONDOWN = 0xA1;
        protected int HT_CAPTION = 0x2;

        //Construtor padrão
        public FrmPCBase()
        {
            InitializeComponent();
        }
        //Limpa Form
        protected void LimpaForm()
        {
            foreach (Control control in Controls)
            {
                if (control is MetroTextBox)
                {
                    control.Visible = false;
                    (control as MetroTextBox).Text = "";
                }
                if (control is ComboBox)
                {
                    control.Visible = false;
                    (control as ComboBox).DataSource = null;
                    (control as ComboBox).Items.Clear();
                }
                if (control is DateTimePicker)
                {
                    control.Visible = false;
                    (control as DateTimePicker).Value = DateTime.Now;
                }
                if (control is MaskedTextBox)
                {
                    control.Visible = false;
                    (control as MaskedTextBox).Text = "";
                }
            }
        }
        //Habilita Datas
        protected void HabilitaData(int X, int Y)
        {
            lblPesquisa.Visible = true;
            dtPesq1.Visible = true;
            dtPesq2.Visible = true;
            btnPesquisar.Visible = true;
            btnPesquisar.Location = new Point(X, Y);
            dtPesq1.Focus();
        }
        //Habilita combobox
        protected void HabilitaCombo(int X, int Y, ComboBox combo)
        {
            lblPesquisa.Visible = true;
            combo.Visible = true;
            btnPesquisar.Visible = true;
            btnPesquisar.Location = new Point(X, Y);
            combo.Focus();
        }
        //Habilita textbox
        protected void HabilitaText(int X, int Y)
        {
            lblPesquisa.Visible = true;
            txtPesquisa.Visible = true;
            btnPesquisar.Visible = true;
            btnPesquisar.Location = new Point(X, Y);
            txtPesquisa.Focus();
        }
        //Ajusta tamanho do form
        protected void TamanhoForm(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
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
        //Botão que fecha o form
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Exibe o conteudo completo da combobox na tooltip
        protected void toolExibe(Control ctrl, string txtTool)
        {
            toolBase.SetToolTip(ctrl, txtTool);
        }
        //Mostra o conteúdo da combobox
        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                toolExibe((sender as ComboBox), (sender as ComboBox).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
