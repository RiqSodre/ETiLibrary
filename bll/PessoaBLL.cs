﻿using DAL;
using DTO.Infraestrutura_de_Pessoa;
using DTO.Pessoas;
using System;
using System.Data;
using System.IO;
using System.Xml;

namespace BLL
{
    public class PessoaBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Carregar aluno através do arquivo xml gerado no nsa
        public Aluno AlunoCarregarXML(string RM)
        {
            try
            {
                Aluno aluno = new Aluno();
                XmlDocument xdocument = new XmlDocument();

                //Definir local do arquivo
                string documentoxml = Directory.GetCurrentDirectory();
                documentoxml = documentoxml.Replace("bin\\Debug", "");
                documentoxml = documentoxml + "dir.xml";

                xdocument.Load(documentoxml);

                XmlNodeList xmlnodeList = xdocument.SelectNodes("Alunos/Aluno");
                
                foreach(XmlNode xmlnode in xmlnodeList)
                  {
                     if (xmlnode.SelectSingleNode("RM").InnerText == RM)
                      {
                          aluno.Nome = xmlnode["Nome"].InnerText;
                          aluno.Sexo = xmlnode["Sexo"].InnerText;
                          aluno.Cpf = xmlnode["CPF"].InnerText;
                          aluno.Rm = xmlnode["RM"].InnerText;
                          aluno.Turma.Curso.Descricao = xmlnode["Curso"].InnerText;
                          aluno.Turma.Descricao = xmlnode["Turma"].InnerText;
                          aluno.Telefone.Numero = xmlnode["Telefone"].InnerText;
                          aluno.Celular.Numero = xmlnode["Celular"].InnerText;
                         
                      }
                  }

                return AlunoCursoTurma(aluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Inserir aluno
        public string AlunoInserir(Aluno aluno) {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", aluno.Nome);
                acesso.AdicionarParametros("@Sexo", aluno.Sexo);
                acesso.AdicionarParametros("@CPF", aluno.Cpf);
                acesso.AdicionarParametros("@RM", aluno.Rm);
                acesso.AdicionarParametros("@CodTurma", aluno.Turma.CodTurma);
                acesso.AdicionarParametros("@Telefone", aluno.Telefone.Numero);
                acesso.AdicionarParametros("@Celular", aluno.Celular.Numero);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar aluno
        public string AlunoAlterar(Aluno aluno) {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", aluno.CodPessoa);
                acesso.AdicionarParametros("@Nome", aluno.Nome);
                acesso.AdicionarParametros("@Sexo", aluno.Sexo);
                acesso.AdicionarParametros("@CPF", aluno.Cpf);
                acesso.AdicionarParametros("@RM", aluno.Rm);
                acesso.AdicionarParametros("@CodTurma", aluno.Turma.CodTurma);
                acesso.AdicionarParametros("@Telefone", aluno.Telefone.Numero);
                acesso.AdicionarParametros("@Celular", aluno.Celular.Numero);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string AlunoAlterar(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        //Consultar aluno por Nome
        public AlunoList AlunoConsulta_PorNome(string Nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);

                DataTable dataTableAluno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsulta_PorNome");
                return AlunoCarregarLista(dataTableAluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar aluno por Curso
        public AlunoList AlunoConsulta_PorCurso(int CodCurso)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodCurso", CodCurso);

                DataTable dataTableAluno = acesso.ExecutarConsulta(System.Data.CommandType.StoredProcedure, "uspAlunoConsulta_PorCurso");
                return AlunoCarregarLista(dataTableAluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar aluno por Turma
        public AlunoList AlunoConsulta_PorTurma(int CodTurma)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodTurma", CodTurma);

                DataTable dataTableAluno = acesso.ExecutarConsulta(System.Data.CommandType.StoredProcedure, "uspAlunoConsulta_PorTurma");
                return AlunoCarregarLista(dataTableAluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar aluno por RM
        public Aluno AlunoConsulta_PorRM(int RM)
        {
            try
            {
                Aluno aluno = new Aluno();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@RM", RM);

                DataTable dataTableAluno = acesso.ExecutarConsulta(System.Data.CommandType.StoredProcedure, "uspAlunoConsulta_PorRM");
                AlunoList alunoList = AlunoCarregarLista(dataTableAluno);

                foreach (Aluno alun in AlunoCarregarLista(dataTableAluno))
                {
                    aluno = alun;
                }

                return aluno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar aluno por Codigo
        public Aluno AlunoConsulta_PorCod(int CodPessoa)
        {
            try
            {
                Aluno aluno = new Aluno();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", CodPessoa);

                DataTable dataTableAluno = acesso.ExecutarConsulta(CommandType.StoredProcedure, 
                    "uspAlunoConsulta_PorCod");

                foreach (Aluno alun in AlunoCarregarLista(dataTableAluno))
                {
                    aluno = alun;
                }

                return aluno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega o Codigo da turma e do curso
        private Aluno AlunoCursoTurma(Aluno aluno)
        {
            try
            {
                CursoBLL cursoBLL = new CursoBLL();
                TurmaBLL turmaBLL = new TurmaBLL();

                CursoList cursoList = cursoBLL.CursoConsultarCod_PorNome(aluno.Turma.Curso.Descricao);
                TurmaList turmaList = turmaBLL.TurmaConsultarCod_PorNome(aluno.Turma.Descricao);

                foreach(Curso curso in cursoList)
                {
                    aluno.Turma.Curso.CodCurso = curso.CodCurso;
                }

                foreach (Turma turma in turmaList)
                {
                    aluno.Turma.CodTurma = turma.CodTurma;
                }

                return aluno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega dados do DataTable em uma lista de Alunos
        private AlunoList AlunoCarregarLista(DataTable dataTableAluno)
        {
            try
            {
                AlunoList alunoList = new AlunoList();

                foreach (DataRow dataRow in dataTableAluno.Rows)
                {
                    Aluno aluno = new Aluno();

                    aluno.CodPessoa = (int)dataRow["CodAluno"];
                    aluno.Nome = (string)dataRow["Nome"];
                    aluno.Sexo = (string)dataRow["Sexo"];

                    if (!DBNull.Value.Equals(dataRow["CPF"]))
                    {
                       aluno.Cpf = (string)dataRow["CPF"];
                    }
                    else
                    {
                        aluno.Cpf = "CPF não informado.";
                    }

                    aluno.DataCadastro = (DateTime)dataRow["DataCadastro"];

                    if (!DBNull.Value.Equals(dataRow["R.M."]))
                    {
                        aluno.Rm = (string)dataRow["R.M."];
                    }
                    else
                    {
                        aluno.Cpf = "RM não informado.";
                    }

                    aluno.Turma.Curso.CodCurso = (int)dataRow["CodCurso"];
                    aluno.Turma.Curso.Descricao = (string)dataRow["Curso"];
                    aluno.Turma.CodTurma = (int)dataRow["CodTurma"];
                    aluno.Turma.Descricao = (string)dataRow["Turma"];
                    aluno.Turma.Periodo = (string)dataRow["Periodo"];
                    aluno.Telefone.Numero = (string)dataRow["Telefone"];
                    aluno.Telefone.TelefoneTipo = (string)dataRow["Tipo Telefone"];

                    alunoList.Add(AlunoCursoTurma(aluno));
                }

                return alunoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Inserir funcionario
        public string FuncionarioInserir(Funcionario funcionario)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", funcionario.Nome);
                acesso.AdicionarParametros("@Sexo", funcionario.Sexo);
                acesso.AdicionarParametros("@CPF", funcionario.Cpf);
                acesso.AdicionarParametros("@CodCargo", funcionario.Cargo.CodCargo);
                acesso.AdicionarParametros("@Telefone", funcionario.Telefone.Numero);
                acesso.AdicionarParametros("@Celular", funcionario.Celular.Numero);
                return acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioInserir").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar funcionario
        public string FuncionarioAlterar(Funcionario funcionario)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", funcionario.CodPessoa);
                acesso.AdicionarParametros("@Nome", funcionario.Nome);
                acesso.AdicionarParametros("@Sexo", funcionario.Sexo);
                acesso.AdicionarParametros("@CPF", funcionario.Cpf);
                acesso.AdicionarParametros("@CodCargo", funcionario.Cargo.CodCargo);
                acesso.AdicionarParametros("@Telefone", funcionario.Telefone.Numero);
                acesso.AdicionarParametros("@Celular", funcionario.Celular.Numero);
                return acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioAlterar").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar funcionario por Nome
        public FuncionariosList FuncionarioConsulta_PorNome(string Nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);

                DataTable dataTableFuncionario = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspFuncionarioConsulta_PorNome");
                return FuncionarioCarregarLista(dataTableFuncionario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar funcionario por CPF
        public Funcionario FuncionarioConsulta_PorCPF(string CPF)
        {
            try
            {
                Funcionario funcionario = new Funcionario();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@CPF", CPF);

                DataTable dataTableFuncionario = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspFuncionarioConsulta_PorCPF");

                foreach (Funcionario func in FuncionarioCarregarLista(dataTableFuncionario))
                {
                    funcionario = func;
                }

                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar funcionario por Cargo
        public FuncionariosList FuncionarioConsulta_PorCargo(int Cargo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Cargo", Cargo);

                DataTable dataTableFuncionario = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspFuncionarioConsulta_PorCargo");
                return FuncionarioCarregarLista(dataTableFuncionario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar funcionario por Codigo
        public Funcionario FuncionarioConsulta_PorCod(int CodPessoa)
        {
            try
            {
                Funcionario funcionario = new Funcionario();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", CodPessoa);

                DataTable dataTableFuncionario = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspFuncionarioConsulta_PorCod");

                foreach (Funcionario func in FuncionarioCarregarLista(dataTableFuncionario))
                {
                    funcionario = func;
                }

                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega dados do DataTable em uma lista de Funcionarios
        private FuncionariosList FuncionarioCarregarLista(DataTable dataTableFuncionario)
        {
            try
            {
                FuncionariosList funcionarioList = new FuncionariosList();

                foreach (DataRow dataRow in dataTableFuncionario.Rows)
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.CodPessoa = (int)dataRow["CodPessoa"];
                    funcionario.Nome = (string)dataRow["Nome"];

                    if (!DBNull.Value.Equals(dataRow["Sexo"]))
                    {
                        funcionario.Sexo = (string)dataRow["Sexo"];
                    }

                    funcionario.Cpf = (string)dataRow["CPF"];
                    funcionario.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    funcionario.Cargo.Descricao = (string)dataRow["Cargo"];

                    funcionarioList.Add(funcionario);
                }
                return funcionarioList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Inserir funcionario da Biblioteca
        public string FuncionarioBiblioInserir(UsuarioSistema usuarioSistema)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", usuarioSistema.Nome);
                acesso.AdicionarParametros("@Sexo", usuarioSistema.Sexo);
                acesso.AdicionarParametros("@CPF", usuarioSistema.Cpf);
                acesso.AdicionarParametros("@Telefone", usuarioSistema.Telefone);
                acesso.AdicionarParametros("@Celular", usuarioSistema.Celular);
                acesso.AdicionarParametros("@Login", usuarioSistema.Login);
                acesso.AdicionarParametros("@Senha", usuarioSistema.Senha);
                acesso.AdicionarParametros("@Admin", usuarioSistema.Admin);
                acesso.AdicionarParametros("@Email", usuarioSistema.Email);
                return acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioBiblioInserir").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar funcionario da Biblioteca
        public string FuncionarioBiblioAlterar(UsuarioSistema usuarioSistema)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", usuarioSistema.CodPessoa);
                acesso.AdicionarParametros("@Nome", usuarioSistema.Nome);
                acesso.AdicionarParametros("@Sexo", usuarioSistema.Sexo);
                acesso.AdicionarParametros("@CPF", usuarioSistema.Cpf);
                acesso.AdicionarParametros("@Telefone", usuarioSistema.Telefone);
                acesso.AdicionarParametros("@Celular", usuarioSistema.Celular);
                acesso.AdicionarParametros("@Login", usuarioSistema.Login);
                acesso.AdicionarParametros("@Senha", usuarioSistema.Senha);
                acesso.AdicionarParametros("@Admin", usuarioSistema.Admin);
                acesso.AdicionarParametros("@Habilitado", usuarioSistema.Habilitado);
                acesso.AdicionarParametros("@Email", usuarioSistema.Email);
                return acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioBiblioAlterar").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Seleciona os dados do funcionario da Biblioteca informado
        public UsuarioSistema FuncionarioBiblioSelect(int CodFuncionario)
        {
            try
            {
                UsuarioSistema usuarioSistema = new UsuarioSistema();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodFuncionario", CodFuncionario);

                DataTable dataTableFuncionarioBiblio = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspFuncionarioBiblioSelect");

                foreach (DataRow dataRow in dataTableFuncionarioBiblio.Rows)
                {
                    usuarioSistema.Cargo.Descricao = (string)dataRow["Cargo"];
                    usuarioSistema.CodPessoa = (int)dataRow["CodPessoa"];
                    usuarioSistema.Nome = (string)dataRow["Nome"];
                    usuarioSistema.Sexo = (string)dataRow["Sexo"];
                    usuarioSistema.Cpf = (string)dataRow["CPF"];
                    usuarioSistema.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    usuarioSistema.Login = (string)dataRow["Login"];
                    usuarioSistema.Senha = (string)dataRow["Senha"];
                    usuarioSistema.Admin = (bool)dataRow["Admin"];
                    usuarioSistema.Habilitado = (bool)dataRow["Habilitado"];
                    usuarioSistema.Email = (string)dataRow["Email"];
                }
                return usuarioSistema;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
  
        //Excluir a pessoa
        public string PessoaExcluir(int? CodPessoa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", CodPessoa);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega segundo telefone da Pessoa informada
        public Telefone PessoaTelefone(int? CodPessoa)
        {
            try
            {
                Telefone telefone = new Telefone();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", CodPessoa);
                DataTable dataTableTelefone = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspPessoaTelefone");

                foreach (DataRow dataRow in dataTableTelefone.Rows)
                {
                    telefone.Numero = (string)dataRow["Numero"];
                    telefone.TelefoneTipo = (string)dataRow["TelefoneTipo"];
                }
                return telefone;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}