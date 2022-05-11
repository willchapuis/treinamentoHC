using DAO;
using FabricaAutomoveis.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace ExemploAPI.Models
{
    public class Terrestre
    {
        public string Get(int id)
        {
            string sqlString = "SELECT " +
                                "ID_AUTOMOVEL, " +
                                "NOME_AUTOMOVEL, " +
                                "TO_CHAR(DATA_FABRICACAO, 'DD/MM/RRRR') DATA_FABRICACAO, " +
                                "TANQUE_COMBUSTIVEL, " +
                                "KM_LITRO, " +
                                "NRO_RODAS, " +
                                "ESTEPE " +
                                "FROM TERRESTRE " +
                                $"WHERE ID_AUTOMOVEL = {id}";

            var dt = BDOracle.getDataTable(sqlString);

            TerrestreDTO automovel = new TerrestreDTO();

            try
            {
                DataRow reg = dt.Rows[0];

                automovel.id_automovel = Convert.ToInt32(reg["ID_AUTOMOVEL"]);
                automovel.nome_automovel = reg["NOME_AUTOMOVEL"].ToString();
                automovel.data_fabricacao = Convert.ToDateTime(reg["DATA_FABRICACAO"]);
                automovel.tanque_combustivel = Convert.ToInt32(reg["TANQUE_COMBUSTIVEL"]);
                automovel.km_por_litro = Convert.ToInt32(reg["KM_LITRO"]);
                automovel.nro_rodas = Convert.ToInt32(reg["NRO_RODAS"]);
                automovel.estepe = Convert.ToBoolean(Convert.ToInt32(reg["ESTEPE"]));
                return JObject.FromObject(automovel).ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string Listar()
        {
            string sqlString = "SELECT " +
                                "ID_AUTOMOVEL, " +
                                "NOME_AUTOMOVEL, " +
                                "TO_CHAR(DATA_FABRICACAO, 'DD/MM/RRRR') DATA_FABRICACAO, " +
                                "TANQUE_COMBUSTIVEL, " +
                                "KM_LITRO, " +
                                "NRO_RODAS, " +
                                "ESTEPE " +
                                "FROM TERRESTRE " +
                                "WHERE 1 = 1";

            var dt = BDOracle.getDataTable(sqlString);

            try
            {
                TerrestreDTO automovel;
                DataRow reg;
                var lista = new List<TerrestreDTO>();

                for ( ; lista.Count<dt.Rows.Count; )
                {
                    reg = dt.Rows[lista.Count];

                    automovel = new TerrestreDTO();

                    automovel.id_automovel = Convert.ToInt32(reg["ID_AUTOMOVEL"]);
                    automovel.nome_automovel = reg["NOME_AUTOMOVEL"].ToString();
                    automovel.data_fabricacao = Convert.ToDateTime(reg["DATA_FABRICACAO"]);
                    automovel.tanque_combustivel = Convert.ToInt32(reg["TANQUE_COMBUSTIVEL"]);
                    automovel.km_por_litro = Convert.ToInt32(reg["KM_LITRO"]);
                    automovel.nro_rodas = Convert.ToInt32(reg["NRO_RODAS"]);
                    automovel.estepe = Convert.ToBoolean(Convert.ToInt32(reg["ESTEPE"]));

                    lista.Add(automovel);
                }

                return JArray.FromObject(lista).ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string Delete(int id)
        {
            string sqlString = $"DELETE FROM TERRESTRE WHERE ID_AUTOMOVEL = {id}";
            return BDOracle.executaComandoCommit(sqlString);
        }

        public string Post(TerrestreDTO auto)
        {
            string sqlString = "INSERT INTO TERRESTRE (NOME_AUTOMOVEL, DATA_FABRICACAO, TANQUE_COMBUSTIVEL, KM_LITRO, NRO_RODAS, ESTEPE) values(" +
                                $"'{auto.nome_automovel}', " +
                                $"TO_DATE('{auto.data_fabricacao.ToShortDateString()}', 'DD/MM/RRRR'), " +
                                $"{auto.tanque_combustivel}, " +
                                $"{auto.km_por_litro}, " +
                                $"{auto.nro_rodas}, " +
                                $"{Convert.ToInt32(auto.estepe)})";

            var id = 0;
            var retorno = BDOracle.executaComandoCommitHandle(sqlString, "ID_AUTOMOVEL", ref id);
            auto.id_automovel = id;

            return retorno;
        }

        public string Update(int id, TerrestreDTO auto)
        {
            string sqlString = "SELECT " +
                                "ID_AUTOMOVEL, " +
                                "NOME_AUTOMOVEL, " +
                                "TO_CHAR(DATA_FABRICACAO, 'DD/MM/RRRR') DATA_FABRICACAO, " +
                                "TANQUE_COMBUSTIVEL, " +
                                "KM_LITRO, " +
                                "NRO_RODAS, " +
                                "ESTEPE " +
                                "FROM TERRESTRE " +
                                $"WHERE ID_AUTOMOVEL = {id}";

            var dt = BDOracle.getDataTable(sqlString);

            TerrestreDTO automovel = new TerrestreDTO();

            try
            {
                DataRow reg = dt.Rows[0];

                automovel.id_automovel = Convert.ToInt32(reg["ID_AUTOMOVEL"]);
                automovel.nome_automovel = reg["NOME_AUTOMOVEL"].ToString();
                automovel.data_fabricacao = Convert.ToDateTime(reg["DATA_FABRICACAO"]);
                automovel.tanque_combustivel = Convert.ToInt32(reg["TANQUE_COMBUSTIVEL"]);
                automovel.km_por_litro = Convert.ToInt32(reg["KM_LITRO"]);
                automovel.nro_rodas = Convert.ToInt32(reg["NRO_RODAS"]);
                automovel.estepe = Convert.ToBoolean(Convert.ToInt32(reg["ESTEPE"]));

                sqlString = "UPDATE TERRESTRE SET " +
                            $"(NOME_AUTOMOVEL)=('{auto.nome_automovel}'), " +
                            $"(DATA_FABRICACAO)=(TO_DATE('{auto.data_fabricacao.ToShortDateString()}', 'DD/MM/RRRR')), " +
                            $"(TANQUE_COMBUSTIVEL)=({automovel.tanque_combustivel}), " +
                            $"(KM_LITRO)=({automovel.km_por_litro}), " +
                            $"(NRO_RODAS)=({automovel.nro_rodas}), " +
                            $"(ESTEPE)=({Convert.ToInt32(automovel.estepe)}) " +
                            $"WHERE ID_AUTOMOVEL = {id}";

                return BDOracle.executaComandoCommit(sqlString);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}