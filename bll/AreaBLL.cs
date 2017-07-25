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
        public string AreaInserir(string descricao)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Descricao", descricao.ToUpper());
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
                acesso.AdicionarParametros("@Descricao", area.Descricao.ToUpper());
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
        public string AreaExcluir(int codArea)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", codArea);
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
                    area.Descricao = ((string)dataRow["Descricao"]).ToUpper();
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
        public Area CarregaArea(string descricao)
        {
            try
            {
                Area area = new Area();
                area.Descricao = "";
                acesso.LimparParametros();
                DataTable dataTableAreas = acesso.ExecutarConsulta(CommandType.Text,
                    "SELECT CodArea, Descricao FROM tblArea WHERE Descricao = '"+descricao+"'");
                foreach (DataRow dataRow in dataTableAreas.Rows)
                {
                    area.CodArea = (int)dataRow["CodArea"];
                    area.Descricao = ((string)dataRow["Descricao"]).ToUpper();
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
