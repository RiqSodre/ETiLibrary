using DTO.Midia;
using Interface.Formularios.Cadastros;
using Interface.Formularios.Modelos;
using System;
using System.Windows.Forms;

namespace Interface.Formularios.Consultas.Pessoas
{
    public partial class FrmConsultaCDVD : FrmConsultaBase
    {
        //Carrega Resultado no datagrid
        public FrmConsultaCDVD(CD_DVDList cdvdList)
        {
            try
            {
                InitializeComponent();
                foreach(CD_DVD cdvd in cdvdList)
                {
                    dataGridCDVD.Rows.Add(cdvd.CodMidia, cdvd.Tombo, cdvd.Titulo, cdvd.Localizacao, cdvd.Lingua, cdvd.TipoTombo, cdvd.Disponivel,
                        cdvd.Observacao, cdvd.Area.Descricao, cdvd.Area.CodArea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                Close();
            }
        }
        //Botão que seleciona o cd/dvd
        private void btnSelec_Click(object sender, EventArgs e)
        {
            try
            {
                CD_DVD cdvd = new CD_DVD();
                if (dataGridCDVD.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhum CD/DVD selecionado.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }
                cdvd.CodMidia = (int)dataGridCDVD.CurrentRow.Cells["clnCodMidia"].Value;
                cdvd.Tombo = (int)dataGridCDVD.CurrentRow.Cells["clnTombo"].Value;
                cdvd.Titulo = (string)dataGridCDVD.CurrentRow.Cells["clnTitulo"].Value;
                cdvd.Localizacao = (string)dataGridCDVD.CurrentRow.Cells["clnLocaliza"].Value;
                cdvd.Lingua = (string)dataGridCDVD.CurrentRow.Cells["clnLingua"].Value;
                cdvd.TipoTombo = (string)dataGridCDVD.CurrentRow.Cells["clnTipoTombo"].Value;
                cdvd.Disponivel = (bool)dataGridCDVD.CurrentRow.Cells["clnDisp"].Value;
                cdvd.Observacao = (string)dataGridCDVD.CurrentRow.Cells["clnObs"].Value;
                cdvd.Area.CodArea = (int)dataGridCDVD.CurrentRow.Cells["clnCodArea"].Value;
                cdvd.Area.Descricao = (string)dataGridCDVD.CurrentRow.Cells["clnArea"].Value;
                FrmCadCdDvd frmCadCdvd = new FrmCadCdDvd(cdvd);
                frmCadCdvd.MdiParent = this.MdiParent;
                frmCadCdvd.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
