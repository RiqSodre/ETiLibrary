using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Interface.Formularios.Modelos
{
    public partial class FrmCadBaseInfraestrutura : MetroFramework.Forms.MetroForm
    {
        //Variaveis utilizadas para mover o form através dos paineis
        protected int WM_NCLBUTTONDOWN = 0xA1;
        protected int HT_CAPTION = 0x2;

        public FrmCadBaseInfraestrutura()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (this.Width < 340) 
            {
                this.Width += 16;
            }
            if (this.Height < 201)
            {
                this.Height += 16;
            }

            if (this.Height <= 50 && this.Width <= 50) {
                TimerLoad.Enabled = false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TimerLoad.Enabled = true;
        }

        private void FrmCadBaseInfraestrutura_Load(object sender, EventArgs e)
        {
            this.Width = 0;
            this.Height = 0;
            TimerLoad.Enabled = true;
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
    }
}
