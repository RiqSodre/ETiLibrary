using DAL;
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
        public Aluno AlunoCarregarXML(string rm)
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
                     if (xmlnode.SelectSingleNode("RM").InnerText == rm)
                      {
                          aluno.Nome = (xmlnode["Nome"].InnerText).ToUpper();
                          aluno.Sexo = (xmlnode["Sexo"].InnerText).ToUpper();
                          aluno.Cpf = xmlnode["CPF"].InnerText;
                          aluno.Rm = xmlnode["RM"].InnerText;
                          aluno.Turma.Curso.Descricao = (xmlnode["Curso"].InnerText).ToUpper();
                          aluno.Turma.Descricao = (xmlnode["Turma"].InnerText).ToUpper();
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
                acesso.AdicionarParametros("@Nome", aluno.Nome.ToUpper());
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
                acesso.AdicionarParametros("@Nome", aluno.Nome.ToUpper());
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
        //Consultar aluno por Nome
        public AlunoList AlunoConsulta_PorNome(string nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", nome);
                DataTable dataTableAluno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsulta_PorNome");
                return AlunoCarregarLista(dataTableAluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar aluno por Curso
        public AlunoList AlunoConsulta_PorCurso(int codCurso)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodCurso", codCurso);
                DataTable dataTableAluno = acesso.ExecutarConsulta(System.Data.CommandType.StoredProcedure, "uspAlunoConsulta_PorCurso");
                return AlunoCarregarLista(dataTableAluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar aluno por Turma
        public AlunoList AlunoConsulta_PorTurma(int codTurma)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodTurma", codTurma);
                DataTable dataTableAluno = acesso.ExecutarConsulta(System.Data.CommandType.StoredProcedure, "uspAlunoConsulta_PorTurma");
                return AlunoCarregarLista(dataTableAluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar aluno por RM
        public Aluno AlunoConsulta_PorRM(string rm)
        {
            try
            {
                Aluno aluno = new Aluno();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@RM", rm);
                DataTable dataTableAluno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsulta_PorRM");
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
        public Aluno AlunoConsulta_PorCod(int codPessoa)
        {
            try
            {
                Aluno aluno = new Aluno();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
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
                aluno.Turma.Curso.CodCurso = cursoBLL.CursoConsultarCod_PorNome(aluno.Turma.Curso.Descricao);
                aluno.Turma.CodTurma = turmaBLL.TurmaConsultarCod_PorNome(aluno.Turma.Descricao);
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
                    aluno.Nome = ((string)dataRow["Nome"]).ToUpper();
                    aluno.Sexo = (string)dataRow["Sexo"];
                    if (!DBNull.Value.Equals(dataRow["CPF"]))
                    {
                       aluno.Cpf = (string)dataRow["CPF"];
                    }
                    else
                    {
                        aluno.Cpf = "";
                    }
                    aluno.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    if (!DBNull.Value.Equals(dataRow["R.M."]))
                    {
                        aluno.Rm = (string)dataRow["R.M."];
                    }
                    else
                    {
                        aluno.Rm = "";
                    }
                    aluno.Turma.Curso.CodCurso = (int)dataRow["CodCurso"];
                    aluno.Turma.Curso.Descricao = (string)dataRow["Curso"];
                    aluno.Turma.CodTurma = (int)dataRow["CodTurma"];
                    aluno.Turma.Descricao = (string)dataRow["Turma"];
                    aluno.Turma.Periodo = (string)dataRow["Periodo"];
                    if (((string)dataRow["Tipo Telefone"]).Equals("Telefone"))
                    {
                        aluno.Telefone.Numero = (string)dataRow["Telefone"];
                        aluno.Telefone.TelefoneTipo = (string)dataRow["Tipo Telefone"];
                    }
                    else
                    {
                        aluno.Celular.Numero = (string)dataRow["Telefone"];
                        aluno.Celular.TelefoneTipo = (string)dataRow["Tipo Telefone"];
                    }
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
                acesso.AdicionarParametros("@Nome", funcionario.Nome.ToUpper());
                acesso.AdicionarParametros("@Sexo", funcionario.Sexo);
                acesso.AdicionarParametros("@CPF", funcionario.Cpf);
                acesso.AdicionarParametros("@CodCargo", funcionario.CodCargo);
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
                acesso.AdicionarParametros("@Nome", funcionario.Nome.ToUpper());
                acesso.AdicionarParametros("@Sexo", funcionario.Sexo);
                acesso.AdicionarParametros("@CPF", funcionario.Cpf);
                acesso.AdicionarParametros("@CodCargo", funcionario.CodCargo);
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
        public FuncionariosList FuncionarioConsulta_PorNome(string nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", nome);
                DataTable dataTableFuncionario = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspFuncionarioConsulta_PorNome");
                return FuncionarioCarregarLista(dataTableFuncionario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar funcionario por CPF
        public Funcionario FuncionarioConsulta_PorCPF(string cpf)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CPF", cpf);
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
        public FuncionariosList FuncionarioConsulta_PorCargo(int cargo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodCargo", cargo);
                DataTable dataTableFuncionario = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspFuncionarioConsulta_PorCargo");
                return FuncionarioCarregarLista(dataTableFuncionario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar funcionario por Codigo
        public Funcionario FuncionarioConsulta_PorCod(int codPessoa)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
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
                    funcionario.Nome = ((string)dataRow["Nome"]).ToUpper();
                    if (!DBNull.Value.Equals(dataRow["Sexo"]))
                    {
                        funcionario.Sexo = (string)dataRow["Sexo"];
                    }
                    funcionario.Cpf = (string)dataRow["CPF"];
                    funcionario.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    funcionario.CodCargo = (int)dataRow["CodCargo"];
                    funcionario.Cargo = (string)dataRow["Cargo"];
                    if (((string)dataRow["Tipo Telefone"]).Equals("Telefone"))
                    {
                        funcionario.Telefone.Numero = (string)dataRow["Telefone"];
                        funcionario.Telefone.TelefoneTipo = (string)dataRow["Tipo Telefone"];
                    }
                    else
                    {
                        funcionario.Celular.Numero = (string)dataRow["Telefone"];
                        funcionario.Celular.TelefoneTipo = (string)dataRow["Tipo Telefone"];
                    }
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
        public string FuncionarioBiblioInserir(Funcionario funcionario)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", funcionario.Nome.ToUpper());
                acesso.AdicionarParametros("@Sexo", funcionario.Sexo);
                acesso.AdicionarParametros("@CPF", funcionario.Cpf);
                acesso.AdicionarParametros("@Telefone", funcionario.Telefone.Numero);
                acesso.AdicionarParametros("@Celular", funcionario.Celular.Numero);
                acesso.AdicionarParametros("@Login", funcionario.Login);
                acesso.AdicionarParametros("@Senha", funcionario.Senha);
                acesso.AdicionarParametros("@Admin", funcionario.Admin);
                acesso.AdicionarParametros("@Email", funcionario.Email.ToUpper());
                return acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioBiblioInserir").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Alterar funcionario da Biblioteca
        public string FuncionarioBiblioAlterar(Funcionario funcionario)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", funcionario.CodPessoa);
                acesso.AdicionarParametros("@Nome", funcionario.Nome.ToUpper());
                acesso.AdicionarParametros("@Sexo", funcionario.Sexo);
                acesso.AdicionarParametros("@CPF", funcionario.Cpf);
                acesso.AdicionarParametros("@Telefone", funcionario.Telefone.Numero);
                acesso.AdicionarParametros("@Celular", funcionario.Celular.Numero);
                acesso.AdicionarParametros("@Login", funcionario.Login);
                acesso.AdicionarParametros("@Senha", funcionario.Senha);
                acesso.AdicionarParametros("@Admin", funcionario.Admin);
                acesso.AdicionarParametros("@Habilitado", funcionario.Habilitado);
                acesso.AdicionarParametros("@Email", funcionario.Email.ToUpper());
                return acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioBiblioAlterar").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Seleciona os dados do funcionario da Biblioteca informado
        public Funcionario FuncionarioBiblioSelect(int codFuncionario)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodFuncionario", codFuncionario);
                DataTable dataTableFuncionarioBiblio = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspFuncionarioBiblioSelect");
                foreach (DataRow dataRow in dataTableFuncionarioBiblio.Rows)
                {
                    funcionario.CodCargo = (int)dataRow["CodCargo"];
                    funcionario.Cargo = (string)dataRow["Cargo"];
                    funcionario.CodPessoa = (int)dataRow["CodPessoa"];
                    funcionario.Nome = ((string)dataRow["Nome"]).ToUpper();
                    funcionario.Sexo = (string)dataRow["Sexo"];
                    funcionario.Cpf = (string)dataRow["CPF"];
                    funcionario.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    funcionario.Login = (string)dataRow["Login"];
                    funcionario.Senha = (string)dataRow["Senha"];
                    funcionario.Admin = (bool)dataRow["Admin"];
                    funcionario.Habilitado = (bool)dataRow["Habilitado"];
                    funcionario.Email = ((string)dataRow["Email"]).ToUpper();
                    if (((string)dataRow["Tipo Telefone"]).Equals("Telefone"))
                    {
                        funcionario.Telefone.Numero = (string)dataRow["Telefone"];
                        funcionario.Telefone.TelefoneTipo = (string)dataRow["Tipo Telefone"];
                    }
                    else
                    {
                        funcionario.Celular.Numero = (string)dataRow["Telefone"];
                        funcionario.Celular.TelefoneTipo = (string)dataRow["Tipo Telefone"];
                    }
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir a pessoa
        public string PessoaExcluir(int? codPessoa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega segundo telefone da Pessoa informada
        public Telefone PessoaTelefone(int? codPessoa)
        {
            try
            {
                Telefone telefone = new Telefone();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
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