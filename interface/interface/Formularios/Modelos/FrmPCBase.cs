﻿using MetroFramework.Controls;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface.Formularios.Modelos
{
    public partial class FrmPCBase : MetroFramework.Forms.MetroForm
    {
        //Variaveis utilizadas para mover o form através dos paineis
        protected int WM_NCLBUTTONDOWN = 0xA1;
        protected int HT_CAPTION = 0x2;

        public FrmPCBase()
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


        //Limpa Form
        protected void LimpaForm()
        {
            //Limpando os campos
            try
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
                    if(control is MaskedTextBox)
                    {
                        control.Visible = false;
                        (control as MaskedTextBox).Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        //Habilita Datas
        protected void HabilitaData(int X, int Y)
        {
            try
            {
                lblPesquisa.Visible = true;
                dtPesquisa1.Visible = true;
                dtPesquisa2.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(X, Y);
                dtPesquisa1.TabIndex = 5;
                dtPesquisa1.Focus();
                dtPesquisa2.TabIndex = 6;
                btnPesquisar.TabIndex = 7;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        //Habilita combobox
        protected void HabilitaCombo(int X, int Y)
        {
            try
            {
                lblPesquisa.Visible = true;
                cbPesquisa1.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(X, Y);
                cbPesquisa1.TabIndex = 5;
                btnPesquisar.TabIndex = 6;
                cbPesquisa1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        //Habilita textbox
        protected void HabilitaText(int X, int Y)
        {
            try
            {
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(X, Y);
                txtPesquisa.TabIndex = 5;
                txtPesquisa.Focus();
                btnPesquisar.TabIndex = 6;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        //Ajusta tamanho do form
        protected void TamanhoForm(int Width, int Height)
        {
            try
            {
                this.Width = Width;
                this.Height = Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
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
    }
}
