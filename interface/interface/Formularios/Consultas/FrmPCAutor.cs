using Interface.Formularios.Modelos;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Interface.Formularios.Consultas
{
    public partial class FrmPCAutor : FrmPCBase
    {
        public FrmPCAutor()
        {
            InitializeComponent();
        }

        ////Botão Consulta por Nome
        private void btnPesquisa1_Click(object sender, System.EventArgs e)
        {
            try
            {
                LimpaForm();
                this.Width =  345;
                this.Height = 302;
                lblPesquisa.Text = "Digite o Nome do Autor:";
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 252);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão Consulta por Notação
        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                this.Width = 345;
                this.Height = 302;
                lblPesquisa.Text = "Digite a Notação do Autor:";
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 252);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
