using System;
using System.Linq;
using System.Windows.Forms;
using Interface.Formularios.Modelos;
using DTO.Infraestrutura_de_Midia;
using BLL;
using DTO.Midia;
using DTO.Emprestimos;
using MetroFramework.Controls;

namespace Interface.Formularios.Cadastros
{
    public partial class FrmCadLivro : FrmCadBase
    {
        private AreaBLL areaBLL = new AreaBLL();
        private MidiaBLL midiaBLL = new MidiaBLL();
        private AutorBLL autorBLL = new AutorBLL();
        private AssuntosBLL assuntoBLL = new AssuntosBLL();
        private GeneroBLL generoBLL = new GeneroBLL();
        private EditoraBLL editoraBLL = new EditoraBLL();
        private Livro livroBase = new Livro();
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

        //Construtor Padrão
        public FrmCadLivro()
        {
            try
            {
                InitializeComponent();
                CarregaCombo();
                txtValor.GotFocus += txtValor_Focus;
                cbGenero.GotFocus += cbGenero_Focus;
                cbAutor.GotFocus += cbAutor_Focus;
                cbAssunto.GotFocus += cbAssunto_Focus;
                LimparComponentes();
                txtValor.Text = "R$0,00";
                cbLingua.SelectedIndex = 42;
                txtTitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Construtor carregando cadastro do livro no form
        public FrmCadLivro(Livro livro) : this()
        {
            try
            {
                CarregaCampos(livro);
                txtTitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Botão de ação do form Salvar/Alterar/Excluir 
        protected override void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                Livro = midiaBLL.LimpaListas(Livro);
                if (btnAcao.Text.Equals("Salvar") || btnAcao.Text.Equals("Alterar"))
                {
                    //Validações campo Titulo
                    if (txtTitulo.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Titulo é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtTitulo.Text.Length < 6)
                    {
                        MessageBox.Show(this, "O titulo deve conter no minimo seis digitos", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Livro.Titulo = txtTitulo.Text;
                    }
                    //Validações campo Subtitulo
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
                    //Validacoes campo Volume
                    if (txtVolume.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Volume é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Livro.Volume = txtVolume.Text;
                    }
                    //Validações campo Edicao
                    if (txtEdicao.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Edição é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Livro.Edicao = txtEdicao.Text;
                    }
                    //Validações campo Data de publicação
                    if (dtDataPublicacao.Value > DateTime.Now)
                    {
                        MessageBox.Show(this, "Selecione uma data de publicação valida.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Livro.DataPublicacao = dtDataPublicacao.Value;
                    }
                    //Validações campo Local
                    if (txtLocal.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Local é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Livro.Local = txtLocal.Text;
                    }
                    //Validações campo NPags
                    if (txtNdePaginas.Text.Length == 0)
                    {
                        MessageBox.Show(this, "O campo Nº de Páginas é obrigatório.", "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Livro.Npags = txtNdePaginas.Text;
                    }
                    //Validações campo Colecao
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
                    //Campo Valor
                    Livro.Valor = (float)Convert.ToDouble(txtValor.Text.Replace("R$", ""));
                    //Validações campo TipoLivro
                    if (cbTipoLivro.SelectedIndex < 0)
                    {
                        MessageBox.Show(this, "Selecione o tipo de livro da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Livro.TipoLivro = cbTipoLivro.Text;
                    }
                    //Validações campo TipoLivro
                    if (cbTipoTombo.SelectedIndex < 0)
                    {
                        MessageBox.Show(this, "Selecione o tipo de tombo da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Livro.TipoTombo = cbTipoTombo.Text;
                    }
                    //Validações dataGrid Genêros
                    if (dataGridGeneros.Rows.Count == 0)
                    {
                        MessageBox.Show(this, "Selecione pelo menos um genêro para o livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        foreach (DataGridViewRow dataRow in dataGridGeneros.Rows)
                        {
                            Genero genero = new Genero();
                            genero.CodGenero = (int)dataRow.Cells["clnCodGenero"].Value;
                            Livro.GeneroList.Add(genero);
                        }
                    }
                    //Campo Observação
                    Livro.Observacao = txtObservacao.Text;
                    //Validações campo Localização
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
                    //Campo Lingua
                    Livro.Lingua = cbLingua.Text;
                    //Validações campo Editora
                    Livro.Editora = editoraBLL.CarregaEditora(cbEditora.Text);
                    if (Livro.Editora.Nome.Equals(""))
                    {
                        MessageBox.Show(this, "Selecione uma editora da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //Validações campo Área
                    if (cbArea.SelectedIndex < 0)
                    {
                        MessageBox.Show(this, "Selecione uma área da lista de sugestão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Livro.Area.CodArea = (int)cbArea.SelectedValue;
                    }
                    //CheckBox Disponivel
                    if (btnAcao.Text.Equals("Alterar"))
                    {
                        if (Livro.Disponivel != checkDisponivel.Checked)
                        {
                            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
                            EmprestimoList emprestimoList = emprestimoBLL.EmprestimoConsultar_PorTombo(Livro.Tombo, "Livro");
                            foreach (Emprestimo emprestimo in emprestimoList)
                            {
                                if (emprestimo.Fechado == false)
                                {
                                    MidiaEmprestimoList midiaEmprestimoList = emprestimoBLL.EmprestimoMidiaConsultar_PorCodEmprestimo(emprestimo.CodEmprestimo);
                                    foreach (MidiaEmprestimo midia in midiaEmprestimoList)
                                    {
                                        if (midia.CodMidia == Livro.CodMidia && midia.Devolvido == false)
                                        {
                                            if (MessageBox.Show(this, "Este Livro encontra-se emprestado, por isso não é possivel alterar sua disponibilidade." +
                                                "Deseja abrir a paginá do empréstimo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                            {
                                                FrmCadEmprestimo frmCadEmprestimo = new FrmCadEmprestimo(emprestimo);
                                                frmCadEmprestimo.MdiParent = MdiParent;
                                                frmCadEmprestimo.Show();
                                            }
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    Livro.Disponivel = checkDisponivel.Checked;
                    //Validações dataGrid Assuntos
                    if (dataGridAssuntos.Rows.Count == 0)
                    {
                        MessageBox.Show(this, "Selecione pelo menos um assunto para o livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        foreach (DataGridViewRow dataRow in dataGridAssuntos.Rows)
                        {
                            Assunto assunto = new Assunto();
                            assunto.CodAssunto = (int)dataRow.Cells["clnCodAssunto"].Value;
                            Livro.AssuntoList.Add(assunto);
                        }
                    }
                    //Validações dataGrid Autores
                    if (dataGridAutores.Rows.Count == 0)
                    {
                        MessageBox.Show(this, "Selecione pelo menos um autor para o livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        foreach (DataGridViewRow dataRow in dataGridAutores.Rows)
                        {
                            Autor autor = new Autor();
                            autor.CodAutor = (int)dataRow.Cells["clnCodAutor"].Value;
                            Livro.AutoreList.Add(autor);
                        }
                    }
                    //Execução
                    if (btnAcao.Text == "Salvar")
                    {
                        resultado = midiaBLL.LivroInserir(Livro);
                    }
                    else
                    {
                        resultado = resultado = midiaBLL.LivroAlterar(Livro);
                    }
                }
                else
                {
                    if (MessageBox.Show(this, "Deseja excluir este Livro?", "Atenção", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        resultado = midiaBLL.MidiaExcluir(Livro.Tombo, "Livro");
                    }
                }
                MessageBox.Show(this, resultado, "Atenção", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                if (resultado.Contains("sucesso"))
                {
                    Habilita(false);
                    LimparComponentes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão que habilita e limpa os componentes do form
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                LimparComponentes();
                Habilita(true);
                txtValor.Text = "R$0,00";
                cbLingua.SelectedIndex = 42;
                txtTitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Botão Alterar - Abre o form ponte de livro e carrega o livro no form
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Livro = midiaBLL.LimpaListas(Livro);
                FrmPonteLivro ponteLivro = new FrmPonteLivro(this, "Alterar");
                if (ponteLivro.ShowDialog() == DialogResult.OK)
                {
                    LimparComponentes();
                    CarregaCampos(livroBase);
                    btnAcao.Text = "Alterar";
                    Habilita(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Botão Excluir - Abre o form ponte de livro e carrega o livro no form
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
                    btnAcao.Text = "Excluir";
                    Habilita(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Faz o campo Valor aceitar apenas números
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
                {
                    e.KeyChar = (Char)0;
                    MessageBox.Show("O campo número de Valor aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        //Faz o campo Local aceitar apenas números
        private void txtLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Local aceita apenas letras!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Faz o campo NPags aceitar apenas números
        private void txtNdePaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                    MessageBox.Show("O campo Número de páginas aceita apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            foreach (Genero genero in livro.GeneroList)
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
            toolExibe(txtTitulo, txtTitulo.Text);
            toolExibe(txtSubtitulo, txtSubtitulo.Text);
            toolExibe(txtVolume, txtVolume.Text);
            toolExibe(txtLocal, txtLocal.Text);
            toolExibe(txtEdicao, txtEdicao.Text);
            toolExibe(txtColecao, txtColecao.Text);
        }
        //Carrega as combobox com seu conteúdo
        private void CarregaCombo()
        {
            //Cria o autocomplete da combobox Autores
            AutoCompleteStringCollection dicAutor = new AutoCompleteStringCollection();
            foreach (Autor autor in autorBLL.CarregaAutores())
            {
                dicAutor.Add(autor.Nome);
            }
            cbAutor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAutor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbAutor.AutoCompleteCustomSource = dicAutor;
            //Cria o autocomplete da combobox Assuntos
            AutoCompleteStringCollection dicAssunto = new AutoCompleteStringCollection();
            foreach (Assunto assunto in assuntoBLL.CarregaAssuntos())
            {
                dicAssunto.Add(assunto.Descricao);
            }
            cbAssunto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAssunto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbAssunto.AutoCompleteCustomSource = dicAssunto;
            //Cria o autocomplete da combobox Gêneros
            AutoCompleteStringCollection dicGenero = new AutoCompleteStringCollection();
            foreach (Genero genero in generoBLL.CarregaGeneros())
            {
                dicGenero.Add(genero.Descricao);
            }
            cbGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbGenero.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbGenero.AutoCompleteCustomSource = dicGenero;
            //Cria o autocomplete da combobox Editora
            AutoCompleteStringCollection dicEditora = new AutoCompleteStringCollection();
            foreach (Editora editora in editoraBLL.CarregaEditoras())
            {
                dicEditora.Add(editora.Nome);
            }
            cbEditora.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEditora.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEditora.AutoCompleteCustomSource = dicEditora;
            //Carrega as áreas na combobox
            cbArea.DataSource = areaBLL.CarregaAreas();
            //Insere a borda nas dataGridViews
            dataGridAssuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridAutores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridGeneros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
        //Retira a formatacao do campo Valor quando recebe foco
        private void txtValor_Focus(object sender, EventArgs e)
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
        //Volta a formatacao do campo Valor quando perde o foco
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
        //Botão de adicionar gênero
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
        //Botão que remove o genêro da datagrid
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
        //Botão que adiciona autores
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
        //Botão que remove o autor da datagrid
        private void btnAutoresRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAutores.SelectedRows.Count == 0)
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
        //Botão que adiciona o assunto a datagrid
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
        //Botão que remove o assunto da datagrid
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
        //Verifica se o gênero já está inserido para o livro
        private bool ValidaGenero()
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
        //Verifica se o autor já está inserido para o livro
        private bool ValidaAutor()
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
        //Verifica se o assunto já está inserido para o livro
        private bool ValidaAssunto()
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
        //Retira o texto padrão quando a combobox Assunto recebe foco
        private void cbGenero_Focus(object sender, EventArgs e)
        {
            try
            {
                if (cbGenero.Text.Equals("Digite o genêro"))
                {
                    cbGenero.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Retira o texto padrão quando a combobox Autor recebe foco
        private void cbAutor_Focus(object sender, EventArgs e)
        {
            try
            {
                if (cbAutor.Text.Equals("Digite o nome do autor"))
                {
                    cbAutor.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Retira o texto padrão quando a combobox Assunto recebe foco
        private void cbAssunto_Focus(object sender, EventArgs e)
        {
            try
            {
                if (cbAssunto.Text.Equals("Digite o assunto"))
                {
                    cbAssunto.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Ativa o timer da combobox Genêro
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
        //Ativa o timer da combobox Autor
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
        //Ativa o timer da combobox Assunto
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
        //Timer que coloca o texto default da combobox Gênero
        private void timerCbGenero_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!cbGenero.Focused)
                {
                    cbGenero.Text = "Digite o genêro";
                    timerCbGenero.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Timer que coloca o texto default da combobox Autor
        private void timerCbAutor_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!cbAutor.Focused)
                {
                    cbAutor.Text = "Digite o nome do autor";
                    timerCbAutor.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Timer que coloca o texto default da combobox Assunto
        private void timerCbAssunto_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!cbAssunto.Focused)
                {
                    cbAssunto.Text = "Digite o assunto";
                    timerCbAssunto.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Mostra o conteúdo em uma toolTip
        private void exibe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender is MetroTextBox)
                {
                    toolExibe((sender as MetroTextBox), (sender as MetroTextBox).Text);
                }
                else
                {
                    toolExibe((sender as ComboBox), (sender as ComboBox).Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        //Mostra o conteúdo da combobox
        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                toolExibe(cbArea, cbArea.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
