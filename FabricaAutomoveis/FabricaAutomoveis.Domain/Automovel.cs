using DTIDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricaAutomoveis.Domain
{
    public class Automovel : DomainBase
    {
        public int id_automovel { get; set; }

        public string nome_automovel { get; set; }

        public DateTime data_fabricacao { get; set; }

        public int tanque_combustivel { get; set; }

        public int km_por_litro { get; set; }

        public override void Validar()
        {
            _regrasQuebradas.Clear();
            if (String.IsNullOrEmpty(nome_automovel))
                _regrasQuebradas.Add("O nome não pode ser vazio");
            //data
            if (tanque_combustivel <= 0)
                _regrasQuebradas.Add("O tanque deve ser maior que 0");
            if (km_por_litro <= 0)
                _regrasQuebradas.Add("A kilometragem por litro deve ser maior que 0");
        }
    }
}
