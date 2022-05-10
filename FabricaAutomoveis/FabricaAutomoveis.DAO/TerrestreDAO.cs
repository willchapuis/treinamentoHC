using DAO;
using DTIDAO.Core;
using FabricaAutomoveis.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UtilDLL;

namespace FabricaAutomoveis.DAO
{
    public class TerrestreDAO : IDAOBase<Terrestre, TerrestreDTO>
    {
        public string delete(Terrestre dominio)
        {
            var sqlString = $"DELETE FROM TERRESTRE WHERE ID_AUTOMOVEL = {dominio.Auto.id_automovel}";
            return BDOracle.executaComandoCommit(sqlString);
        }

        public Terrestre Get(int id)
        {
            var sqlString = "SELECT ID_AUTOMOVEL, " +
                            "NOME_AUTOMOVEL, " +
                            "DATA_FABRICACAO, " +
                            "TANQUE_COMBUSTIVEL, " +
                            "KM_LITRO, " +
                            "NRO_RODAS, " +
                            "ESTEPE " +
                            "FROM TERRESTRE " +
                            $"WHERE ID_AUTOMOVEL = {id}";

            var dt = BDOracle.getDataTable(sqlString);

            try
            {
                var registro = dt.Rows[0];
                var veiculo = new Terrestre();
                veiculo.Auto = new Automovel();

                veiculo.Auto.id_automovel = Convert.ToInt32(registro["ID_AUTOMOVEL"]);
                veiculo.Auto.nome_automovel = registro["NOME_AUTOMOVEL"].ToString();
                veiculo.Auto.data_fabricacao = Convert.ToDateTime(registro["DATA_FABRICACAO"]);
                veiculo.Auto.tanque_combustivel = Convert.ToInt32(registro["TANQUE_COMBUSTIVEL"]);
                veiculo.Auto.km_por_litro = Convert.ToInt32(registro["KM_LITRO"]);
                veiculo.nro_rodas = Convert.ToInt32(registro["NRO_RODAS"]);
                veiculo.estepe = Convert.ToBoolean(Convert.ToInt32(registro["ESTEPE"]));

                return veiculo;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public TerrestreDTO GetDTO(int id)
        {
            var sqlString = "SELECT ID_AUTOMOVEL, " +
                            "NOME_AUTOMOVEL, " +
                            "DATA_FABRICACAO, " +
                            "TANQUE_COMBUSTIVEL, " +
                            "KM_LITRO, " +
                            "NRO_RODAS, " +
                            "ESTEPE " +
                            "FROM TERRESTRE " +
                            $"WHERE ID_AUTOMOVEL = {id}";

            var dt = BDOracle.getDataTable(sqlString);

            try
            {
                var registro = dt.Rows[0];
                var veiculo = new TerrestreDTO();

                veiculo.id_automovel = Convert.ToInt32(registro["ID_AUTOMOVEL"]);
                veiculo.nome_automovel = registro["NOME_AUTOMOVEL"].ToString();
                veiculo.data_fabricacao = Convert.ToDateTime(registro["DATA_FABRICACAO"]);
                veiculo.tanque_combustivel = Convert.ToInt32(registro["TANQUE_COMBUSTIVEL"]);
                veiculo.km_por_litro = Convert.ToInt32(registro["KM_LITRO"]);
                veiculo.nro_rodas = Convert.ToInt32(registro["NRO_RODAS"]);
                veiculo.estepe = Convert.ToBoolean(Convert.ToInt32(registro["ESTEPE"]));

                return veiculo;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string insert(Terrestre dominio)
        {
            var camposInsert = new ListaCampos();
            camposInsert.Add("NOME_AUTOMOVEL", Util.strNULL(dominio.Auto.nome_automovel));
            camposInsert.Add("DATA_FABRICACAO", dominio.Auto.data_fabricacao, typeof(DateTime));
            camposInsert.Add("TANQUE_COMBUSTIVEL", Util.intNULL(dominio.Auto.tanque_combustivel));
            camposInsert.Add("KM_LITRO", Util.intNULL(dominio.Auto.km_por_litro));
            camposInsert.Add("NRO_RODAS", Util.intNULL(dominio.nro_rodas));
            //estepe está correto ?
            camposInsert.Add("ESTEPE", Util.intNULL(Convert.ToInt32(dominio.estepe)));

            var nomeTabela = "TERRESTRE";
            var sqlString = Util.montaSQLInsert(nomeTabela, camposInsert);

            var id = 0;
            var retorno = BDOracle.executaComandoCommitHandle(sqlString, "ID_AUTOMOVEL", ref id);
            dominio.Auto.id_automovel = id;

            return retorno;
        }

        public List<TerrestreDTO> Listar(NTIFiltro filtro)
        {
            var sqlString = "SELECT ID_AUTOMOVEL, " +
                            "NOME_AUTOMOVEL, " +
                            "DATA_FABRICACAO, " +
                            "TANQUE_COMBUSTIVEL, " +
                            "KM_LITRO, " +
                            "NRO_RODAS, " +
                            "ESTEPE " +
                            "FROM TERRESTRE " +
                            "WHERE 1 = 1";

            if (filtro != null)
                sqlString += filtro.getExpressoes();

            var dt = BDOracle.getDataTable(sqlString);

            var lista = dt.DataTableToList<TerrestreDTO>();

            return lista;
        }

        public string update(Terrestre dominio)
        {
            var CamposUpdate = new ListaCampos();

            CamposUpdate.Add("NOME_AUTOMOVEL", Util.strNULL(dominio.Auto.nome_automovel));
            CamposUpdate.Add("DATA_FABRICACAO", dominio.Auto.data_fabricacao, typeof(DateTime));
            CamposUpdate.Add("TANQUE_COMBUSTIVEL", Util.intNULL(dominio.Auto.tanque_combustivel));
            CamposUpdate.Add("KM_LITRO", Util.intNULL(dominio.Auto.km_por_litro));
            CamposUpdate.Add("NRO_RODAS", Util.intNULL(dominio.nro_rodas));
            CamposUpdate.Add("ESTEPE", Util.intNULL(Convert.ToInt32(dominio.estepe)));

            var nomeTabela = "TERRESTRE";
            var sqlString = Util.montaSQLUpdate(nomeTabela, CamposUpdate);
            sqlString += $" ID_AUTOMOVEL = {dominio.Auto.id_automovel}";

            return BDOracle.executaComandoCommit(sqlString);
        }
    }
}
