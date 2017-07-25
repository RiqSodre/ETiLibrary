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
        public string AssuntoInserir(string descricao)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", descricao.ToUpper());
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
                acesso.AdicionarParametros("@Descricao", assunto.Descricao.ToUpper());
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAssuntoAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir o assunto
        public string AssuntoExcluir(int codAssunto)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodAssunto", codAssunto);
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
                    assunto.CodAssunto =(int)(dataRow["CodAssunto"]);
                    assunto.Descricao = ((string)dataRow["Descricao"]).ToUpper();
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
        public Assunto CarregaAssunto(string descricao)
        {
            try
            {
                Assunto assunto = new Assunto();
                assunto.Descricao = "";
                acesso.LimparParametros();
                DataTable dataTableAssuntos = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodAssunto, Descricao FROM tblAssunto WHERE Descricao = '"+descricao+"'");
                foreach (DataRow dataRow in dataTableAssuntos.Rows)
                {
                    assunto.CodAssunto = (int)(dataRow["CodAssunto"]);
                    assunto.Descricao = ((string)(dataRow["Descricao"])).ToUpper();
                }
                return assunto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega assuntos por livro
        public AssuntoList AssuntoConsultar(int? codLivro)
        {
            try
            {
                AssuntoList assuntoList = new AssuntoList();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", codLivro);
                DataTable dataTableAssuntos = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspAssuntoConsultar_PorLivro");
                foreach (DataRow dataRow in dataTableAssuntos.Rows)
                {
                    Assunto assunto = new Assunto();
                    assunto.CodAssunto = (int)dataRow["CodAssunto"];
                    assunto.Descricao = ((string)dataRow["Descricao"]).ToUpper();
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
