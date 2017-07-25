using DAL;
using DTO.Infraestrutura_de_Pessoa;
using System;
using System.Data;

namespace BLL
{
    public class TurmaBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir a turma
        public string TurmaInserir(Turma turma)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodCurso", turma.Curso.CodCurso);
                acesso.AdicionarParametros("@Descricao", turma.Descricao.ToUpper());
                acesso.AdicionarParametros("@Periodo", turma.Periodo);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspTurmaInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Alterar a turma
        public string TurmaAlterar(Turma turma)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodTurma", turma.CodTurma);
                acesso.AdicionarParametros("@Descricao", turma.Descricao.ToUpper());
                acesso.AdicionarParametros("@Periodo", turma.Periodo);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspTurmaAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir a turma
        public string TurmaExcluir(int codTurma)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodTurma", codTurma);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspTurmaExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega a lista de turmas do curso informado
        public TurmaList CarregaTurmas(int codCurso) {
            try
            {
                TurmaList turmaList = new TurmaList();
                acesso.LimparParametros();
                DataTable dataTableTurmas = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodTurma, Descricao, Periodo FROM tblTurma WHERE CodCurso = "+codCurso);
                foreach(DataRow dataRow in dataTableTurmas.Rows)
                {
                    Turma turma = new Turma();
                    turma.CodTurma = (int)dataRow["CodTurma"];
                    turma.Descricao = ((string)dataRow["Descricao"]).ToUpper();
                    turma.Periodo = (string)dataRow["Periodo"];
                    turmaList.Add(turma);
                }
                return turmaList;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Realiza a consulta de Turmas por nome
        public TurmaList TurmaConsultar(string descricao)
        {
            try
            {
                TurmaList turmaList = new TurmaList();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", descricao);
                DataTable dataTableTurmas = acesso.ExecutarConsulta(CommandType.StoredProcedure, 
                    "uspTurmaConsultar");
                foreach (DataRow dataRow in dataTableTurmas.Rows)
                {
                    Turma turma = new Turma();
                    turma.CodTurma = (int)dataRow["CodTurma"];
                    turma.Descricao = ((string)dataRow["Turma"]).ToUpper();
                    turma.Periodo = (string)dataRow["Periodo"];
                    turma.Curso.CodCurso = (int)dataRow["CodCurso"];
                    turma.Curso.Descricao = (string)dataRow["Curso"];
                    turmaList.Add(turma);
                }
                return turmaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega o codigo da turma informado por nome
        public int TurmaConsultarCod_PorNome(string descricao)
        {
            try
            {
                acesso.LimparParametros();
                int codTurma = 0;
                DataTable dataTableTurmas = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodTurma FROM tblTurma WHERE Descricao = '"+descricao+"'");
                foreach (DataRow dataRow in dataTableTurmas.Rows)
                {
                    codTurma = (int)dataRow["CodTurma"];
                }
                return codTurma;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
