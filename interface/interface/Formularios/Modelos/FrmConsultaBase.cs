﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface.Formularios.Modelos
{
    public partial class FrmConsultaBase : MetroFramework.Forms.MetroForm
    {
        //Variaveis utilizadas para mover o form através dos paineis
        protected int WM_NCLBUTTONDOWN = 0xA1;
        protected int HT_CAPTION = 0x2;

        public FrmConsultaBase()
        {
            InitializeComponent();
        }

        //Botão Fechar
        protected void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Botão Minimizar
        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
