using DAL;
using DTO.Reserva;
using System;
using System.Data;

namespace BLL
{
    public class ReservaBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir reserva
        public string ReservaInserir(Reserva reserva)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", reserva.Livro.CodMidia);
                acesso.AdicionarParametros("@Tombo", reserva.Livro.Tombo);
                acesso.AdicionarParametros("@CodPessoa", reserva.Pessoa.CodPessoa);
                acesso.AdicionarParametros("@DataRetirada", reserva.DataRetirada);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspReservaInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir reserva
        public string ReservaExcluir(Reserva reserva)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidiaReserva", reserva.CodMidiaReserva);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspReservaExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Confirmar reserva
        public Reserva ReservaConfirmar(int codPessoa)
        {
            try
            {
                Reserva reserva = new Reserva();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
                DataTable dataTableReserva = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspConfirmarReserva");
                reserva.Livro.CodMidia = (int)dataTableReserva.Rows[0]["CodMidia"];
                reserva.Livro.Tombo = (int)dataTableReserva.Rows[0]["Tombo"];
                return reserva;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar reserva por Pessoa
        public ReservaList ReservaConsultarLivro_PorPessoa(int codPessoa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodPessoa", codPessoa);
                DataTable dataTableReservas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspReservaConsultarLivro_PorPessoa");
                return ReservaCarregarLista(dataTableReservas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar reserva por Tombo
        public ReservaList ReservaConsultarLivro_PorTombo(int tombo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", tombo);
                DataTable dataTableReservas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspReservaConsultarLivro_PorTombo");
                return ReservaCarregarLista(dataTableReservas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Consultar reserva por Data
        public ReservaList ReservaConsultarLivro_PorData(DateTime data, DateTime data2)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Data", data);
                acesso.AdicionarParametros("@Data2", data2);
                DataTable dataTableReservas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspReservaConsultarLivro_PorData");
                return ReservaCarregarLista(dataTableReservas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Carrega dados do DataTable em uma lista de reservas
        private ReservaList ReservaCarregarLista(DataTable dataTableReservas)
        {
            try
            {
                ReservaList reservaList = new ReservaList();
                foreach(DataRow dataRow in dataTableReservas.Rows)
                {
                    Reserva reserva = new Reserva();
                    reserva.Pessoa.CodPessoa = (int)dataRow["CodPessoa"];
                    reserva.Pessoa.Nome = ((string)dataRow["Usuario"]).ToUpper();
                    reserva.DataRetirada = (DateTime)dataRow["DataRetirada"];
                    reserva.CodMidiaReserva = (int)dataRow["CodMidiaReserva"];
                    reserva.Livro.Tombo = (int)dataRow["Tombo"];
                    reserva.TipoMidia = (string)dataRow["TipoMidia"];
                    reserva.Livro.Titulo = ((string)dataRow["Titulo"]).ToUpper();
                    reservaList.Add(reserva);
                }
                return reservaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
