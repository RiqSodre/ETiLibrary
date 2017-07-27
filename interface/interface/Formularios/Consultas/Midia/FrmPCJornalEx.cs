using BLL;
using DTO.Infraestrutura_de_Midia;
using Interface.Formularios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas
{
    public partial class FrmPCJornalEx : FrmPCBase
    {

        AreaBLL areaBLL = new AreaBLL();
        JornalBLL jornalBLL = new JornalBLL();
        AreaList areaList = new AreaList();
        JornalList jornalList = new JornalList();


        public FrmPCJornalEx()
        {
            InitializeComponent();
        }

        //Botão consulta Área
        private void btnPesquisa1_Click(object sender, EventArgs e)
        {
            try
            {
                Width = 345;
                Height = 349;
                LimpaForm();
                lblPesquisa.Text = "Selecione a área do jornal:";
                lblPesquisa.Visible = true;
                cbPesq1.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 293);
                cbPesq1.DisplayMember = "Descricao";
                cbPesq1.ValueMember = "CodArea";

                cbPesq1.DataSource = areaBLL.CarregaAreas();
                if (cbPesq1.Items.Count > 0)
                {
                    cbPesq1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consuta Jornais
        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            try
            {
                Width = 345;
                Height = 349;
                LimpaForm();
                lblPesquisa.Text = "Selecione o jornal:";
                lblPesquisa.Visible = true;
                cbPesq1.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 297);
                cbPesq1.DisplayMember = "Descricao";
                cbPesq1.ValueMember = "CodJornal";

                cbPesq1.DataSource = jornalBLL.CarregaJornais();
                if (cbPesq1.Items.Count > 0)
                {
                    cbPesq1.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Manchete
        private void btnPesquisa3_Click(object sender, EventArgs e)
        {

        }

        //Botão consulta Tombo
        private void btnPesquisa4_Click(object sender, EventArgs e)
        {
            try
            {
                Width = 345;
                Height = 349;
                LimpaForm();
                lblPesquisa.Text = "Digite o código do jornal:";
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;
                btnPesquisar.Visible = true;
                btnPesquisar.Location = new Point(92, 297);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblPesquisa.Text.Contains("área"))
                {
                    if (cbPesq1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione a área do jornal.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    areaList = areaBLL.CarregaAreas();
                }
                else if (lblPesquisa.Text.Contains("jornal"))
                {
                    if (cbPesq1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione o jornal.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    jornalList = jornalBLL.CarregaJornais();
                }
               /* else if (lblPesquisa.Text.Contains("manchete"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o código da pessoa.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }*/
                else
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Insira o código do jornal.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    jornalList = jornalBLL.JornalConsultar(txtPesquisa.Text);
                }
                FrmConsultaEmprestimo frmConsultaAcervo = new FrmConsultaEmprestimo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
