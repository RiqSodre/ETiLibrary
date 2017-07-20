using BLL;
using Interface.Formularios.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmPCCDVD : FrmPCBase
    {
        private AreaBLL areaBLL = new AreaBLL();

        public FrmPCCDVD()
        {
            InitializeComponent();
        }

        //Botão Consulta por Área
        private void btnPesquisa1_Click(object sender, System.EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Selecione a Área do CD/DVD:";
                lblPesquisa.Visible = true;
                cbPesquisa1.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 275);
                cbPesquisa1.DisplayMember = "Descricao";
                cbPesquisa1.ValueMember = "CodArea";

                cbPesquisa1.DataSource = areaBLL.CarregaAreas();
                if (cbPesquisa1.Items.Count > 0)
                {
                    cbPesquisa1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão Consulta por Titulo
        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Digite o Título do CD/DVD:";
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 275);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão Consulta por Tombo
        private void btnPesquisa3_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Digite o Tombo do CD/DVD:";
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 275);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
