using DAO;
using ExemploAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ExemploAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            TerrestreService.Conexao = "TESTE";
            BDOracle.strConexao = TerrestreService.Conexao;
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}"//,
                //defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
