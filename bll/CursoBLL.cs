using DAL;
using DTO.Infraestrutura_de_Pessoa;
using System;
using System.Data;

namespace BLL
{
    public class CursoBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir o curso
        public string CursoInserir(string descricao)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", descricao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspCursoInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Alterar o curso
        public string CursoAlterar(Curso curso)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", curso.Descricao);
                acesso.AdicionarParametros("@CodCurso", curso.CodCurso);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspCursoAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir o curso
        public string CursoExcluir(int codCurso)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodCurso", codCurso);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspCursoExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega a lista de cursos
        public CursoList CarregaCursos()
        {
            try
            {
                CursoList cursoList = new CursoList();
                acesso.LimparParametros();
                DataTable dataTableCursos = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodCurso, Descricao FROM tblCurso");
                foreach (DataRow dataRow in dataTableCursos.Rows)
                {
                    Curso curso = new Curso();
                    curso.CodCurso = (int)dataRow["CodCurso"];
                    curso.Descricao = (string)dataRow["Descricao"];
                    cursoList.Add(curso);
                }
                return cursoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Realiza a consulta de cursos por nome
        public CursoList CursoConsultar(string Descricao)
        {
            try
            {
                CursoList cursoList = new CursoList();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", Descricao);
                DataTable dataTableCursos = acesso.ExecutarConsulta(CommandType.StoredProcedure, 
                    "uspCursoConsultar");
                foreach (DataRow dataRow in dataTableCursos.Rows)
                {
                    Curso curso = new Curso();
                    curso.CodCurso = (int)dataRow["CodCurso"];
                    curso.Descricao = (string)dataRow["Descricao"];
                    cursoList.Add(curso);
                }
                return cursoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega o codigo do curso informado por nome
        public int CursoConsultarCod_PorNome(string Descricao)
        {
            try
            {
                acesso.LimparParametros();
                int codCurso = 0;
                DataTable dataTableCursos = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodCurso FROM tblCurso WHERE Descricao = '"+Descricao+"'");
                foreach (DataRow dataRow in dataTableCursos.Rows)
                {
                    codCurso = (int)dataRow["CodCurso"];
                }
                return codCurso;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
