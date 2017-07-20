using BLL;
using DTO.Midia;
using Interface.Formularios.Cadastros;
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
    public partial class FrmConsultaLivro : FrmConsultaBase
    {
        MidiaBLL midiaBLL = new MidiaBLL();

        public FrmConsultaLivro()
        {
            InitializeComponent();
        }

        //Carrega Resultado no dataGrid
        public FrmConsultaLivro(LivroList livroList)
        {
            try
            {
                InitializeComponent();

                foreach (Livro livro in livroList)
                {
                    dataGridLivro.Rows.Add(livro.CodMidia, livro.Titulo, livro.Subtitulo, livro.Serie_Colecao, livro.Edicao, livro.Volume, livro.Npags, livro.Local,
                        livro.DataPublicacao, livro.Valor, livro.TipoLivro, livro.Localizacao, livro.Lingua, livro.DataCadastro, livro.TipoTombo, livro.Tombo, livro.TipoMidia, livro.Disponivel,
                        livro.Observacao, livro.Area.CodArea, livro.Area.Descricao, livro.Editora.CodEditora, livro.Editora.Nome, livro.Genero, livro.Assuntos, livro.Autores);
                }
                dataGridLivro.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridLivro.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhum livro selecionado.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                Livro livro = new Livro();

                livro.Tombo = (int)dataGridLivro.CurrentRow.Cells["clnTombo"].Value;
                livro = midiaBLL.LivroConsultar_PorTombo(livro.Tombo);

                FrmCadLivro frmCadLivro = new FrmCadLivro(livro);
                frmCadLivro.MdiParent = MdiParent;
                frmCadLivro.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message + " " + ex.Source + " " + ex.StackTrace, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão Fechar
        private void btnFechar2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
