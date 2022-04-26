using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricaAutomoveis.Domain
{
    public class AutomovelDTO
    {
        public int id_automovel { get; set; }

        public string nome_automovel { get; set; }

        public DateTime data_fabricacao { get; set; }

        public int tanque_combustivel { get; set; }

        public int km_por_litro { get; set; }

    }
}
