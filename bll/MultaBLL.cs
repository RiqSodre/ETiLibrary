using DAL;
using DTO.Multa;
using System;
using System.Data;

namespace BLL
{
    public class MultaBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Alterar a multa
        public string MultaAlterar(Multa multa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMulta", multa.CodMulta);
                acesso.AdicionarParametros("@CodFuncionario", multa.Funcionario.CodPessoa);
                acesso.AdicionarParametros("@Pago", multa.Pago);
                acesso.AdicionarParametros("@PagTipo", multa.PagTipo);
                acesso.AdicionarParametros("@Valor", multa.Valor);
                acesso.AdicionarParametros("@Cancelada", multa.Cancelada);
                acesso.AdicionarParametros("Observacao", multa.Observacao.ToUpper());
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspMultaAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar multa para notificação
        public Multa MultaConsultar_PorEmprestimo(int codEmprestimo)
        {
            try
            {
                Multa multa = new Multa();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codEmprestimo);
                DataTable dataTableMulta = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMultaConsultar_PorEmprestimo");
                foreach(Multa multaPesq in MultaCarregarLista(dataTableMulta))
                {
                    multa = multaPesq;
                }
                return multa;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar multa por Pessoa
        public MultaList MultaConsultar_PorPessoa(int codPessoa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
                DataTable dataTableMultas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMultaConsultar_PorPessoa");
                return MultaCarregarLista(dataTableMultas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar multa por Funcionario
        public MultaList MultaConsultar_PorFuncionario(int codPessoa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
                DataTable dataTableMultas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMultaConsultar_PorFuncionario");
                return MultaCarregarLista(dataTableMultas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar multa por EstadoPago
        public MultaList MultaConsultar_PorEstadoPago(bool estado)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Estado", estado);
                DataTable dataTableMultas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMultaConsultar_PorEstadoPago");
                return MultaCarregarLista(dataTableMultas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar multa por EstadoCancelado
        public MultaList MultaConsultar_PorEstadoCancelado(bool estado)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Estado", estado);
                DataTable dataTableMultas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMultaConsultar_PorEstadoCancelado");
                return MultaCarregarLista(dataTableMultas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar multa por Data
        public MultaList MultaConsultar_PorData(DateTime data, DateTime data2)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Data", data);
                acesso.AdicionarParametros("@Data2", data2);
                DataTable dataTableMultas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMultaConsultar_PorData");
                return MultaCarregarLista(dataTableMultas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega dados do DataTable em uma lista de multas
        private MultaList MultaCarregarLista(DataTable dataTableMultas)
        {
            try
            {
                MultaList multaList = new MultaList();
                foreach(DataRow dataRow in dataTableMultas.Rows)
                {
                    Multa multa = new Multa();
                    multa.Pessoa.Nome = ((string)dataRow["Usuario"]).ToUpper();
                    multa.Funcionario.Nome = ((string)dataRow["Funcionario"]).ToUpper();
                    multa.CodEmprestimo = (int)dataRow["CodEmprestimo"];
                    multa.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    multa.Pago = (bool)dataRow["Pago"];
                    multa.PagTipo = (string)dataRow["PagTipo"];
                    multa.Valor = (float)dataRow["Valor"];
                    multa.Cancelada = (bool)dataRow["Cancelada"];
                    multa.Observacao = ((string)dataRow["Observacao"]).ToUpper();
                    multaList.Add(multa);
                }
                return multaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
