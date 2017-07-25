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
        public string EditoraInserir(string Nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);
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
                acesso.AdicionarParametros("@Nome", editora.Nome);
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
        public string EditoraExcluir(int CodEditora)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodEditora", CodEditora);
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
                    editora.Nome = (string)dataRow["Nome"];
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
        public Editora CarregaEditora(string Nome)
        {
            try
            {
                Editora editora = new Editora();
                editora.Nome = "";
                acesso.LimparParametros();
                DataTable dataTableEditoras = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodEditora, Nome FROM tblEditora WHERE Nome = '"+Nome+"'");
                foreach (DataRow dataRow in dataTableEditoras.Rows)
                {
                    editora.CodEditora = (int)dataRow["CodEditora"];
                    editora.Nome = (string)dataRow["Nome"];
                }
                return editora;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega o codigo do assunto informado por descricao
        public int AssuntoConsultarCod_PorNome(string Descricao)
        {
            try
            {
                int codEditora = 0;
                acesso.LimparParametros();
                DataTable dataTableEditora = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodEditora FROM tblEditora WHERE Nome = '" + Descricao + "'");
                foreach (DataRow dataRow in dataTableEditora.Rows)
                {
                    codEditora = Convert.ToInt32(dataRow["CodEditora"]);
                }
                return codEditora;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Realiza a consulta de editoras por nome
        public EditoraList EditoraConsultar(string Nome)
        {
            try
            {
                EditoraList editoraList = new EditoraList();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);
                DataTable dataTableEditoras = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEditoraConsultar");
                foreach (DataRow dataRow in dataTableEditoras.Rows)
                {
                    Editora editora = new Editora();
                    editora.CodEditora = (int)dataRow["CodEditora"];
                    editora.Nome = (string)dataRow["Nome"];
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
