using DAL;
using DTO.Infraestrutura_de_Midia;
using System;
using System.Data;

namespace BLL
{
    public class EditoraBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir a editora
        public string EditoraInserir(string nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", nome.ToUpper());
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspEditoraInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Alterar a editora
        public string EditoraAlterar(Editora editora)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", editora.Nome.ToUpper());
                acesso.AdicionarParametros("@CodEditora", editora.CodEditora);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspEditoraAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir a editora
        public string EditoraExcluir(int codEditora)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodEditora", codEditora);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspEditoraExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega a lista de editora
        public EditoraList CarregaEditoras()
        {
            try
            {
                EditoraList EditoraList = new EditoraList();
                acesso.LimparParametros();
                DataTable dataTableEditoras = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodEditora, Nome FROM tblEditora");
                foreach (DataRow dataRow in dataTableEditoras.Rows)
                {
                    Editora editora = new Editora();
                    editora.CodEditora = (int)dataRow["CodEditora"];
                    editora.Nome = ((string)dataRow["Nome"]).ToUpper();
                    EditoraList.Add(editora);
                }
                return EditoraList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega editora
        public Editora CarregaEditora(string nome)
        {
            try
            {
                Editora editora = new Editora();
                editora.Nome = "";
                acesso.LimparParametros();
                DataTable dataTableEditoras = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodEditora, Nome FROM tblEditora WHERE Nome = '"+nome+"'");
                foreach (DataRow dataRow in dataTableEditoras.Rows)
                {
                    editora.CodEditora = (int)dataRow["CodEditora"];
                    editora.Nome = ((string)dataRow["Nome"]).ToUpper();
                }
                return editora;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega o codigo do assunto informado por descricao
        public int AssuntoConsultarCod_PorNome(string descricao)
        {
            try
            {
                int codEditora = 0;
                acesso.LimparParametros();
                DataTable dataTableEditora = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodEditora FROM tblEditora WHERE Nome = '" + descricao + "'");
                foreach (DataRow dataRow in dataTableEditora.Rows)
                {
                    codEditora = (int)dataRow["CodEditora"];
                }
                return codEditora;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Realiza a consulta de editoras por nome
        public EditoraList EditoraConsultar(string nome)
        {
            try
            {
                EditoraList editoraList = new EditoraList();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", nome);
                DataTable dataTableEditoras = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEditoraConsultar");
                foreach (DataRow dataRow in dataTableEditoras.Rows)
                {
                    Editora editora = new Editora();
                    editora.CodEditora = (int)dataRow["CodEditora"];
                    editora.Nome = ((string)dataRow["Nome"]).ToUpper();
                    editoraList.Add(editora);
                }
                return editoraList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
