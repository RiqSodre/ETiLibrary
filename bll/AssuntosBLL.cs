using DAL;
using DTO.Infraestrutura_de_Midia;
using System;
using System.Data;

namespace BLL
{
    public class AssuntosBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir o assunto
        public string AssuntoInserir(Assunto assunto)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", assunto.Descricao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAssuntoInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar o assunto
        public string AssuntoAlterar(Assunto assunto)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodAssunto", assunto.CodAssunto);
                acesso.AdicionarParametros("@Descricao", assunto.Descricao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAssuntoAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Excluir o assunto
        public string AssuntoExcluir(Assunto assunto)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodAssunto", assunto.CodAssunto);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAssuntoExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega a lista de assuntos
        public AssuntoList CarregaAssuntos()
        {
            try
            {
                AssuntoList assuntoList = new AssuntoList();

                acesso.LimparParametros();
                DataTable dataTableAssuntos = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodAssunto, Descricao FROM tblAssunto");

                foreach(DataRow dataRow in dataTableAssuntos.Rows)
                {
                    Assunto assunto = new Assunto();

                    assunto.CodAssunto = Convert.ToInt32(dataRow["CodAssunto"]);
                    assunto.Descricao = Convert.ToString(dataRow["Descricao"]);

                    assuntoList.Add(assunto);
                }
                return assuntoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega o assunto 
        public Assunto CarregaAssunto(string Descricao)
        {
            try
            {
                Assunto assunto = new Assunto();

                assunto.Descricao = "";

                acesso.LimparParametros();
                DataTable dataTableAssuntos = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodAssunto, Descricao FROM tblAssunto WHERE Descricao = '"+Descricao+"'");

                foreach (DataRow dataRow in dataTableAssuntos.Rows)
                {
                    assunto.CodAssunto = Convert.ToInt32(dataRow["CodAssunto"]);
                    assunto.Descricao = Convert.ToString(dataRow["Descricao"]);
                }

                return assunto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega assuntos por livro
        public AssuntoList AssuntoConsultar(int CodLivro)
        {
            try
            {
                AssuntoList assuntoList = new AssuntoList();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", CodLivro);

                DataTable dataTableAssuntos = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspAssuntoConsultar_PorLivro");

                foreach (DataRow dataRow in dataTableAssuntos.Rows)
                {
                    Assunto assunto = new Assunto();

                    assunto.CodAssunto = (int)dataRow["CodAssunto"];
                    assunto.Descricao = (string)dataRow["Descricao"];

                    assuntoList.Add(assunto);
                }
                return assuntoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
