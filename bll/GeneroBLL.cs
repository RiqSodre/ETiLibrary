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
        public string GeneroInserir(Genero genero)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", genero.Descricao);
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
                acesso.AdicionarParametros("@Descricao", genero.Descricao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspGeneroAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Excluir o genero
        public string GeneroExcluir(Genero genero)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodGenero", genero.CodGenero);
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
                    genero.Descricao = (string)dataRow["Descricao"];

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
        public Genero CarregaGenero(string Descricao)
        {
            try
            {
                Genero genero = new Genero();

                genero.Descricao = "";

                acesso.LimparParametros();
                DataTable dataTableGeneros = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodGenero, Descricao FROM tblGenero ");

                foreach (DataRow dataRow in dataTableGeneros.Rows)
                {
                    genero.CodGenero = (int)dataRow["CodGenero"];
                    genero.Descricao = (string)dataRow["Descricao"];
                }

                return genero;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega generos por livro
        public GeneroList CarregaGenerosLivro(int CodLivro)
        {
            try
            {
                GeneroList generoList = new GeneroList();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", CodLivro);
                DataTable dataTableGeneros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspGeneroConsultar_PorLivro");

                foreach (DataRow dataRow in dataTableGeneros.Rows)
                {
                    Genero genero = new Genero();

                    genero.CodGenero = (int)dataRow["CodGenero"];
                    genero.Descricao = (string)dataRow["Descricao"];
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
