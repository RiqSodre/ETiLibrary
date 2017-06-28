using DAL;
using DTO.Infraestrutura_de_Midia;
using System;
using System.Data;

namespace BLL
{
    public class RevistaBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir a revista
        public string RevistaInserir(Revista revista)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodEditora", revista.Editora.CodEditora);
                acesso.AdicionarParametros("@Nome", revista.Nome);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspRevistaInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar a revista
        public string RevistaAlterar(Revista revista)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodRevista", revista.CodRevista);
                acesso.AdicionarParametros("@CodEditora", revista.Editora.CodEditora);
                acesso.AdicionarParametros("@Nome", revista.Nome);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspRevistaAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Excluir a revista
        public string RevistaExcluir(Revista revista)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodRevista", revista.CodRevista);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspRevistaExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método necessita ser finalizado de acordo com a aplicação do mesmo
        public RevistaList CarregarRevistas()
        {
            try
            {
                RevistaList revistaList = new RevistaList();

                acesso.LimparParametros();
                DataTable dataTableRevistas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "SELECT CodRevista, Nome FROM tblRevista");
                
                foreach(DataRow dataRow in dataTableRevistas.Rows)
                {
                    Revista revista = new Revista();

                    revista.CodRevista = (int)dataRow["CodRevista"];
                    revista.Nome = (string)dataRow["Nome"];

                    revistaList.Add(revista);
                }
                return revistaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Realiza a consulta de editoras por nome
        public RevistaList RevistaConsultar(string Nome)
        {
            try
            {
                RevistaList revistaList = new RevistaList();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);
                DataTable dataTableRevistas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRevistaConsultar");

                foreach (DataRow dataRow in dataTableRevistas.Rows)
                {
                    Revista revista = new Revista();

                    revista.CodRevista = (int)dataRow["CodRevista"];
                    revista.Nome = (string)dataRow["Nome"];
                    revista.Editora.CodEditora = (int)dataRow["CodEditora"];
                    revista.Editora.Nome = (string)dataRow["Editora"];

                    revistaList.Add(revista);
                }
                return revistaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
