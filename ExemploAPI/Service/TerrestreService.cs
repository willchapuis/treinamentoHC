using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploAPI.Service
{
    public class TerrestreService
    {
        private static string conexaoProd = "";
        private static string conexaoTeste = "Data Source = 172.16.3.25/SISTEMAS; User Id = sihosp; Password = sihosp; Integrated Security = no;";

        private static string conexao;
        public static string Conexao
        {
            get
            {
                if (conexao == "PROD")
                {
                    return conexaoProd;
                }
                else if (conexao == "TESTE")
                {
                    return conexaoTeste;
                }

                return null;
            }
            set
            {
                conexao = value;
            }
        }
    }
}