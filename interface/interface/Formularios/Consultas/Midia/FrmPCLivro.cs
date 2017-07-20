using BLL;
using DTO.Infraestrutura_de_Midia;
using DTO.Midia;
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
    public partial class FrmPCLivro : FrmPCBase
    {
        private AutorBLL autorBLL = new AutorBLL();
        private AssuntosBLL assuntoBLL = new AssuntosBLL();
        private GeneroBLL generoBLL = new GeneroBLL();
        private EditoraBLL editoraBLL = new EditoraBLL();
        private AreaBLL areaBLL = new AreaBLL();
        private MidiaBLL midiaBLL = new MidiaBLL();

        public FrmPCLivro()
        {
            InitializeComponent();
        }

        //Botão consulta Área
        private void btnPesquisa1_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Selecione a área do livro:";

                cbPesquisa1.DisplayMember = "Descricao";
                cbPesquisa1.ValueMember = "CodArea";
                cbPesquisa1.DropDownStyle = ComboBoxStyle.DropDownList;

                cbPesquisa1.DataSource = areaBLL.CarregaAreas();
                if (cbPesquisa1.Items.Count > 0)
                {
                    cbPesquisa1.SelectedIndex = 0;
                }
                
                HabilitaCombo(92, 366);
                TamanhoForm(345, 413);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Assunto
        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Selecione o assunto do livro:";

                AutoCompleteStringCollection dicAssunto = new AutoCompleteStringCollection();

                foreach (Assunto assunto in assuntoBLL.CarregaAssuntos())
                {
                    dicAssunto.Add(assunto.Descricao);
                }

                cbPesquisa1.DropDownStyle = ComboBoxStyle.DropDown;
                cbPesquisa1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbPesquisa1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbPesquisa1.AutoCompleteCustomSource = dicAssunto;
                cbPesquisa1.Text = "Digite o assunto";

                HabilitaCombo(92, 366);
                TamanhoForm(345, 413);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Autor
        private void btnPesquisa3_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Selecione a autor do livro:";

                AutoCompleteStringCollection dicAutor = new AutoCompleteStringCollection();

                foreach (Autor autor in autorBLL.CarregaAutores())
                {
                    dicAutor.Add(autor.Nome);
                }

                cbPesquisa1.DropDownStyle = ComboBoxStyle.DropDown;
                cbPesquisa1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbPesquisa1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbPesquisa1.AutoCompleteCustomSource = dicAutor;
                cbPesquisa1.Text = "Digite o nome do Autor";

                HabilitaCombo(92, 366);
                TamanhoForm(345, 413);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Editora
        private void btnPesquisa4_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Selecione a editora do livro:";

                AutoCompleteStringCollection dicEditora = new AutoCompleteStringCollection();

                foreach (Editora editora in editoraBLL.CarregaEditoras())
                {
                    dicEditora.Add(editora.Nome);
                }

                cbPesquisa1.DropDownStyle = ComboBoxStyle.DropDown;
                cbPesquisa1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbPesquisa1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbPesquisa1.AutoCompleteCustomSource = dicEditora;
                cbPesquisa1.Text = "Digite a editora";

                HabilitaCombo(92, 366);
                TamanhoForm(345, 413);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        
        //Botão consulta Genêro
        private void btnPesquisa5_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Selecione a genêro do livro:";

                cbPesquisa1.DisplayMember = "Descricao";
                cbPesquisa1.ValueMember = "CodGenero";

                AutoCompleteStringCollection dicGenero = new AutoCompleteStringCollection();

                foreach (Genero genero in generoBLL.CarregaGeneros())
                {
                    dicGenero.Add(genero.Descricao);
                }
                
                cbPesquisa1.DropDownStyle = ComboBoxStyle.DropDown;
                cbPesquisa1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbPesquisa1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbPesquisa1.AutoCompleteCustomSource = dicGenero;
                cbPesquisa1.Text = "Digite o genêro";

                HabilitaCombo(92, 366);
                TamanhoForm(345, 413);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
        
        //Botão consulta Título
        private void btnPesquisa6_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Digite o título do livro:";

                HabilitaText(92, 366);
                TamanhoForm(345, 413);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão consulta Tombo
        private void btnPesquisa7_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaForm();
                lblPesquisa.Text = "Digite o tombo do livro:";
                
                HabilitaText(92, 366);
                TamanhoForm(345, 413);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Botão de pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                LivroList livroList = new LivroList();

                if (lblPesquisa.Text.Contains("área"))
                {
                    if(cbPesquisa1.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Selecione uma área.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    livroList = midiaBLL.LivroConsultar_PorArea((int)cbPesquisa1.SelectedValue);
                }
                else if (lblPesquisa.Text.Contains("assunto"))
                {
                    Assunto assunto = assuntoBLL.CarregaAssunto(cbPesquisa1.Text);

                    if (assunto.Descricao.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um assunto da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    livroList = midiaBLL.LivroConsultar_PorAssunto(assunto.CodAssunto);
                }
                else if (lblPesquisa.Text.Contains("autor"))
                {
                    Autor autor = autorBLL.CarregaAutor(cbPesquisa1.Text);

                    if (autor.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um autor da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    livroList = midiaBLL.LivroConsultar_PorAutor(autor.CodAutor);
                }
                else if(lblPesquisa.Text.Contains("editora"))
                {
                    Editora editora = editoraBLL.CarregaEditora(cbPesquisa1.Text);

                    if (editora.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione uma editora da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    livroList = midiaBLL.LivroConsultar_PorEditora(editora.Nome);
                }
                else if (lblPesquisa.Text.Contains("genêro"))
                {
                    Genero genero = generoBLL.CarregaGenero(cbPesquisa1.Text);

                    if (genero.Descricao.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione um gênero da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    livroList = midiaBLL.LivroConsultar_PorGenero(genero.CodGenero);
                }
                else if (lblPesquisa.Text.Contains("título"))
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Digite título do livro.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    livroList = midiaBLL.LivroConsultar_PorTitulo(txtPesquisa.Text);
                }
                else
                {
                    if (txtPesquisa.Text.Length == 0)
                    {
                        MessageBox.Show(this, "Digite tombo do livro.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    Livro livro = midiaBLL.LivroConsultar_PorTombo(Convert.ToInt32(txtPesquisa.Text));
                    livroList.Add(livro);
                }

                FrmConsultaLivro frmConsultaLivro = new FrmConsultaLivro(livroList);
                frmConsultaLivro.MdiParent = MdiParent;
                frmConsultaLivro.Show();
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        //Permite apenas números quando o parametro de pesquisa é o tombo
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (lblPesquisa.Text.Contains("tombo"))
                {
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                    {
                        e.Handled = true;
                        MessageBox.Show("O campo de pesquisa aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
