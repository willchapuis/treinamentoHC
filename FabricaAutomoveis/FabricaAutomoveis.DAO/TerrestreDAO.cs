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
            throw new NotImplementedException();
        }

        public Terrestre Get(int id)
        {
            throw new NotImplementedException();
        }

        public TerrestreDTO GetDTO(int id)
        {
            throw new NotImplementedException();
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
            camposInsert.Add("ESTEPE", dominio.estepe, typeof(Boolean));

            var nomeTabela = "TERRESTRE";
            var sqlString = Util.montaSQLInsert(nomeTabela, camposInsert);

            var id = 0;
            var retorno = BDOracle.executaComandoCommitHandle(sqlString, "ID_ANIMAL", ref id);
            //dominio.idAnimal = id;

            return retorno;
        }

        public List<TerrestreDTO> Listar(NTIFiltro filtro)
        {
            throw new NotImplementedException();
        }

        public string update(Terrestre dominio)
        {
            throw new NotImplementedException();
        }
    }
}
