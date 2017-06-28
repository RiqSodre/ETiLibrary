using DAL;
using DTO.Infraestrutura_de_Midia;
using System;
using System.Data;

namespace BLL
{
    public class AreaBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir a area
        public string AreaInserir(Area area)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", area.Descricao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAreaInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar a area
        public string AreaAlterar(Area area)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", area.Descricao);
                acesso.AdicionarParametros("@CodArea", area.CodArea);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAreaAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Excluir a area
        public string AreaExcluir(Area area)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", area.CodArea);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspAreaExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega a lista de areas
        public AreaList CarregaAreas()
        {
            try
            {
                AreaList areaList = new AreaList();

                acesso.LimparParametros();
                DataTable dataTableAreas = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodArea, Descricao FROM tblArea");

                foreach(DataRow dataRow in dataTableAreas.Rows)
                {
                    Area area = new Area();

                    area.CodArea = (int)dataRow["CodArea"];
                    area.Descricao = (string)dataRow["Descricao"];

                    areaList.Add(area);
                }

                return areaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carrega  areas
        public Area CarregaArea(string Descricao)
        {
            try
            {
                Area area = new Area();
                area.Descricao = "";

                acesso.LimparParametros();
                DataTable dataTableAreas = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodArea, Descricao FROM tblArea WHERE Descricao = '"+Descricao+"'");

                foreach (DataRow dataRow in dataTableAreas.Rows)
                {
                    area.CodArea = (int)dataRow["CodArea"];
                    area.Descricao = (string)dataRow["Descricao"];
                }

                return area;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
