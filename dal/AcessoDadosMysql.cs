using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DAL
{
    //Esta classe não foi testada, e pode conter alguns erros ou necessitar de pequenas mudanças
    public class AcessoDadosMysql
    {
        //Criar Conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection();
        }

        //Criar Parametros para o BD
        private MySqlParameterCollection mySqlParameterCollection = new MySqlCommand().Parameters;
        
        //Limpar Parametros
        public void LimparParametros()
        {
            mySqlParameterCollection.Clear();
        }

        //AdicionarParametros
        public void AdicionarParametros(string NomeParametro, object ValorParametro)
        {
            mySqlParameterCollection.Add(new MySqlParameter(NomeParametro, ValorParametro));
        }

        //Persistencia Inserir - Alterar - Excluir
        public object ExecutarManipulacao(CommandType commandType, string storedProcedureOuTextoSql)
        {
            try
            {
                MySqlConnection mySqlConnection = CriarConexao();
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandType = commandType;
                mySqlCommand.CommandText = storedProcedureOuTextoSql;
                mySqlCommand.CommandTimeout = 30;

                foreach (MySqlParameter mysqlParameter in mySqlParameterCollection)
                {
                    mySqlCommand.Parameters.Add(new MySqlParameter(mysqlParameter.ParameterName, mysqlParameter.Value));
                }

                return mySqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta
        public DataTable ExecutarConsulta(CommandType commandType, string storedProcedureOuTextoSql)
        {
            try
            {
                MySqlConnection mySqlConnection = CriarConexao();
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandType = commandType;
                mySqlCommand.CommandText = storedProcedureOuTextoSql;
                mySqlCommand.CommandTimeout = 30;

                foreach (MySqlParameter mysqlParameter in mySqlParameterCollection)
                {
                    mySqlCommand.Parameters.Add(new MySqlParameter(mysqlParameter.ParameterName, mysqlParameter.Value));
                }

                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                DataTable datatable = new DataTable();

                mysqlDataAdapter.Fill(datatable);

                return datatable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
