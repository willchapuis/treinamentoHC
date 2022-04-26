using DTIDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricaAutomoveis.Domain
{
    public class Terrestre : DomainBase
    {
        public Automovel Auto { get; set; }

        public int nro_rodas { get; set; }

        public Boolean estepe { get; set; }

        public override void Validar()
        {
            _regrasQuebradas.Clear();
            //id
            if (nro_rodas <= 0)
                _regrasQuebradas.Add("O numero de boias deve ser maior que 0");
        }
    }
}
