using DAL;
using DTO.Infraestrutura_de_Pessoa;
using System;
using System.Data;

namespace BLL
{
    public class CargoBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir o cargo
        public string CargoInserir(Cargo cargo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", cargo.Descricao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspCargoInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar o cargo
        public string CargoAlterar(Cargo cargo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", cargo.Descricao);
                acesso.AdicionarParametros("@CodCargo", cargo.CodCargo);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspCargoAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Excluir o cargo
        public string CargoExcluir(Cargo cargo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodCargo", cargo.CodCargo);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspCargoExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega a lista de cargos
        public CargoList CarregaCargos()
        {
            try
            {
                CargoList cargoList = new CargoList();

                acesso.LimparParametros();
                DataTable dataTableCargos = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodCargo, Descricao FROM tblCargo");

                foreach(DataRow dataRow in dataTableCargos.Rows)
                {
                    Cargo cargo = new Cargo();

                    cargo.CodCargo = (int)dataRow["CodCargo"];
                    cargo.Descricao = (string)dataRow["Descricao"];

                    cargoList.Add(cargo);
                }
                return cargoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Realiza a consulta de cargos por nome
        public CargoList CargoConsultar(string Descricao)
        {
            try
            {
                CargoList cargoList = new CargoList();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", Descricao);
                DataTable dataTableCargos = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspCargoConsultar");

                foreach (DataRow dataRow in dataTableCargos.Rows)
                {
                    Cargo cargo = new Cargo();

                    cargo.CodCargo = (int)dataRow["CodCargo"];
                    cargo.Descricao = (string)dataRow["Descricao"];

                    cargoList.Add(cargo);
                }
                return cargoList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
