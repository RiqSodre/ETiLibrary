using System;
using System.Linq;
using System.Windows.Forms;
using Interface.Formularios.Modelos;
using DTO.Infraestrutura_de_Midia;
using BLL;
using DTO.Midia;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadLivro : FrmCadBase
    {
        private AutorBLL autorBLL = new AutorBLL();
        private AssuntosBLL assuntoBLL = new AssuntosBLL();
        private GeneroBLL generoBLL = new GeneroBLL();
        private EditoraBLL editoraBLL = new EditoraBLL();
        private AreaBLL areaBLL = new AreaBLL();
        private MidiaBLL midiaBLL = new MidiaBLL();
        private Livro livroBase = new Livro();
        private string resultado;

        public Livro Livro
        {
            get
            {
                return livroBase;
            }

            set
            {
                livroBase = value;
            }
        }

        //Construtor
        public FrmCadLivro()
        {
            try
            {
                InitializeComponent();
                dataGridAssuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                dataGridAutores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                dataGridGeneros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                btnGeneroAdd.FlatAppearance.BorderSize = 0;
                cbTipoTombo.SelectedIndex = 0;
                cbTipoLivro.SelectedIndex = 0;
                cbLingua.SelectedIndex = 42;
                txtTitulo.Focus();

                CarregaCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        //Construtor com livro
        public FrmCadLivro(Livro livro)
        {
            try
            {
                InitializeComponent();
                dataGridAssuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                dataGridAutores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                dataGridGeneros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                txtTitulo.Focus();

                CarregaCampos(livro);
                CarregaCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        //Carrega Combos
        private void CarregaCombo()
        {
            try
            {
                AutoCompleteStringCollection dicAutor = new AutoCompleteStringCollection();

                foreach (Autor autor in autorBLL.CarregaAutores())
                {
                    dicAutor.Add(autor.Nome);
                }

                cbAutor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbAutor.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbAutor.AutoCompleteCustomSource = dicAutor;

                AutoCompleteStringCollection dicAssunto = new AutoCompleteStringCollection();

                foreach (Assunto assunto in assuntoBLL.CarregaAssuntos())
                {
                    dicAssunto.Add(assunto.Descricao);
                }

                cbAssunto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbAssunto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbAssunto.AutoCompleteCustomSource = dicAssunto;

                AutoCompleteStringCollection dicGenero = new AutoCompleteStringCollection();

                foreach (Genero genero in generoBLL.CarregaGeneros())
                {
                    dicGenero.Add(genero.Descricao);
                }

                cbGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbGenero.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbGenero.AutoCompleteCustomSource = dicGenero;

                AutoCompleteStringCollection dicEditora = new AutoCompleteStringCollection();

                foreach (Editora editora in editoraBLL.CarregaEditoras())
                {
                    dicEditora.Add(editora.Nome);
                }

                cbEditora.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbEditora.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbEditora.AutoCompleteCustomSource = dicEditora;
                
                cbArea.DataSource = areaBLL.CarregaAreas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        //Botão Novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                LimparComponentes();
                Habilita(true);
                txtTitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botão Alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Livro = midiaBLL.LimpaListas(Livro);

                FrmPonteLivro ponteLivro = new FrmPonteLivro(this, "Alterar");
                if(ponteLivro.ShowDialog() == DialogResult.OK)
                {
                    LimparComponentes();
                    CarregaCampos(livroBase);

                    btnAcao.Text = "&Alterar";
                    Habilita(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Livro = midiaBLL.LimpaListas(Livro);

                FrmPonteLivro ponteLivro = new FrmPonteLivro(this, "Excluir");
                if (ponteLivro.ShowDialog() == DialogResult.OK)
                {
                    LimparComponentes();
                    CarregaCampos(livroBase);

                    btnAcao.Text = "&Excluir";
                    Habilita(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Botão de adicionar genero
        private void btnGeneroAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaGenero())
                {
                    MessageBox.Show(this, cbGenero.Text + " ja selecionado(a) como gênero deste livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Genero genero = generoBLL.CarregaGenero(cbGenero.Text);

                if (genero.Descricao.Equals(""))
                {
                    MessageBox.Show(this, "Selecione um gênero da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dataGridGeneros.Rows.Add(genero.CodGenero, genero.Descricao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Botão de remover genero
        private void btnGeneroRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridGeneros.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dataGridGeneros.Rows.Remove(dataGridGeneros.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Botão de adicionar autores
        private void btnAutoresAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaAutor())
                {
                    MessageBox.Show(this, cbAutor.Text + " ja selecionado(a) como autor deste livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Autor autor = autorBLL.CarregaAutor(cbAutor.Text);

                if (autor.Nome.Equals(""))
                {
                    MessageBox.Show(this, "Selecione um autor da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dataGridAutores.Rows.Add(autor.CodAutor, autor.Nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Botão de remover autores
        private void btnAutoresRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridAutores.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dataGridAutores.Rows.Remove(dataGridAutores.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Botão de adicionar assunto
        private void btnAssuntosAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaAssunto())
                {
                    MessageBox.Show(this, cbAssunto.Text + " ja selecionado(a) como assunto deste livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Assunto assunto = assuntoBLL.CarregaAssunto(cbAssunto.Text);

                if (assunto.Descricao.Equals(""))
                {
                    MessageBox.Show(this, "Selecione um assunto da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dataGridAssuntos.Rows.Add(assunto.CodAssunto, assunto.Descricao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Botão de remover o assunto
        private void btnAssuntosRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAssuntos.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dataGridAssuntos.Rows.Remove(dataGridAssuntos.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Validar Genero
        private bool ValidaGenero()
        {
            try
            {
                bool resultado = true;

                foreach (DataGridViewRow dataRow in dataGridGeneros.Rows)
                {
                    if (cbGenero.Text == dataRow.Cells["clnGenero"].Value.ToString())
                    {
                        resultado = false;
                    }
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Validar Autor
        private bool ValidaAutor()
        {
            try
            {
                bool resultado = true;

                foreach (DataGridViewRow dataRow in dataGridAutores.Rows)
                {
                    if (cbAutor.Text == dataRow.Cells["clnAutor"].Value.ToString())
                    {
                        resultado = false;
                    }
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Validar Autor
        private bool ValidaAssunto()
        {
            try
            {
                bool resultado = true;

                foreach (DataGridViewRow dataRow in dataGridAssuntos.Rows)
                {
                    if (cbAssunto.Text == dataRow.Cells["clnAssunto"].Value.ToString())
                    {
                        resultado = false;
                    }
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        //combobox genero foco
        private void cbGenero_Click(object sender, EventArgs e)
        {
            try
            {
                cbGenero.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //combobox genero leave
        private void cbGenero_Leave(object sender, EventArgs e)
        {
            try
            {
                timerCbGenero.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //combobox autor foco
        private void cbAutor_Click(object sender, EventArgs e)
        {
            try
            {
                cbAutor.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //combobox autor leave
        private void cbAutor_Leave(object sender, EventArgs e)
        {
            try
            {
                timerCbAutor.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //combobox assunto foco
        private void cbAssunto_Click(object sender, EventArgs e)
        {
            try
            {
                cbAssunto.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //combobox assunto leave
        private void cbAssunto_Leave(object sender, EventArgs e)
        {
            try
            {
                timerCbAssunto.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Timer cbGenero
        private void timerCbGenero_Tick(object sender, EventArgs e)
        {
            try
            {
                cbGenero.Text = "Digite o genero";
                timerCbGenero.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Timer cbAutor
        private void timerCbAutor_Tick(object sender, EventArgs e)
        {
            try
            {
                cbAutor.Text = "Digite o nome do Autor";
                timerCbAutor.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Timer cbAssunto
        private void timerCbAssunto_Tick(object sender, EventArgs e)
        {
            try
            {
                cbAssunto.Text = "Digite o assunto";
                timerCbAssunto.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Formatação Textbox
        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Formatação Textbox
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
                {
                    e.KeyChar = (Char)0;
                    MessageBox.Show("O campo número de valor aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (e.KeyChar == '.' || e.KeyChar == ',')
                    {
                        if (!txtValor.Text.Contains(','))
                        {
                            e.KeyChar = ',';
                        }
                        else
                        {
                            e.KeyChar = (Char)0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Formatação TextBox
        private void txtValor_Enter(object sender, EventArgs e)
        {
            try
            {
                string x = "";
                for (int i = 0; i <= txtValor.Text.Length - 1; i++)
                {
                    if ((txtValor.Text[i] >= '0' &&
                        txtValor.Text[i] <= '9') ||
                        txtValor.Text[i] == ',')
                    {
                        x += txtValor.Text[i];
                    }
                }
                txtValor.Text = x;
                txtValor.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Permitir somente Letras
        private void txtLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
                {
                    e.Handled = true;
                    MessageBox.Show("O campo local aceita apenas letras!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Permitir somente numeros
        private void txtNdePaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo número de páginas aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Carrega campos do livro
        private void CarregaCampos(Livro livro)
        {
            try
            {
                txtTitulo.Text = livro.Titulo;
                txtSubtitulo.Text = livro.Subtitulo;
                txtColecao.Text = livro.Serie_Colecao;
                txtVolume.Text = livro.Volume;
                txtEdicao.Text = livro.Edicao;
                dtDataPublicacao.Value = (DateTime)livro.DataPublicacao;
                txtLocal.Text = livro.Local;
                txtNdePaginas.Text = livro.Npags;
                txtTombo.Text = livro.Tombo.ToString();
                txtValor.Text = Convert.ToDouble(livro.Valor).ToString("C");
                cbTipoLivro.SelectedItem = livro.TipoLivro;
                cbTipoTombo.SelectedItem = livro.TipoTombo;
                txtLocalizacao.Text = livro.Localizacao;
                cbLingua.SelectedItem = livro.Lingua;
                cbEditora.Text = livro.Editora.Nome;
                cbArea.SelectedValue = livro.Area.CodArea;
                checkDisponivel.Checked = Livro.Disponivel;
                
                foreach(Genero genero in livro.GeneroList)
                {
                    dataGridGeneros.Rows.Add(genero.CodGenero, genero.Descricao);
                }
                
                foreach (Assunto assunto in livro.AssuntoList)
                {
                    dataGridAssuntos.Rows.Add(assunto.CodAssunto, assunto.Descricao);
                }
                
                foreach (Autor autor in livro.AutoreList)
                {
                    dataGridAutores.Rows.Add(autor.CodAutor, autor.Nome);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparComponentes();
                Habilita(false);
                btnNovo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botão Ação 
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                Livro = midiaBLL.LimpaListas(Livro);

                if (btnAcao.Text == "&Salvar" || btnAcao.Text == "&Alterar")
                {
                    if (txtTitulo.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Titulo é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtTitulo.Text.Length < 6)
                    {
                        MessageBox.Show(this, "O titulo deve conter no minimo seis digitos", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    Livro.Titulo = txtTitulo.Text;

                    if (txtSubtitulo.Text.Length != 0)
                    {
                        if (txtSubtitulo.Text.Length < 3)
                        {
                            MessageBox.Show(this, "O subtitulo deve conter no minimo três digitos", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        Livro.Subtitulo = txtSubtitulo.Text;
                    }
                    else
                    {
                        Livro.Subtitulo = "";
                    }
                    

                    if (txtColecao.Text.Length != 0)
                    {
                        if (txtColecao.Text.Length < 3)
                        {
                            MessageBox.Show(this, "O campo Coleção deve conter no minimo três digitos", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        Livro.Serie_Colecao = txtColecao.Text;
                    }
                    else
                    {
                        Livro.Serie_Colecao = "";
                    }

                    if (txtVolume.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Volume é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    Livro.Volume = txtVolume.Text;

                    if (txtEdicao.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Edição é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    Livro.Edicao = txtEdicao.Text;

                    if (dtDataPublicacao.Value > DateTime.Now)
                    {
                        MessageBox.Show(this, "Selecione uma data de publicação valida.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    Livro.DataPublicacao = dtDataPublicacao.Value;

                    if (txtLocal.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Local é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    Livro.Local = txtLocal.Text;
                    

                    if (txtNdePaginas.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Nº de Páginas é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    Livro.Npags = txtNdePaginas.Text;

                    Livro.Valor = (float)Convert.ToDouble(txtValor.Text.Replace("R$ ", ""));
                    Livro.TipoLivro = cbTipoLivro.Text;
                    Livro.TipoTombo = cbTipoTombo.Text;

                    if (txtLocalizacao.Text.Length != 0)
                    {
                        if (txtLocalizacao.Text.Length < 4)
                        {
                            MessageBox.Show(this, "O campo Localização deve conter no minimo quatro digitor", "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        Livro.Localizacao = txtLocalizacao.Text;
                    }
                    else
                    {
                        Livro.Localizacao = "";
                    }

                    Livro.Lingua = cbLingua.Text;

                    Livro.Editora = editoraBLL.CarregaEditora(cbEditora.Text);

                    if (Livro.Editora.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione uma editora da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Livro.Area.CodArea = (int)cbArea.SelectedValue;
                    Livro.Disponivel = checkDisponivel.Checked;
                    Livro.Observacao = txtObservacao.Text;

                    foreach(DataGridViewRow dataRow in dataGridAssuntos.Rows)
                    {
                        Assunto assunto = new Assunto();

                        assunto.CodAssunto = (int)dataRow.Cells["clnCodAssunto"].Value;

                        Livro.AssuntoList.Add(assunto);
                    }

                    foreach (DataGridViewRow dataRow in dataGridAutores.Rows)
                    {
                        Autor autor = new Autor();

                        autor.CodAutor = (int)dataRow.Cells["clnCodAutor"].Value;

                        Livro.AutoreList.Add(autor);
                    }

                    foreach (DataGridViewRow dataRow in dataGridGeneros.Rows)
                    {
                        Genero genero = new Genero();

                        genero.CodGenero = (int)dataRow.Cells["clnCodGenero"].Value;

                        Livro.GeneroList.Add(genero);
                    }

                    if (btnAcao.Text == "&Salvar")
                    {
                        resultado = midiaBLL.LivroInserir(Livro);
                        MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                        if (resultado.Contains("sucesso"))
                        {
                            Habilita(false);
                            LimparComponentes();
                        }
                    }
                    else if (btnAcao.Text == "&Alterar")
                    {
                        resultado = resultado = midiaBLL.LivroAlterar(Livro);
                        MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                        if (resultado.Contains("sucesso"))
                        {
                            Habilita(false);
                            LimparComponentes();
                        }
                    }
                }
                else
                {
                    resultado = midiaBLL.MidiaExcluir(Livro.Tombo, "Livro");
                    MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                    if (resultado.Contains("sucesso"))
                    {
                        Habilita(false);
                        LimparComponentes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
