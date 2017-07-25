using DAL;
using DTO.Infraestrutura_de_Midia;
using System;
using System.Data;

namespace BLL
{
    public class JornalBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir o jornal
        public string JornalInserir(string Nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspJornalInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Alterar o jornal
        public string JornalAlterar(Jornal jornal)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", jornal.Nome);
                acesso.AdicionarParametros("@CodJornal", jornal.CodJornal);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspJornalAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir o jornal
        public string JornalExcluir(int CodJornal)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodJornal", CodJornal);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspJornalExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega o autor
        public Jornal CarregaJornal(string Nome)
        {
            try
            {
                Jornal jornal = new Jornal();
                acesso.LimparParametros();
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodJornal, Nome FROM tblJornal WHERE Nome = '"+Nome+"'");
                foreach (DataRow dataRow in dataTableJornais.Rows)
                {
                    jornal.CodJornal = (int)dataRow["CodJornal"];
                    jornal.Nome = (string)dataRow["Nome"];
                }
                return jornal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega a lista de jornais
        public JornalList CarregaJornais()
        {
            try
            {
                JornalList jornalList = new JornalList();
                acesso.LimparParametros();
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodJornal, Nome FROM tblJornal");
                foreach(DataRow dataRow in dataTableJornais.Rows)
                {
                    Jornal jornal = new Jornal();
                    jornal.CodJornal = (int)dataRow["CodJornal"];
                    jornal.Nome = (string)dataRow["Nome"];
                    jornalList.Add(jornal);
                }
                return jornalList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Realiza a consulta de jornais por nome
        public JornalList JornalConsultar(string Nome)
        {
            try
            {
                JornalList jornalList = new JornalList();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspJornalConsultar");
                foreach (DataRow dataRow in dataTableJornais.Rows)
                {
                    Jornal jornal = new Jornal();
                    jornal.CodJornal = (int)dataRow["CodJornal"];
                    jornal.Nome = (string)dataRow["Nome"];
                    jornalList.Add(jornal);
                }
                return jornalList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
