using DAL.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AcessoDadosSqlServer
    {
        //Criar Conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StringConexao);
        }

        //Criar Parametros para o BD
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        //LimparParametros
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        //AdicionarParametros
        public void AdicionarParametros(string NomeParametro, object ValorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(NomeParametro, ValorParametro));
        }

        //AdicionarParemetros do tipo Structured
        public void AdicionarParametrosEspecial(string NomeParametro, object ValorParametro)
        {
            SqlParameter parametroEspecial = new SqlParameter(NomeParametro, SqlDbType.Structured);
            parametroEspecial.Value = ValorParametro;
            sqlParameterCollection.Add(parametroEspecial);
        }

        //Persistencia Inserir - Alterar - Excluir
        public object ExecutarManipulacao(CommandType commandType, string StoredProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = StoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 30;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    if (sqlParameter.SqlDbType == SqlDbType.Structured)
                    {
                        sqlCommand.Parameters.AddWithValue(sqlParameter.ParameterName, SqlDbType.Structured);
                        sqlCommand.Parameters[sqlParameter.ParameterName].Value = sqlParameter.Value;
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue(sqlParameter.ParameterName, sqlParameter.Value);
                    }
                }

                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta
        public DataTable ExecutarConsulta(CommandType commandType, string StoredProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = StoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 30;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.AddWithValue(sqlParameter.ParameterName, sqlParameter.Value);
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
