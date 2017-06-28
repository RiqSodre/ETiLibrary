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
using Interface.Formularios.Cadastros;
using Interface.Formularios.Consultas;

namespace Interface.Formularios.Modelos
{
    public partial class FrmListaBase : MetroFramework.Forms.MetroForm
    {
        private EnumModo enumodo;

        //Carrega o formulário com os parametros passados.
        public FrmListaBase(EnumModo modo, string textoform, string texto)
        {
            InitializeComponent();
            enumodo = modo;
            lblTextoForm.Text = textoform;
            lblTexto.Text = texto;
        }

        //Botão Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmListaBase_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        //Abre o formulário de cadastro ou consulta de livro
        private void btnCadLivro_Click(object sender, EventArgs e)
        {
            try
            {
                bool existe = false;

                if (enumodo == EnumModo.Cadastro)
                {
                    foreach (Form form in this.MdiChildren)
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
                        MessageBox.Show("Você já abriu essa janela!");
                    }
                    this.Dispose();
                }
                else
                {
                    foreach (Form form in this.MdiChildren)
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
                        MessageBox.Show("Você já abriu essa janela!");
                    }
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadCdDvd_Click(object sender, EventArgs e)
        {
            
            try
            {
                bool existe = false;

                if (enumodo == EnumModo.Cadastro)
                {
                    foreach (Form form in this.MdiChildren)
                    {
                        if (form.Name == " FrmCadCdDvd")
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
                        MessageBox.Show("Você já abriu essa janela!");
                    }
                    this.Dispose();
                }
                else
                {
                    foreach (Form form in this.MdiChildren)
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
                        MessageBox.Show("Você já abriu essa janela!");
                    }
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadJornal_Click(object sender, EventArgs e)
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
    }
}
