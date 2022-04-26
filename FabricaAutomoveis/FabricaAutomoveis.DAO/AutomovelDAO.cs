using DTIDAO.Core;
using FabricaAutomoveis.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UtilDLL;

namespace FabricaAutomoveis.DAO
{
    public class AutomovelDAO : IDAOBase<Automovel, AutomovelDTO>
    {
        public string delete(Automovel dominio)
        {
            throw new NotImplementedException();
        }

        public Automovel Get(int id)
        {
            throw new NotImplementedException();
        }

        public AutomovelDTO GetDTO(int id)
        {
            throw new NotImplementedException();
        }

        public string insert(Automovel dominio)
        {
            var camposInsert = new ListaCampos();

            camposInsert.Add("NOME_AUTOMOVEL", Util.strNULL(dominio.nome_automovel));
            camposInsert.Add("DATA_FABRICACAO", dominio.data_fabricacao, typeof(DateTime));
            camposInsert.Add("TANQUE", Util.intNULL(dominio.tanque_combustivel));
            camposInsert.Add("KM_LITRO", Util.intNULL(dominio.km_por_litro));
        }

        public List<AutomovelDTO> Listar(NTIFiltro filtro)
        {
            throw new NotImplementedException();
        }

        public string update(Automovel dominio)
        {
            throw new NotImplementedException();
        }
    }
}
