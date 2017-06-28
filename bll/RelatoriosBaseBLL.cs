using DAL;
using DTO.Relatórios;
using System;
using System.Data;

namespace BLL
{
    class RelatoriosBaseBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Relatório de usuarios Cadastrados
        public UsuariosCad RelatorioUsuariosCad(DateTime Data, DateTime Data2)
        {
            try
            {
                UsuariosCad usuariosCad = new UsuariosCad();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Data", Data);
                acesso.AdicionarParametros("@Data2", Data2);
                DataTable dataTableRelatorio = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRelatorioUuariosCad");

                usuariosCad.FuncionariosCad = (int)dataTableRelatorio.Rows[0]["Funcionários Cadastrados"];
                usuariosCad.AlunosCad = (int)dataTableRelatorio.Rows[0]["Alunos Cadastrados"];
                usuariosCad.TotalCad = (int)dataTableRelatorio.Rows[0]["Total de Usuários Cadastrados"];
                usuariosCad.Periodo = (string)dataTableRelatorio.Rows[0]["Periodo"];

                return usuariosCad;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        //Relatório de usuarios Devedores
        public UsuariosDevedorList RelatorioUsuariosDevedores(DateTime Data, DateTime Data2)
        {
            try
            {
                UsuariosDevedorList usuariosDevedorList = new UsuariosDevedorList();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Data", Data);
                acesso.AdicionarParametros("@Data2", Data2);
                DataTable dataTableUsuariosDevedores = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRelatorioUsuarioDevedores");
                
                foreach(DataRow dataRow in dataTableUsuariosDevedores.Rows)
                {
                    UsuariosDevedor usuarioDevedor = new UsuariosDevedor();

                    usuarioDevedor.Pessoa.CodPessoa = (int)dataRow["CodPessoa"];
                    usuarioDevedor.Pessoa.Nome = (string)dataRow["Nome"];
                    usuarioDevedor.Pessoa.Sexo = (string)dataRow["Sexo"];
                    usuarioDevedor.Pessoa.Cpf = (string)dataRow["CPF"];
                    usuarioDevedor.Pessoa.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    usuarioDevedor.Multa = (bool)dataRow["Multa"];

                    usuariosDevedorList.Add(usuarioDevedor);
                }
                return usuariosDevedorList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Relatório de Emprestimo por Usuário
        public HistoricoEmprestimoList RelatorioHistoricoEmprestimo_PorUsuario(int CodPessoa, DateTime Data, DateTime Data2)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", CodPessoa);
                acesso.AdicionarParametros("@Data", Data);
                acesso.AdicionarParametros("@Data2", Data2);
                DataTable dataTableHistoricoEmprestimo = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRelatorioHistoricoEmprestimo_PorUsuario");

                return RelatorioHistoricoEmprestimoCarregaLista(dataTableHistoricoEmprestimo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Relatório de Empréstimo por Midia
        public HistoricoEmprestimoList RelatorioHistoricoEmprestimo_PorMidia(int Tombo, string TipoMidia, DateTime Data, DateTime Data2)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                acesso.AdicionarParametros("@TipoMidia", TipoMidia);
                acesso.AdicionarParametros("@Data", Data);
                acesso.AdicionarParametros("@Data2", Data2);
                DataTable dataTableHistoricoEmprestimo = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRelatorioHistoricoEmprestimo_PorMidia");

                return RelatorioHistoricoEmprestimoCarregaLista(dataTableHistoricoEmprestimo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega dados do DataTable em uma lista de Historico de emprestimo
        private HistoricoEmprestimoList RelatorioHistoricoEmprestimoCarregaLista(DataTable dataTableHistoricoEmprestimo)
        {
            try
            {
                HistoricoEmprestimoList HistoricoEmprestimoList = new HistoricoEmprestimoList();

                foreach (DataRow dataRow in dataTableHistoricoEmprestimo.Rows)
                {
                    HistoricoEmprestimo HistoricoEmprestimo = new HistoricoEmprestimo();

                    HistoricoEmprestimo.Aluno.CodPessoa = (int)dataRow["CodUsuario"];
                    HistoricoEmprestimo.Aluno.Nome = (string)dataRow["Usuario"];
                    HistoricoEmprestimo.Funcionario.CodPessoa = (int)dataRow["CodFuncionario"];
                    HistoricoEmprestimo.Funcionario.Nome = (string)dataRow["Funcionario"];
                    HistoricoEmprestimo.Emprestimo.CodEmprestimo = (int)dataRow["CodEmprestimo"];
                    HistoricoEmprestimo.Emprestimo.Data = (DateTime)dataRow["Data de Empréstimo"];
                    HistoricoEmprestimo.Emprestimo.Multa = (bool)dataRow["Multa"];
                    HistoricoEmprestimo.Emprestimo.Fechado = (bool)dataRow["Condição"];

                    HistoricoEmprestimoList.Add(HistoricoEmprestimo);
                }

                return HistoricoEmprestimoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Relatório de Midias Cadastradas no periodo informado
        public MidiasCadEmp RelatorioMidiasCadastradas(DateTime Data, DateTime Data2)
        {
            try
            {
                MidiasCadEmp midiasCad = new MidiasCadEmp();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Data", Data);
                acesso.AdicionarParametros("@Data2", Data2);
                DataTable dataTableMidiasCad = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRelatorioMidiasCadastradas");

                midiasCad.Livros = (int)dataTableMidiasCad.Rows[0]["Livros"];
                midiasCad.Cd_dvd = (int)dataTableMidiasCad.Rows[0]["CD e DVD"];
                midiasCad.Jornais = (int)dataTableMidiasCad.Rows[0]["Jornais"];
                midiasCad.Revistas = (int)dataTableMidiasCad.Rows[0]["Revistas"];
                midiasCad.Mapas = (int)dataTableMidiasCad.Rows[0]["Mapas"];
                midiasCad.Tcc = (int)dataTableMidiasCad.Rows[0]["TCC"];
                midiasCad.Total = (int)dataTableMidiasCad.Rows[0]["Total"];
                midiasCad.Periodo = (string)dataTableMidiasCad.Rows[0]["Periodo"];

                return midiasCad;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Relatório de Midias Emprestadas no periodo informado
        public MidiasCadEmp RelatorioMidiasEmprestadas(DateTime Data, DateTime Data2)
        {
            try
            {
                MidiasCadEmp midiasCad = new MidiasCadEmp();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Data", Data);
                acesso.AdicionarParametros("@Data2", Data2);
                DataTable dataTableMidiasCad = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRelatorioMidiasEmprestadas");

                midiasCad.Livros = (int)dataTableMidiasCad.Rows[0]["Livros"];
                midiasCad.Cd_dvd = (int)dataTableMidiasCad.Rows[0]["CD e DVD"];
                midiasCad.Jornais = (int)dataTableMidiasCad.Rows[0]["Jornais"];
                midiasCad.Revistas = (int)dataTableMidiasCad.Rows[0]["Revistas"];
                midiasCad.Mapas = (int)dataTableMidiasCad.Rows[0]["Mapas"];
                midiasCad.Total = (int)dataTableMidiasCad.Rows[0]["Total"];
                midiasCad.Periodo = (string)dataTableMidiasCad.Rows[0]["Periodo"];

                return midiasCad;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
