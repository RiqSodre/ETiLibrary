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

namespace Interface.Formularios.Modelos
{
    public partial class FrmCadBaseInfraestrutura : MetroFramework.Forms.MetroForm
    {
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
    }
}
