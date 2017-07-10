using System;
using System.Windows.Forms;
using Interface.Formularios.Cadastros;
using Interface.Formularios.Consultas;
using System.Runtime.InteropServices;

namespace Interface.Formularios.Modelos
{
    public partial class FrmListaBase : MetroFramework.Forms.MetroForm
    {
        private EnumModo enumodo;
        //Variaveis utilizadas para mover o form através dos paineis
        protected int WM_NCLBUTTONDOWN = 0xA1;
        protected int HT_CAPTION = 0x2;

        //Carrega o form de acordo com o modo a ser utilizado
        public FrmListaBase(EnumModo modo, string txtForm, string txt)
        {
            try
            {
                InitializeComponent();
                enumodo = modo;
                lblForm.Text = txtForm;
                lblTexto.Text = txt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro ou consulta de CD_DVD
        private void btnCadCdDvd_Click(object sender, EventArgs e)
        {
            try
            {
                bool existe = false;
                if (enumodo == EnumModo.Cadastro)
                {
                    foreach (Form form in (this.MdiParent).MdiChildren)
                    {
                        if (form.Name == "FrmCadCdDvd")
                        {
                            form.Activate();
                            if (form.Visible == false)
                            {
                                form.Close();
                            }
                            else
                            {
                                existe = true;
                            }
                            break;
                        }
                    }
                    if (!existe)
                    {
                        FrmCadCdDvd cadcdvd = new FrmCadCdDvd();
                        cadcdvd.MdiParent = MdiParent;
                        cadcdvd.Show();
                    }
                    else
                    {
                        MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.Dispose();
                }
                else
                {
                    foreach (Form form in (this.MdiParent).MdiChildren)
                    {
                        if (form.Name == "FrmPCCDVD")
                        {
                            form.Activate();
                            if (form.Visible == false)
                            {
                                form.Close();
                            }
                            else
                            {
                                existe = true;
                            }
                            break;
                        }
                    }
                    if (!existe)
                    {
                        FrmPCCDVD pccdvd = new FrmPCCDVD();
                        pccdvd.MdiParent = MdiParent;
                        pccdvd.Show();
                    }
                    else
                    {
                        MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro ou consulta de Jornal
        private void btnCadJornal_Click(object sender, EventArgs e)
        {
            try
            {
                bool existe = false;

                foreach(Form form in (this.MdiParent).MdiChildren)
                {
                    if(form.Name == "FrmCadJornal")
                    {
                        form.Activate();
                        if (form.Visible == false)
                        {
                            form.Close();
                        }
                        else
                        {
                            existe = true;
                        }
                        break;
                    }
                }
                if (!existe)
                {
                    FrmCadJornalEx cadjornalex = new FrmCadJornalEx();
                    cadjornalex.MdiParent = MdiParent;
                    cadjornalex.Show();
                }
                else
                {
                    MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro ou consulta de Livro
        private void btnCadLivro_Click(object sender, EventArgs e)
        {
            try
            {
                bool existe = false;
                if (enumodo == EnumModo.Cadastro)
                {
                    foreach (Form form in (this.MdiParent).MdiChildren)
                    {
                        if (form.Name == "FrmCadLivro")
                        {
                            form.Activate();
                            if (form.Visible == false)
                            {
                                form.Close();
                            }
                            else
                            {
                                existe = true;
                            }
                            break;
                        }
                    }
                    if (!existe)
                    {
                        FrmCadLivro cadlivro = new FrmCadLivro();
                        cadlivro.MdiParent = MdiParent;
                        cadlivro.Show();
                    }
                    else
                    {
                        MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.Dispose();
                }
                else
                {
                    foreach (Form form in (this.MdiParent).MdiChildren)
                    {
                        if (form.Name == "FrmPCLivro")
                        {
                            form.Activate();
                            if (form.Visible == false)
                            {
                                form.Close();
                            }
                            else
                            {
                                existe = true;
                            }
                            break;
                        }
                    }
                    if (!existe)
                    {
                        FrmPCLivro pclivro = new FrmPCLivro();
                        pclivro.MdiParent = MdiParent;
                        pclivro.Show();
                    }
                    else
                    {
                        MessageBox.Show(this, "Essa janela já esta aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro ou consulta de Mapa
        private void btnCadMap_Click(object sender, EventArgs e)
        {
            try
            {
                //Implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro ou consulta de Revista
        private void btnCadRevista_Click(object sender, EventArgs e)
        {
            try
            {
                //Implementar
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Abre o form de cadastro ou consulta de TCC
        private void btnCadTcc_Click(object sender, EventArgs e)
        {
            try
            {
                //Implementar
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
