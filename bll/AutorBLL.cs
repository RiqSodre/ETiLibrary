﻿using DAL;
using DTO.Infraestrutura_de_Midia;
using System;
using System.Data;

namespace BLL
{
    public class AutorBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir o autor
        public string AutorInserir(Autor autor)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", autor.Nome.ToUpper());
                acesso.AdicionarParametros("@Sobrenome", autor.Sobrenome.ToUpper());
                acesso.AdicionarParametros("@Notacao", autor.NotacaoAutor.ToUpper());
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAutorInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
        }
        //Alterar o autor
        public string AutorAlterar(Autor autor)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodAutor", autor.CodAutor);
                acesso.AdicionarParametros("@Nome", autor.Nome.ToUpper());
                acesso.AdicionarParametros("@Sobrenome", autor.Sobrenome.ToUpper());
                acesso.AdicionarParametros("@Notacao", autor.NotacaoAutor.ToUpper());
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAutorAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir o autor
        public string AutorExcluir(int codAutor)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodAutor", codAutor);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAutorExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega o autor
        public Autor CarregaAutor(string nome)
        {
            try
            {
                Autor autor = new Autor();
                autor.Nome = "";
                acesso.LimparParametros();
                if (nome.Contains("'"))
                {
                   nome = nome.Replace("'", "''");
                }
                DataTable dataTableAutores = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodAutor, CONCAT(Sobrenome, ' , ', Nome) AS 'Nome', NotacaoAutor AS 'Notação do Autor' FROM tblAutor "
                    + "WHERE CONCAT(Sobrenome, ' , ', Nome) =  '" + nome + "'");
                foreach(Autor aut in AutoresCarregarLista(dataTableAutores))
                {
                    autor = aut;
                }
                return autor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega a lista de autores
        public AutorList CarregaAutores()
        {
            try
            {
                acesso.LimparParametros();
                DataTable dataTableAutores = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodAutor, CONCAT(Sobrenome, ' , ', Nome) AS 'Nome', NotacaoAutor AS 'Notação do Autor' FROM tblAutor");
                return AutoresCarregarLista(dataTableAutores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar autor por Nome
        public AutorList AutorConsultar_PorNome(string nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", nome);
                DataTable dataTableAutores = acesso.ExecutarConsulta(CommandType.StoredProcedure, 
                    "uspAutorConsultar_PorNome");
                return AutoresCarregarLista(dataTableAutores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar autor por Notacao
        public AutorList AutorConsultar_PorNotacao(string notacao)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Notacao", notacao);
                DataTable dataTableAutores = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspAutorConsultar_PorNotacao");
                return AutoresCarregarLista(dataTableAutores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar autor por Livro
        public AutorList AutorConsultar_PorLivro(int? codLivro)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", codLivro);
                DataTable dataTableAutores = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspAutorConsultar_PorLivro");
                return AutoresCarregarLista(dataTableAutores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega dados do DataTable em uma lista de Autores
        private AutorList AutoresCarregarLista(DataTable dataTableAutores)
        {
            try
            {
                AutorList autorList = new AutorList();
                foreach (DataRow dataRow in dataTableAutores.Rows)
                {
                    Autor autor = new Autor();
                    autor.CodAutor = (int)dataRow["CodAutor"];
                    autor.Nome = ((string)dataRow["Nome"]).ToUpper();
                    if(!DBNull.Value.Equals(dataRow["Notação do Autor"])) 
                    {
                    autor.NotacaoAutor = ((string)dataRow["Notação do Autor"]).ToUpper();
                    }
                    autorList.Add(autor);
                }
                return autorList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
