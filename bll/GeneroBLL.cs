using DAL;
using DTO.Infraestrutura_de_Midia;
using System;
using System.Data;

namespace BLL
{
    public class GeneroBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir o genero
        public string GeneroInserir(string descricao)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", descricao.ToUpper());
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspGeneroInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Alterar o genero
        public string GeneroAlterar(Genero genero)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodGenero", genero.CodGenero);
                acesso.AdicionarParametros("@Descricao", genero.Descricao.ToUpper());
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspGeneroAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir o genero
        public string GeneroExcluir(int codGenero)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodGenero", codGenero);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspGeneroExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega a lista de generos
        public GeneroList CarregaGeneros()
        {
            try
            {
                GeneroList generoList = new GeneroList();
                acesso.LimparParametros();
                DataTable dataTableGeneros = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodGenero, Descricao FROM tblGenero ");
                foreach(DataRow dataRow in dataTableGeneros.Rows)
                {
                    Genero genero = new Genero();
                    genero.CodGenero = (int)dataRow["CodGenero"];
                    genero.Descricao = ((string)dataRow["Descricao"]).ToUpper();
                    generoList.Add(genero);
                }
                return generoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega a lista de generos
        public Genero CarregaGenero(string descricao)
        {
            try
            {
                Genero genero = new Genero();
                genero.Descricao = "";
                acesso.LimparParametros();
                DataTable dataTableGeneros = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodGenero, Descricao FROM tblGenero WHERE Descricao = '"+descricao+"'");
                foreach (DataRow dataRow in dataTableGeneros.Rows)
                {
                    genero.CodGenero = (int)dataRow["CodGenero"];
                    genero.Descricao = ((string)dataRow["Descricao"]).ToUpper();
                }
                return genero;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega generos por livro
        public GeneroList CarregaGenerosLivro(int? codLivro)
        {
            try
            {
                GeneroList generoList = new GeneroList();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", codLivro);
                DataTable dataTableGeneros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspGeneroConsultar_PorLivro");
                foreach (DataRow dataRow in dataTableGeneros.Rows)
                {
                    Genero genero = new Genero();
                    genero.CodGenero = (int)dataRow["CodGenero"];
                    genero.Descricao = ((string)dataRow["Descricao"]).ToUpper();
                    genero.Principal = (bool)dataRow["Principal"];
                    generoList.Add(genero);
                }
                return generoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
