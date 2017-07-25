using DAL;
using DTO.Extravio;
using System;
using System.Data;

namespace BLL
{
    public class ExtravioBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir o extravio
        public string ExtravioInserir(Extravio extravio)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidiaEmprestimo", extravio.MidiaEmprestimo.CodMidiaEmprestimo);
                acesso.AdicionarParametros("@Pago", extravio.Pago);
                acesso.AdicionarParametros("@PagTipo", extravio.PagTipo);
                acesso.AdicionarParametros("@Valor", extravio.Valor);
                acesso.AdicionarParametros("@Observacao", extravio.Observacao.ToUpper());
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspExtravioInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Alterar o extravio
        public string ExtravioAlterar(Extravio extravio)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodExtravio", extravio.CodExtravio);
                acesso.AdicionarParametros("@CodMidiaEmprestimo", extravio.MidiaEmprestimo.CodMidiaEmprestimo);
                acesso.AdicionarParametros("@Pago", extravio.Pago);
                acesso.AdicionarParametros("@PagTipo", extravio.PagTipo);
                acesso.AdicionarParametros("@Valor", extravio.Valor);
                acesso.AdicionarParametros("@Observacao", extravio.Observacao.ToUpper());
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspExtravioAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de livro por Aluno
        public ExtravioList ExtravioConsultarLivro_PorAluno(int codPessoa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarLivro_PorAluno");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de livro por Pag
        public ExtravioList ExtravioConsultarLivro_PorPag(bool pago)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Pag", pago);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarLivro_PorPag");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de livro por Midia
        public ExtravioList ExtravioConsultarLivro_PorMidia(int tombo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", tombo);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarLivro_PorMidia");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de livro por Emprestimo
        public ExtravioList ExtravioConsultarLivro_PorEmprestimo(int codEmprestimo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodEmprestimo", codEmprestimo);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarLivro_PorEmprestimo");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de livro por Data
        public ExtravioList ExtravioConsultarLivro_PorData(DateTime data, DateTime data2)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Data", data);
                acesso.AdicionarParametros("@Data", data2);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarLivro_PorData");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de cd_dvd por Aluno
        public ExtravioList ExtravioConsultarCDVD_PorAluno(int codPessoa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarCDVD_PorAluno");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de cd_dvd por Pag
        public ExtravioList ExtravioConsultarCDVD_PorPag(bool pago)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Pag", pago);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarCDVD_PorPag");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de cd_dvd por Midia
        public ExtravioList ExtravioConsultarCDVD_PorMidia(int tombo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", tombo);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarCDVD_PorMidia");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de cd_dvd por Emprestimo
        public ExtravioList ExtravioConsultarCDVD_PorEmprestimo(int codEmprestimo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodEmprestimo", codEmprestimo);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarCDVD_PorEmprestimo");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar extravio de cd_dvd por Data
        public ExtravioList ExtravioConsultarCDVD_PorData(DateTime data, DateTime data2)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Data", data);
                acesso.AdicionarParametros("@Data", data2);
                DataTable dataTableExtravios = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspExtravioConsultarCDVD_PorData");
                return ExtravioCarregarLista(dataTableExtravios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega os dados do DataTable em uma lista de extravios
        private ExtravioList ExtravioCarregarLista(DataTable dataTableExtravios)
        {
            try
            {
                ExtravioList extravioList = new ExtravioList();
                foreach(DataRow dataRow in dataTableExtravios.Rows)
                {
                    Extravio extravio = new Extravio();
                    extravio.Pessoa.Nome = ((string)dataRow["Aluno"]).ToUpper();
                    if (!DBNull.Value.Equals(dataRow["Observacao"]))
                    {
                        extravio.Observacao = ((string)dataRow["Observacao"]).ToUpper();
                    }
                    extravio.MidiaEmprestimo.CodMidia = (int)dataRow["CodMidia"];
                    extravio.MidiaEmprestimo.Tombo = (int)dataRow["Tombo"];
                    extravio.MidiaEmprestimo.Descricao = ((string)dataRow["Titulo"]).ToUpper();
                    extravio.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    extravio.Pago = (bool)dataRow["Pago"];
                    if (!DBNull.Value.Equals(dataRow["PagTipo"]))
                    {
                        extravio.PagTipo = (string)dataRow["PagTipo"];
                    }
                    if (!DBNull.Value.Equals(dataRow["Valor"]))
                    {
                        extravio.Valor = (float)dataRow["Valor"];
                    }
                    extravio.MidiaEmprestimo.CodMidiaEmprestimo = (int)dataRow["CodMidiaEmprestimo"];
                    extravioList.Add(extravio);
                }
                return extravioList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
