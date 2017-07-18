using DAL;
using DTO.Infraestrutura_de_Midia;
using DTO.Midia;
using System;
using System.Data;

namespace BLL
{
    public class MidiaBLL
    {
        AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        //Inserir outro exemplar de uma midia ja existenta no sistema
        public string MidiaInserirCopia(Midia midia)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", midia.CodMidia);
                acesso.AdicionarParametros("@TipoMidia", midia.TipoMidia);
                acesso.AdicionarParametros("@Disponivel", midia.Disponivel);
                acesso.AdicionarParametros("@TipoTombo", midia.TipoTombo);
                acesso.AdicionarParametros("@Observacao", midia.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspMidiaInserirCopia");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Excluir Midia
        public string MidiaExcluir(int? Tombo, string TipoMidia)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                acesso.AdicionarParametros("@TipoMidia", TipoMidia);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspMidiaExcluir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Inserir o TCC
        public string TCCInserir(Tcc tcc)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodCurso", tcc.Curso.CodCurso);
                acesso.AdicionarParametros("@Titulo", tcc.Titulo);
                acesso.AdicionarParametros("@DataPublicacao", tcc.DataPublicacao);
                acesso.AdicionarParametros("@CodArea", tcc.Area.CodArea);
                acesso.AdicionarParametros("@Localizacao", tcc.Localizacao);
                acesso.AdicionarParametros("@Lingua", tcc.Lingua);
                acesso.AdicionarParametros("@Observacao", tcc.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspTCCInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar o TCC
        public string TCCAlterar(Tcc tcc)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", tcc.CodMidia);
                acesso.AdicionarParametros("@CodCurso", tcc.Curso.CodCurso);
                acesso.AdicionarParametros("@Titulo", tcc.Titulo);
                acesso.AdicionarParametros("@DataPublicacao", tcc.DataPublicacao);
                acesso.AdicionarParametros("@CodArea", tcc.Area.CodArea);
                acesso.AdicionarParametros("@Localizacao", tcc.Localizacao);
                acesso.AdicionarParametros("@Lingua", tcc.Lingua);
                acesso.AdicionarParametros("@Observacao", tcc.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspTCCAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta TCC por Titulo
        public TccList TCCConsultar_PorTitulo(string Titulo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Titulo", Titulo);

                DataTable dataTableTCC = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspTCCConsultar_PorTitulo");
                return TCCCarregaLista(dataTableTCC);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta TCC por Curso
        public TccList TCCConsultar_PorCurso(int CodCurso)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodCurso", CodCurso);

                DataTable dataTableTCC = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspTCCConsultar_PorCurso");
                return TCCCarregaLista(dataTableTCC);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta TCC por Tombo
        public Tcc TCCConsultar_PorTombo(int Tombo)
        {
            try
            {
                Tcc tcc = new Tcc();
                tcc.CodMidia = 0;

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);

                DataTable dataTableTCC = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspTCCConsultar_PorTombo");

                foreach(Tcc tccPesq in TCCCarregaLista(dataTableTCC))
                {
                    tcc = tccPesq;
                }

                return tcc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta TCC por Area
        public TccList TCCConsultar_PorArea(int CodArea)
        {
            try
            {
                Tcc tcc = new Tcc();

                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodTombo", CodArea);

                DataTable dataTableTCC = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspTCCConsultar_PorArea");
                return TCCCarregaLista(dataTableTCC);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de TCC
        private TccList TCCCarregaLista(DataTable dataTableTCC)
        {
            try
            {
                TccList tccList = new TccList();
                foreach(DataRow dataRow in dataTableTCC.Rows)
                {
                    Tcc tcc = new Tcc();
                    tcc.Curso.Descricao = (string)dataRow["Curso"];
                    tcc.Curso.CodCurso = (int)dataRow["CodCurso"];
                    tcc.CodMidia = (int)dataRow["CodTCC"];
                    tcc.Titulo = (string)dataRow["Titulo"];
                    tcc.DataPublicacao = (DateTime)dataRow["DataPublicacao"];
                    tcc.Localizacao = (string)dataRow["Localizacao"];
                    tcc.Lingua = (string)dataRow["Lingua"];
                    tcc.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    tcc.Tombo = (int)dataRow["Tombo"];
                    tcc.Observacao = (string)dataRow["Observacao"];
                    tcc.Area.Descricao = (string)dataRow["Área"];
                    tcc.Area.CodArea = (int)dataRow["CodArea"];
                    tccList.Add(tcc);
                }
                return tccList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Inserir o Mapa
        public string MapaInserir(Mapa mapa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Especificacao", mapa.Especificacao);
                acesso.AdicionarParametros("@CodArea", mapa.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", mapa.Disponivel);
                acesso.AdicionarParametros("@Localizacao", mapa.Localizacao);
                acesso.AdicionarParametros("@Lingua", mapa.Lingua);
                acesso.AdicionarParametros("@TipoTombo", mapa.TipoTombo);
                acesso.AdicionarParametros("@Observacao", mapa.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspMapaInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar o Mapa
        public string MapaAlterar(Mapa mapa)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", mapa.CodMidia);
                acesso.AdicionarParametros("@Especificacao", mapa.Especificacao);
                acesso.AdicionarParametros("@CodArea", mapa.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", mapa.Disponivel);
                acesso.AdicionarParametros("@Localizacao", mapa.Localizacao);
                acesso.AdicionarParametros("@Lingua", mapa.Lingua);
                acesso.AdicionarParametros("@TipoTombo", mapa.TipoTombo);
                acesso.AdicionarParametros("@Observacao", mapa.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspMapaAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Mapa por Especificação
        public MapaList MapaConsultar_PorEspecificacao(string Especificacao)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Especificacao", Especificacao);

                DataTable dataTableMapas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMapaConsultar_PorEspecificacao");

                return MapaCarregaLista(dataTableMapas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Mapa por Especificação com quantidade
        public MapaList MapaConsultar_PorEspecificacaoQuant(string Especificacao)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Especificacao", Especificacao);

                DataTable dataTableMapas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMapaConsultar_PorEspecificacaoQuant");

                return MapaCarregaListaQuant(dataTableMapas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Mapa por Tombo
        public Mapa MapaConsultar_PorTombo(int Tombo)
        {
            try
            {
                Mapa mapa = new Mapa();
                mapa.CodMidia = 0;

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);

                DataTable dataTableMapas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMapaConsultar_PorTombo");

                foreach(Mapa mapaPesq in MapaCarregaLista(dataTableMapas))
                {
                    mapa = mapaPesq;
                }

                return mapa;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Mapa por Tombo com quantidade
        public Mapa MapaConsultar_PorTomboQuant(int Tombo)
        {
            try
            {
                Mapa mapa = new Mapa();
                mapa.CodMidia = 0;
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);

                DataTable dataTableMapas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMapaConsultar_PorTomboQuant");

                foreach (Mapa mapaPesq in MapaCarregaLista(dataTableMapas))
                {
                    mapa = mapaPesq;
                }

                return mapa;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Mapa por Area
        public MapaList MapaConsultar_PorArea(int CodArea)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", CodArea);

                DataTable dataTableMapas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMapaConsultar_PorArea");

                return MapaCarregaLista(dataTableMapas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Mapa por Area com quantidade
        public MapaList MapaConsultar_PorAreaQuant(int CodArea)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", CodArea);

                DataTable dataTableMapas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMapaConsultar_PorAreaQuant");

                return MapaCarregaListaQuant(dataTableMapas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de Mapas
        private MapaList MapaCarregaLista(DataTable dataTableMapas)
        {
            try
            {
                MapaList mapaList = new MapaList();
                foreach(DataRow dataRow in dataTableMapas.Rows)
                {
                    Mapa mapa = new Mapa();
                    mapa.CodMidia = (int)dataRow["CodMapa"];
                    mapa.Especificacao = (string)dataRow["Especificacao"];
                    mapa.Localizacao = (string)dataRow["Localizacao"];
                    mapa.Lingua = (string)dataRow["Lingua"];
                    mapa.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    mapa.TipoTombo = (string)dataRow["TipoTombo"];
                    mapa.Disponivel = (bool)dataRow["Disponivel"];
                    mapa.Tombo = (int)dataRow["Tombo"];
                    mapa.Observacao = (string)dataRow["Observacao"];
                    mapa.Area.Descricao = (string)dataRow["Área"];
                    mapa.Area.CodArea = (int)dataRow["CodArea"];
                    mapaList.Add(mapa);
                }
                return mapaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de Mapas com quantidade
        private MapaList MapaCarregaListaQuant(DataTable dataTableMapas)
        {
            try
            {
                MapaList mapaList = new MapaList();

                foreach (DataRow dataRow in dataTableMapas.Rows)
                {
                    Mapa mapa = new Mapa();
                    
                    mapa.Especificacao = (string)dataRow["Especificacao"];
                    mapa.Localizacao = (string)dataRow["Localizacao"];
                    mapa.Lingua = (string)dataRow["Lingua"];
                    mapa.Quantidade = (int)dataRow["Quantidade"];
                    mapa.Area.Descricao = (string)dataRow["Área"];

                    mapaList.Add(mapa);
                }

                return mapaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Inserir o Jornal
        public string JornalInserir(JornalEx jornal)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodJornal", jornal.Jornal_.CodJornal);
                acesso.AdicionarParametros("@Manchete", jornal.Manchete);
                acesso.AdicionarParametros("@DataPublicacao", jornal.DataPublicacao);
                acesso.AdicionarParametros("@CodArea", jornal.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", jornal.Disponivel);
                acesso.AdicionarParametros("@Localizacao", jornal.Localizacao);
                acesso.AdicionarParametros("@Lingua", jornal.Lingua);
                acesso.AdicionarParametros("@TipoTombo", jornal.TipoTombo);
                acesso.AdicionarParametros("@Observacao", jornal.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspJornalExInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar o Jornal
        public string JornalAlterar(JornalEx jornal)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", jornal.CodMidia);
                acesso.AdicionarParametros("@CodJornal", jornal.Jornal_.CodJornal);
                acesso.AdicionarParametros("@Manchete", jornal.Manchete);
                acesso.AdicionarParametros("@DataPublicacao", jornal.DataPublicacao);
                acesso.AdicionarParametros("@CodArea", jornal.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", jornal.Disponivel);
                acesso.AdicionarParametros("@Localizacao", jornal.Localizacao);
                acesso.AdicionarParametros("@Lingua", jornal.Lingua);
                acesso.AdicionarParametros("@TipoTombo", jornal.TipoTombo);
                acesso.AdicionarParametros("@Observacao", jornal.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspJornalExAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Jornal por Manchete
        public JornalExList JornalConsultar_PorManchete(string Manchete)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Manchete", Manchete);
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspJornalExConsultar_PorManchete");

                return JornalCarregaLista(dataTableJornais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Jornal por Manchete com quantidade
        public JornalExList JornalConsultar_PorMancheteQuant(string Manchete)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Manchete", Manchete);
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspJornalExConsultar_PorMancheteQuant");

                return JornalCarregaListaQuant(dataTableJornais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Jornal por Jornal
        public JornalExList JornalConsultar_PorJornal(string Nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspJornalExConsultar_PorJornal");

                return JornalCarregaLista(dataTableJornais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Jornal por Jornal com quantidade
        public JornalExList JornalConsultar_PorJornalQuant(string Nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspJornalExConsultar_PorJornalQuant");

                return JornalCarregaListaQuant(dataTableJornais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Jornal por Tombo
        public JornalEx JornalConsultar_PorTombo(int Tombo)
        {
            try
            {
                JornalEx jornal = new JornalEx();
                jornal.CodMidia = 0;
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspJornalExConsultar_PorTombo");

                foreach(JornalEx jornalPesq in JornalCarregaLista(dataTableJornais))
                {
                    jornal = jornalPesq;
                }

                return jornal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Jornal por Tombo com quantidade
        public JornalEx JornalConsultar_PorTomboQuant(int Tombo)
        {
            try
            {
                JornalEx jornal = new JornalEx();
                jornal.CodMidia = 0;
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspJornalExConsultar_PorTomboQuant");

                foreach (JornalEx jornalPesq in JornalCarregaLista(dataTableJornais))
                {
                    jornal = jornalPesq;
                }

                return jornal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Jornal por Area
        public JornalExList JornalConsultar_PorArea(int CodArea)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", CodArea);
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspJornalExConsultar_PorArea");

                return JornalCarregaLista(dataTableJornais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Jornal por Area com quantidade
        public JornalExList JornalConsultar_PorAreaQuant(int CodArea)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", CodArea);
                DataTable dataTableJornais = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspJornalExConsultar_PorAreaQuant");

                return JornalCarregaListaQuant(dataTableJornais);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de jornais
        public JornalExList JornalCarregaLista(DataTable dataTableJornais)
        {
            try
            {
                JornalExList jornalList = new JornalExList();

                foreach(DataRow dataRow in dataTableJornais.Rows)
                {
                    JornalEx jornal = new JornalEx();

                    jornal.CodMidia = (int)dataRow["CodJornalEx"];
                    jornal.Manchete = (string)dataRow["Manchete"];
                    jornal.DataPublicacao = (DateTime)dataRow["Data de publicação"];
                    jornal.Jornal_.Nome = (string)dataRow["Jornal"];
                    jornal.Jornal_.CodJornal = (int)dataRow["CodJornal"];
                    jornal.Localizacao = (string)dataRow["Localizacao"];
                    jornal.Lingua = (string)dataRow["Lingua"];
                    jornal.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    jornal.TipoTombo = (string)dataRow["TipoTombo"];
                    jornal.Disponivel = (bool)dataRow["Disponivel"];
                    jornal.Tombo = (int)dataRow["Tombo"];
                    jornal.Observacao = (string)dataRow["Observacao"];
                    jornal.Area.Descricao = (string)dataRow["Área"];
                    jornal.Area.CodArea = (int)dataRow["CodArea"];

                    jornalList.Add(jornal);
                }

                return jornalList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de jornais com quantidade
        public JornalExList JornalCarregaListaQuant(DataTable dataTableJornais)
        {
            try
            {
                JornalExList jornalList = new JornalExList();

                foreach (DataRow dataRow in dataTableJornais.Rows)
                {
                    JornalEx jornal = new JornalEx();
                    
                    jornal.Manchete = (string)dataRow["Manchete"];
                    jornal.DataPublicacao = (DateTime)dataRow["DataPublicacao"];
                    jornal.Jornal_.Nome = (string)dataRow["Jornal"];
                    jornal.Localizacao = (string)dataRow["Localizacao"];
                    jornal.Lingua = (string)dataRow["Lingua"];
                    jornal.Quantidade = (int)dataRow["Quantidade"];
                    jornal.Area.Descricao = (string)dataRow["Área"];

                    jornalList.Add(jornal);
                }

                return jornalList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Inserir a Revista
        public string RevistaInserir(RevistaEx revista)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodRevista", revista.Revista_.CodRevista);
                acesso.AdicionarParametros("@Titulo", revista.Titulo);
                acesso.AdicionarParametros("@Edicao", revista.Edicao);
                acesso.AdicionarParametros("@CodArea", revista.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", revista.Disponivel);
                acesso.AdicionarParametros("@Localizacao", revista.Localizacao);
                acesso.AdicionarParametros("@Lingua", revista.Lingua);
                acesso.AdicionarParametros("@TipoTombo", revista.TipoTombo);
                acesso.AdicionarParametros("@Observacao", revista.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspRevistaExInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar a Revista
        public string RevistaAlterar(RevistaEx revista)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", revista.CodMidia);
                acesso.AdicionarParametros("@CodRevista", revista.Revista_.CodRevista);
                acesso.AdicionarParametros("@Titulo", revista.Titulo);
                acesso.AdicionarParametros("@Edicao", revista.Edicao);
                acesso.AdicionarParametros("@CodArea", revista.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", revista.Disponivel);
                acesso.AdicionarParametros("@Localizacao", revista.Localizacao);
                acesso.AdicionarParametros("@Lingua", revista.Lingua);
                acesso.AdicionarParametros("@TipoTombo", revista.TipoTombo);
                acesso.AdicionarParametros("@Observacao", revista.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspRevistaExAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Revista Por Nome
        public RevistaExList RevistaConsultar_PorNome(string Nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);
                DataTable dataTableRevistas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRevistaExConsultar_PorNome");

                return RevistaCarregaLista(dataTableRevistas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Revista Por Nome com quantidade
        public RevistaExList RevistaConsultar_PorNomeQuant(string Nome)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Nome", Nome);
                DataTable dataTableRevistas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRevistaExConsultar_PorNomeQuant");

                return RevistaCarregaListaQuant(dataTableRevistas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Revista Por Editora
        public RevistaExList RevistaConsultar_PorEditora(string Editora)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Editora", Editora);
                DataTable dataTableRevistas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRevistaExConsultar_PorEditora");

                return RevistaCarregaLista(dataTableRevistas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Revista Por Editora com quantidade
        public RevistaExList RevistaConsultar_PorEditoraQuant(string Editora)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Editora", Editora);
                DataTable dataTableRevistas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRevistaExConsultar_PorEditoraQuant");

                return RevistaCarregaListaQuant(dataTableRevistas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Revista Por Tombo
        public RevistaEx RevistaConsultar_PorTombo(int Tombo)
        {
            try
            {
                RevistaEx revista = new RevistaEx();
                revista.CodMidia = 0;

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                DataTable dataTableRevistas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRevistaExConsultar_PorTombo");

                foreach(RevistaEx revistaPesq in RevistaCarregaLista(dataTableRevistas))
                {
                    revista = revistaPesq;
                }

                return revista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Revista Por Tombo com quantidade
        public RevistaEx RevistaConsultar_PorTomboQuant(int Tombo)
        {
            try
            {
                RevistaEx revista = new RevistaEx();
                revista.CodMidia = 0;

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                DataTable dataTableRevistas = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspRevistaExConsultar_PorTomboQuant");

                foreach (RevistaEx revistaPesq in RevistaCarregaLista(dataTableRevistas))
                {
                    revista = revistaPesq;
                }

                return revista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de Revistas
        private RevistaExList RevistaCarregaLista(DataTable dataTableRevistas)
        {
            try
            {
                RevistaExList revistaList = new RevistaExList();
                foreach(DataRow dataRow in dataTableRevistas.Rows)
                {
                    RevistaEx revista = new RevistaEx();
                    revista.CodMidia = (int)dataRow["CodRevistaEx"];
                    revista.Titulo = (string)dataRow["Titulo"];
                    revista.Edicao = (string)dataRow["Edicao"];
                    revista.Revista_.CodRevista = (int)dataRow["CodRevista"];
                    revista.Revista_.Nome = (string)dataRow["Revista"];
                    revista.Revista_.Editora.Nome = (string)dataRow["Editora"];
                    revista.Localizacao = (string)dataRow["Localizacao"];
                    revista.Lingua = (string)dataRow["Lingua"];
                    revista.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    revista.TipoTombo = (string)dataRow["TipoTombo"];
                    revista.Disponivel = (bool)dataRow["Disponivel"];
                    revista.Tombo = (int)dataRow["Tombo"];
                    revista.Observacao = (string)dataRow["Observacao"];
                    revista.Area.CodArea = (int)dataRow["CodArea"];
                    revista.Area.Descricao = (string)dataRow["Área"];
                    revistaList.Add(revista);
                }
                return revistaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de Revistas com quantidade
        private RevistaExList RevistaCarregaListaQuant(DataTable dataTableRevistas)
        {
            try
            {
                RevistaExList revistaList = new RevistaExList();

                foreach (DataRow dataRow in dataTableRevistas.Rows)
                {
                    RevistaEx revista = new RevistaEx();

                    revista.Titulo = (string)dataRow["Titulo"];
                    revista.Edicao = (string)dataRow["Edicao"];
                    revista.Revista_.Nome = (string)dataRow["Revista"];
                    revista.Revista_.Editora.Nome = (string)dataRow["Editora"];
                    revista.Localizacao = (string)dataRow["Localizacao"];
                    revista.Lingua = (string)dataRow["Lingua"];
                    revista.Quantidade = (int)dataRow["Quantidade"];
                    revista.Area.Descricao = (string)dataRow["Área"];

                    revistaList.Add(revista);
                }

                return revistaList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Inserir o CD/DVD
        public string CDVDInserir(CD_DVD cdvd)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Titulo", cdvd.Titulo);
                acesso.AdicionarParametros("@Descricao", "");
                acesso.AdicionarParametros("@CodArea", cdvd.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", cdvd.Disponivel);
                acesso.AdicionarParametros("@Localizacao", cdvd.Localizacao);
                acesso.AdicionarParametros("@Lingua", cdvd.Lingua);
                acesso.AdicionarParametros("@TipoTombo", cdvd.TipoTombo);
                acesso.AdicionarParametros("@Observacao", cdvd.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspCD_DVDInserir");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar o CD/DVD
        public string CDVDAlterar(CD_DVD cdvd)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", cdvd.CodMidia);
                acesso.AdicionarParametros("@Titulo", cdvd.Titulo);
                acesso.AdicionarParametros("@Descricao", "");
                acesso.AdicionarParametros("@CodArea", cdvd.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", cdvd.Disponivel);
                acesso.AdicionarParametros("@Localizacao", cdvd.Localizacao);
                acesso.AdicionarParametros("@Lingua", cdvd.Lingua);
                acesso.AdicionarParametros("@TipoTombo", cdvd.TipoTombo);
                acesso.AdicionarParametros("@Observacao", cdvd.Observacao);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspCD_DVDAlterar");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar CD/DVD por Titulo
        public CD_DVDList CDVDConsultar_PorTitulo(string Titulo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Titulo", Titulo);
                DataTable dataTableCDVD = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspCD_DVDConsultar_PorTitulo");

                return CDVDCarregaLista(dataTableCDVD); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar CD/DVD por Titulo com quantidade
        public CD_DVDList CDVDConsultar_PorTituloQuant(string Titulo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Titulo", Titulo);
                DataTable dataTableCDVD = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspCD_DVDConsultar_PorTituloQuant");

                return CDVDCarregaListaQuant(dataTableCDVD);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar CD/DVD por Tombo
        public CD_DVD CDVDConsultar_PorTombo(int Tombo)
        {
            try
            {
                CD_DVD cdvd = new CD_DVD();
                cdvd.CodMidia = 0;

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                DataTable dataTableCDVD = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspCD_DVDConsultar_PorTombo");

                foreach (CD_DVD cdPesq in CDVDCarregaLista(dataTableCDVD))
                {
                    cdvd = cdPesq;
                }
                return cdvd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar CD/DVD por Tombo com quantidade
        public CD_DVD CDVDConsultar_PorTomboQuant(int Tombo)
        {
            try
            {
                CD_DVD cdvd = new CD_DVD();
                cdvd.CodMidia = 0;

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                DataTable dataTableCDVD = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspCD_DVDConsultar_PorTomboQuant");

                foreach (CD_DVD cdPesq in CDVDCarregaLista(dataTableCDVD))
                {
                    cdvd = cdPesq;
                }
                return cdvd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar CD/DVD por Area
        public CD_DVDList CDVDConsultar_PorArea(int CodArea)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", CodArea);
                DataTable dataTableCDVD = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspCD_DVDConsultar_PorArea");

                return CDVDCarregaLista(dataTableCDVD);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar CD/DVD por Area com quantidade
        public CD_DVDList CDVDConsultar_PorAreaQuant(int CodArea)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", CodArea);
                DataTable dataTableCDVD = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspCD_DVDConsultar_PorAreaQuant");

                return CDVDCarregaListaQuant(dataTableCDVD);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de CD/DVD
        private CD_DVDList CDVDCarregaLista(DataTable dataTableCDVD)
        {
            try
            {
                CD_DVDList cdvdList = new CD_DVDList();

                foreach(DataRow dataRow in dataTableCDVD.Rows)
                {
                    CD_DVD cdvd = new CD_DVD();

                    cdvd.Titulo = (string)dataRow["Titulo"];
                    cdvd.Descricao = (string)dataRow["Descricao"];
                    cdvd.Localizacao = (string)dataRow["Localizacao"];
                    cdvd.Lingua = (string)dataRow["Lingua"];
                    cdvd.CodMidia = (int)dataRow["CodMidia"];
                    cdvd.DataCadastro = (DateTime)dataRow["DataCadastro"];
                    cdvd.TipoTombo = (string)dataRow["TipoTombo"];
                    cdvd.Disponivel = (bool)dataRow["Disponivel"];
                    cdvd.Tombo = (int)dataRow["Tombo"];
                    cdvd.Observacao = (string)dataRow["Observacao"];
                    cdvd.Area.CodArea = (int)dataRow["CodArea"];
                    cdvd.Area.Descricao = (string)dataRow["Área"];

                    cdvdList.Add(cdvd);
                }

                return cdvdList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de CD/DVD com quantidade
        private CD_DVDList CDVDCarregaListaQuant(DataTable dataTableCDVD)
        {
            try
            {
                CD_DVDList cdvdList = new CD_DVDList();

                foreach (DataRow dataRow in dataTableCDVD.Rows)
                {
                    CD_DVD cdvd = new CD_DVD();

                    cdvd.Titulo = (string)dataRow["Titulo"];
                    cdvd.Descricao = (string)dataRow["Descricao"];
                    cdvd.Localizacao = (string)dataRow["Localizacao"];
                    cdvd.Lingua = (string)dataRow["Lingua"];
                    cdvd.Quantidade = (int)dataRow["Quantidade"];
                    cdvd.Area.Descricao = (string)dataRow["Área"];

                    cdvdList.Add(cdvd);
                }

                return cdvdList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Inserir o Livro
        public string LivroInserir(Livro livro)
        {
            try
            {
                DataTable dataTableAutores = new DataTable();
                DataTable dataTableAssuntos = new DataTable();
                DataTable dataTableGeneros = new DataTable();

                dataTableAutores.Columns.Add("CodAutor", typeof(int));
                dataTableAssuntos.Columns.Add("CodAssunto", typeof(int));
                dataTableGeneros.Columns.Add("CodGenero", typeof(int));
                dataTableGeneros.Columns.Add("Principal", typeof(bool));

                foreach(Autor autor in livro.AutoreList)
                {
                    dataTableAutores.Rows.Add(autor.CodAutor);
                }

                foreach(Assunto assunto in livro.AssuntoList)
                {
                    dataTableAssuntos.Rows.Add(assunto.CodAssunto);
                }

                foreach(Genero genero in livro.GeneroList)
                {
                    dataTableGeneros.Rows.Add(genero.CodGenero, genero.Principal);
                }

                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodEditora", livro.Editora.CodEditora);
                acesso.AdicionarParametros("@Titulo", livro.Titulo);
                acesso.AdicionarParametros("@Subtitulo", livro.Subtitulo);
                acesso.AdicionarParametros("@Serie_Colecao", livro.Serie_Colecao);
                acesso.AdicionarParametros("@Edicao", livro.Edicao);
                acesso.AdicionarParametros("@Volume", livro.Volume);
                acesso.AdicionarParametros("@NPags", livro.Npags);
                acesso.AdicionarParametros("@Local", livro.Local);
                acesso.AdicionarParametros("@DataPublicacao", livro.DataPublicacao);
                acesso.AdicionarParametros("@Valor", livro.Valor);
                acesso.AdicionarParametros("@TipoLivro", livro.TipoLivro);
                acesso.AdicionarParametros("@CodArea", livro.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", livro.Disponivel);
                acesso.AdicionarParametros("@Localizacao", livro.Localizacao);
                acesso.AdicionarParametros("@Lingua", livro.Lingua);
                acesso.AdicionarParametros("@TipoTombo", livro.TipoTombo);
                acesso.AdicionarParametros("@Observacao", livro.Observacao);
                acesso.AdicionarParametrosEspecial("@Autores", dataTableAutores);
                acesso.AdicionarParametrosEspecial("@Assuntos", dataTableAssuntos);
                acesso.AdicionarParametrosEspecial("@Generos", dataTableGeneros);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspLivroInserir");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Alterar o Livro
        public string LivroAlterar(Livro livro)
        {
            try
            {
                DataTable dataTableAutores = new DataTable();
                DataTable dataTableAssuntos = new DataTable();
                DataTable dataTableGeneros = new DataTable();

                dataTableAutores.Columns.Add("CodAutor", typeof(int));
                dataTableAssuntos.Columns.Add("CodAssunto", typeof(int));
                dataTableGeneros.Columns.Add("CodGenero", typeof(int));
                dataTableGeneros.Columns.Add("Principal", typeof(bool));

                foreach (Autor autor in livro.AutoreList)
                {
                    dataTableAutores.Rows.Add(autor.CodAutor);
                }

                foreach (Assunto assunto in livro.AssuntoList)
                {
                    dataTableAssuntos.Rows.Add(assunto.CodAssunto);
                }

                foreach (Genero genero in livro.GeneroList)
                {
                    dataTableGeneros.Rows.Add(genero.CodGenero, false);
                }


                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodMidia", livro.CodMidia);
                acesso.AdicionarParametros("@CodEditora", livro.Editora.CodEditora);
                acesso.AdicionarParametros("@Titulo", livro.Titulo);
                acesso.AdicionarParametros("@Subtitulo", livro.Subtitulo);
                acesso.AdicionarParametros("@Serie_Colecao", livro.Serie_Colecao);
                acesso.AdicionarParametros("@Edicao", livro.Edicao);
                acesso.AdicionarParametros("@Volume", livro.Volume);
                acesso.AdicionarParametros("@NPags", livro.Npags);
                acesso.AdicionarParametros("@Local", livro.Local);
                acesso.AdicionarParametros("@DataPublicacao", livro.DataPublicacao);
                acesso.AdicionarParametros("@Valor", livro.Valor);
                acesso.AdicionarParametros("@TipoLivro", livro.TipoLivro);
                acesso.AdicionarParametros("@CodArea", livro.Area.CodArea);
                acesso.AdicionarParametros("@Disponivel", livro.Disponivel);
                acesso.AdicionarParametros("@Localizacao", livro.Localizacao);
                acesso.AdicionarParametros("@Lingua", livro.Lingua);
                acesso.AdicionarParametros("@TipoTombo", livro.TipoTombo);
                acesso.AdicionarParametros("@Observacao", livro.Observacao);
                acesso.AdicionarParametrosEspecial("@Autores", dataTableAutores);
                acesso.AdicionarParametrosEspecial("@Assuntos", dataTableAssuntos);
                acesso.AdicionarParametrosEspecial("@Generos", dataTableGeneros);
                return (string)acesso.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspLivroAlterar");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        //Limpa Listas do Livro
        public Livro LimpaListas(Livro livro)
        {
            try
            {
                Livro livroLimpa = new Livro();
                livro.AssuntoList = livroLimpa.AssuntoList;
                livro.AutoreList = livroLimpa.AutoreList;
                livro.GeneroList = livroLimpa.GeneroList;

                return livro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Tombo
        public Livro LivroConsultar_PorTombo(int Tombo)
        {
            try
            {
                Livro livro = new Livro();
                livro.CodMidia = 0;

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorTombo");

                foreach(Livro  livroPesq in LivroCarregaLista(dataTableLivros))
                {
                    livro = livroPesq;
                }
                return livro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Tombo com quantidade
        public Livro LivroConsultar_PorTomboQuant(int Tombo)
        {
            try
            {
                Livro livro = new Livro();
                livro.CodMidia = 0;

                acesso.LimparParametros();
                acesso.AdicionarParametros("@Tombo", Tombo);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorTomboQuant");

                foreach (Livro livroPesq in LivroCarregaLista(dataTableLivros))
                {
                    livro = livroPesq;
                }
                return livro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Titulo
        public LivroList LivroConsultar_PorTitulo(string Titulo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Titulo", Titulo);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorTitulo");

                return LivroCarregaLista(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Titulo com quantidade
        public LivroList LivroConsultar_PorTituloQuant(string Titulo)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Titulo", Titulo);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorTituloQuant");

                return LivroCarregaListaQuant(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Editora
        public LivroList LivroConsultar_PorEditora(string Editora)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Titulo", Editora);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorEditora");

                return LivroCarregaLista(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Editora com quantidade
        public LivroList LivroConsultar_PorEditoraQuant(string Editora)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Titulo", Editora);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorEditoraQuant");

                return LivroCarregaListaQuant(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Autor
        public LivroList LivroConsultar_PorAutor(int CodAutor)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodAutor", CodAutor);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorAutor");

                return LivroCarregaLista(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Autor com quantidade
        public LivroList LivroConsultar_PorAutorQuant(int CodAutor)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodAutor", CodAutor);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorAutorQuant");

                return LivroCarregaListaQuant(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Assuntos
        public LivroList LivroConsultar_PorAssunto(int CodAssunto)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodAssunto", CodAssunto);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorAssunto");

                return LivroCarregaLista(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Assuntos com quantidade
        public LivroList LivroConsultar_PorAssuntoQuant(int CodAssunto)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodAssunto", CodAssunto);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorAssuntoQuant");

                return LivroCarregaListaQuant(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Area
        public LivroList LivroConsultar_PorArea(int CodArea)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", CodArea);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorArea");

                return LivroCarregaLista(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Area com quantidade
        public LivroList LivroConsultar_PorAreaQuant(int CodArea)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodArea", CodArea);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorAreaQuant");

                return LivroCarregaListaQuant(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Genero
        public LivroList LivroConsultar_PorGenero(int Genero)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodGenero", Genero);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorGenero");

                return LivroCarregaLista(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Livro por Genero com quantidade
        public LivroList LivroConsultar_PorGeneroQuant(int Genero)
        {
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@CodGenero", Genero);
                DataTable dataTableLivros = acesso.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspLivroConsultar_PorGeneroQuant");

                return LivroCarregaListaQuant(dataTableLivros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de Livros
        private LivroList LivroCarregaLista(DataTable dataTableLivros)
        {
            try
            {
                AssuntosBLL assuntoBLL = new AssuntosBLL();
                AutorBLL autorBLL = new AutorBLL();
                GeneroBLL generoBLL = new GeneroBLL();
                LivroList livroList = new LivroList();

                foreach (DataRow dataRow in dataTableLivros.Rows)
                {
                    Livro livro = new Livro();

                    livro.CodMidia = (int)dataRow["CodLivro"];
                    livro.Titulo = (string)dataRow["Titulo"];

                    if (!DBNull.Value.Equals(dataRow["Subtitulo"]))
                    {
                        livro.Subtitulo = (string)dataRow["Subtitulo"];
                    }

                    if (!DBNull.Value.Equals(dataRow["Coleção"]))
                    {
                        livro.Serie_Colecao = (string)dataRow["Coleção"];
                    }

                    livro.Edicao = (string)dataRow["Edicao"];
                    livro.Volume = (string)dataRow["Volume"];
                    livro.Npags = (string)dataRow["Nº de Paginas"];
                    livro.Local = (string)dataRow["Local"];

                    if (!DBNull.Value.Equals(dataRow["DataPublicacao"]))
                    {
                        livro.DataPublicacao = (DateTime)dataRow["DataPublicacao"];
                    }
                    else
                    {
                        livro.DataPublicacao = DateTime.Now;
                    }

                    if (!DBNull.Value.Equals(dataRow["Valor"]))
                    {
                        livro.Valor = (float)(double)dataRow["Valor"];
                    }
                    else
                    {
                        livro.Valor = (float)00.00;
                    }

                    livro.TipoLivro = (string)dataRow["Tipo do Livro"];

                    if (!DBNull.Value.Equals(dataRow["Localizacao"]))
                    {
                        livro.Localizacao = (string)dataRow["Localizacao"];
                    }

                    if (!DBNull.Value.Equals(dataRow["Lingua"]))
                    {
                        livro.Lingua = (string)dataRow["Lingua"];
                    }
                    else
                    {
                        livro.Lingua = "Português-BR";
                    }

                    livro.DataCadastro = (DateTime)dataRow["Data de Cadastro"];
                    livro.TipoTombo = (string)dataRow["TipoTombo"];
                    livro.Tombo = (int)dataRow["Tombo"];
                    livro.TipoMidia = (string)dataRow["TipoMidia"];
                    livro.Disponivel = (bool)dataRow["Disponivel"];

                    if (!DBNull.Value.Equals(dataRow["Observacao"]))
                    {
                        livro.Observacao = (string)dataRow["Observacao"];
                    }

                    livro.Area.CodArea = (int)dataRow["CodArea"];
                    livro.Area.Descricao = (string)dataRow["Área"];
                    livro.Editora.CodEditora = (int)dataRow["CodEditora"];
                    livro.Editora.Nome = (string)dataRow["Editora"];

                    if (!DBNull.Value.Equals(dataRow["Genero"]))
                    {
                        livro.Genero = (string)dataRow["Genero"];
                    } 

                    livro.Autores = (string)dataRow["Autores"];
                    livro.Assuntos = (string)dataRow["Assuntos"];
                    livro.AutoreList = autorBLL.AutorConsultar_PorLivro(livro.CodMidia);
                    livro.AssuntoList = assuntoBLL.AssuntoConsultar(livro.CodMidia);
                    livro.GeneroList = generoBLL.CarregaGenerosLivro(livro.CodMidia);

                    livroList.Add(livro);
                }

                return livroList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Carregar dados do DataTable em uma lista de Livros com quantidade
        private LivroList LivroCarregaListaQuant(DataTable dataTableLivros)
        {
            try
            {
                AssuntosBLL assuntoBLL = new AssuntosBLL();
                AutorBLL autorBLL = new AutorBLL();
                GeneroBLL generoBLL = new GeneroBLL();
                LivroList livroList = new LivroList();

                foreach (DataRow dataRow in dataTableLivros.Rows)
                {
                    Livro livro = new Livro();

                    livro.CodMidia = (int)dataRow["CodLivro"];
                    livro.Titulo = (string)dataRow["Titulo"];

                    if (!DBNull.Value.Equals(dataRow["Subtitulo"]))
                    {
                        livro.Subtitulo = (string)dataRow["Subtitulo"];
                    }

                    if (!DBNull.Value.Equals(dataRow["Coleção"]))
                    {
                        livro.Serie_Colecao = (string)dataRow["Coleção"];
                    }

                    livro.Edicao = (string)dataRow["Edicao"];
                    livro.Volume = (string)dataRow["Volume"];
                    livro.Npags = (string)dataRow["Nº de Paginas"];
                    livro.Local = (string)dataRow["Local"];

                    if (!DBNull.Value.Equals(dataRow["DataPublicacao"]))
                    {
                        livro.DataPublicacao = (DateTime)dataRow["DataPublicacao"];
                    }
                    else
                    {
                        livro.DataPublicacao = DateTime.Now;
                    }

                    if (!DBNull.Value.Equals(dataRow["Valor"]))
                    {
                        livro.Valor = (float)(double)dataRow["Valor"];
                    }
                    else
                    {
                        livro.Valor = (float)00.00;
                    }

                    livro.TipoLivro = (string)dataRow["Tipo do Livro"];

                    if (!DBNull.Value.Equals(dataRow["Localizacao"]))
                    {
                        livro.Localizacao = (string)dataRow["Localizacao"];
                    }

                    if (!DBNull.Value.Equals(dataRow["Lingua"]))
                    {
                        livro.Lingua = (string)dataRow["Lingua"];
                    }
                    else
                    {
                        livro.Lingua = "Português-BR";
                    }
                    
                    livro.TipoMidia = (string)dataRow["TipoMidia"];
                    livro.Area.CodArea = (int)dataRow["CodArea"];
                    livro.Area.Descricao = (string)dataRow["Área"];
                    livro.Editora.CodEditora = (int)dataRow["CodEditora"];
                    livro.Editora.Nome = (string)dataRow["Editora"];

                    if (!DBNull.Value.Equals(dataRow["Genero"]))
                    {
                        livro.Genero = (string)dataRow["Genero"];
                    }

                    livro.Autores = (string)dataRow["Autores"];
                    livro.Assuntos = (string)dataRow["Assuntos"];
                    livro.AutoreList = autorBLL.AutorConsultar_PorLivro(livro.CodMidia);
                    livro.AssuntoList = assuntoBLL.AssuntoConsultar(livro.CodMidia);
                    livro.GeneroList = generoBLL.CarregaGenerosLivro(livro.CodMidia);

                    livroList.Add(livro);
                }

                return livroList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
