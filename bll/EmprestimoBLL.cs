using DAL;
using DTO.Emprestimos;
using System;
using System.Data;

namespace BLL
{
    public class EmprestimoBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir o Emprestimo
        public string EmprestimoInserir(Emprestimo emprestimo)
        {
            try
            {
                DataTable dataTableMidiaList = new DataTable();
                dataTableMidiaList.Columns.Add("CodMidia", typeof(int));
                dataTableMidiaList.Columns.Add("Tombo", typeof(int));
                dataTableMidiaList.Columns.Add("DataDevolucao", typeof(DateTime));
                dataTableMidiaList.Columns.Add("Devolvido", typeof(bool));
                foreach (MidiaEmprestimo midia in emprestimo.MidiaEmprestimoList)
                {
                    dataTableMidiaList.Rows.Add(midia.CodMidia, midia.Tombo,
                        midia.DataDevolucao, midia.Devolvido);
                }
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", emprestimo.Usuario.CodPessoa);
                acesso.AdicionarParametros("@CodFuncionario", emprestimo.Funcionario.CodPessoa);
                acesso.AdicionarParametros("@Data", DateTime.Now);
                acesso.AdicionarParametrosEspecial("@MidiaList", dataTableMidiaList);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspEmprestimoInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Alterar o Emprestimo
        public string EmprestimoAlterar(Emprestimo emprestimo)
        {
            try
            {
                DataTable dataTableMidiaList = new DataTable();
                dataTableMidiaList.Columns.Add("CodMidia", typeof(int));
                dataTableMidiaList.Columns.Add("Tombo", typeof(int));
                dataTableMidiaList.Columns.Add("DataDevolucao", typeof(DateTime));
                dataTableMidiaList.Columns.Add("Devolvido", typeof(bool));
                foreach (MidiaEmprestimo midia in emprestimo.MidiaEmprestimoList)
                {
                    dataTableMidiaList.Rows.Add(midia.CodMidia, midia.Tombo,
                        midia.DataDevolucao, midia.Devolvido);
                }
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodEmprestimo", emprestimo.CodEmprestimo);
                acesso.AdicionarParametros("@Data", emprestimo.Data);
                acesso.AdicionarParametros("@Multa", emprestimo.Multa);
                acesso.AdicionarParametros("@Fechado", emprestimo.Fechado);
                acesso.AdicionarParametrosEspecial("@MidiaList", dataTableMidiaList);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspEmprestimoAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar existencia de empréstimo para carregar os dados
        public EmprestimoList EmprestimoConsultar(int codPessoa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
                DataTable dataTableEmprestimos = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEmprestimoConsultar");
                return EmprestimoCarregaLista(dataTableEmprestimos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar Emprestimos por Pessoa
        public EmprestimoList EmprestimoConsultar_PorPessoa(int codPessoa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
                DataTable dataTableEmprestimos = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEmprestimoConsultar_PorPessoa");
                return EmprestimoCarregaLista(dataTableEmprestimos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar Emprestimos por Tombo
        public EmprestimoList EmprestimoConsultar_PorTombo(int tombo, string tipoMidia)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", tombo);
                acesso.AdicionarParametros("@TipoMidia", tipoMidia);
                DataTable dataTableEmprestimos = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEmprestimoConsultar_PorTombo");
                return EmprestimoCarregaLista(dataTableEmprestimos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar Emprestimos por Data
        public EmprestimoList EmprestimoConsultar_PorData(DateTime data, DateTime data2)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Data", data);
                acesso.AdicionarParametros("@Data2", data2);
                DataTable dataTableEmprestimos = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEmprestimoConsultar_PorData");
                return EmprestimoCarregaLista(dataTableEmprestimos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar Emprestimos por Multa
        public EmprestimoList EmprestimoConsultar_PorMulta(bool multa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Multa", multa);
                DataTable dataTableEmprestimos = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEmprestimoConsultar_PorMulta");
                return EmprestimoCarregaLista(dataTableEmprestimos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar Emprestimos por Estado
        public EmprestimoList EmprestimoConsultar_PorEstado(bool estado)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Estado", estado);
                DataTable dataTableEmprestimos = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEmprestimoConsultar_PorEstado");
                return EmprestimoCarregaLista(dataTableEmprestimos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega dados do DataTable em uma lista de emprestimos
        private EmprestimoList EmprestimoCarregaLista(DataTable dataTableEmprestimos)
        {
            try
            {
                EmprestimoList emprestimoList = new EmprestimoList();
                foreach(DataRow dataRow in dataTableEmprestimos.Rows)
                {
                    Emprestimo emprestimo = new Emprestimo();
                    emprestimo.CodEmprestimo = (int)dataRow["CodEmprestimo"];
                    emprestimo.Usuario.CodPessoa = (int)dataRow["CodUsuario"];
                    emprestimo.Usuario.Nome = ((string)dataRow["Usuario"]).ToUpper();
                    emprestimo.Funcionario.CodPessoa = (int)dataRow["CodFuncionario"];
                    emprestimo.Funcionario.Nome = ((string)dataRow["Funcionário"]).ToUpper();
                    emprestimo.Data = (DateTime)dataRow["Data de Empréstimo"];
                    emprestimo.Multa = (bool)dataRow["Multa"];
                    emprestimo.Fechado = (bool)dataRow["Condição"];
                    emprestimo.MidiaEmprestimoList = EmprestimoMidiaConsultar_PorCodEmprestimo(emprestimo.CodEmprestimo);
                    emprestimoList.Add(emprestimo);
                }
                return emprestimoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega as midias de um emprestimo em uma lista
        public MidiaEmprestimoList EmprestimoMidiaConsultar_PorCodEmprestimo(int codEmprestimo)
        {
            try
            {
                MidiaEmprestimoList midiaEmprestimoList = new MidiaEmprestimoList();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodEmprestimo", codEmprestimo);
                DataTable dataTableMidiasEmprestimo = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEmprestimoMidiaConsultar_PorCodEmprestimo");
                foreach(DataRow dataRow in dataTableMidiasEmprestimo.Rows)
                {
                    MidiaEmprestimo midia = new MidiaEmprestimo();
                    midia.CodMidiaEmprestimo = (int)dataRow["CodMidiaEmprestimo"];
                    midia.CodMidia = (int)dataRow["CodMidia"];
                    midia.DataDevolucao = (DateTime)dataRow["DataDevolucao"];
                    midia.Tombo = (int)dataRow["Tombo"];
                    midia.Devolvido = (bool)dataRow["Devolvido"];
                    midia.TipoMidia = (string)dataRow["TipoMidia"];
                    midia.Descricao = EmprestimoMidiaDescricao(midia.CodMidia, midia.TipoMidia);
                    midiaEmprestimoList.Add(midia);
                }
                return midiaEmprestimoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Retorna a descrição da midia
        public string EmprestimoMidiaDescricao(int codMidia, string tipoMidia)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", codMidia);
                DataTable dataTableDescricao = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspEmprestimo" + tipoMidia + "Descricao");
                return ((string)dataTableDescricao.Rows[0]["Descricao"]).ToUpper();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
