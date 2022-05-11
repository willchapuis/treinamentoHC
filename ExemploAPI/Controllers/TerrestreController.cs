using ExemploAPI.Models;
using FabricaAutomoveis.Domain;
using HttpActionResultStatus;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace ExemploAPI.Controllers
{
    public class TerrestreController : ApiController
    {
        [HttpGet]
        [Route("api/terrestre/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                HttpResult result = new HttpResult();
                var automovel = new Models.Terrestre();
                string retorno = automovel.Get(id);
                if (String.IsNullOrEmpty(retorno))
                {
                    retorno = @"{'Message': 'Automovel não encontrado'}";
                    return result.ResultStatus(JObject.Parse(retorno).ToString(), Request, HttpStatusCode.InternalServerError);
                }
                return result.ResultStatus(retorno, Request, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("api/terrestre")]
        public IHttpActionResult Listar()
        {
            try
            {
                HttpResult result = new HttpResult();
                var automovel = new Models.Terrestre();
                string retorno = automovel.Listar();
                if (String.IsNullOrEmpty(retorno))
                {
                    retorno = @"{'Message': 'Não foi encontrado Automoveis'}";
                    return result.ResultStatus(JObject.Parse(retorno).ToString(), Request, HttpStatusCode.InternalServerError);
                }
                return result.ResultStatus(retorno, Request, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("api/terrestre/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                HttpResult result = new HttpResult();
                var automovel = new Models.Terrestre();
                string retorno = automovel.Delete(id);
                if (string.IsNullOrEmpty(retorno))
                {
                    return result.ResultStatus("", Request, HttpStatusCode.NoContent); // 
                }
                retorno = @"{'message': 'Automovel não encontrado'}";
                return result.ResultStatus(JObject.Parse(retorno).ToString(), Request, HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("api/terrestre/")]
        public IHttpActionResult Post([FromBody] TerrestreDTO auto)
        {
            try
            {
                HttpResult result = new HttpResult();
                var automovel = new Models.Terrestre();
                string retorno = automovel.Post(auto);
                if (string.IsNullOrEmpty(retorno))
                {
                    return result.ResultStatus("", Request, HttpStatusCode.OK);
                }
                retorno = @"{'message': 'Não foi possivel inserir o automovel'}";
                return result.ResultStatus(JObject.Parse(retorno).ToString(), Request, HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("api/terrestre/{id:int}")]
        public IHttpActionResult Put([FromUri] int id, [FromBody] TerrestreDTO auto)
        {
            try
            {
                HttpResult result = new HttpResult();
                var automovel = new Models.Terrestre();
                string retorno = automovel.Update(id, auto);
                if (string.IsNullOrEmpty(retorno))
                {
                    return result.ResultStatus("", Request, HttpStatusCode.OK);
                }
                retorno = @"{'message': 'Não foi possivel alterar o automovel'}";
                return result.ResultStatus(JObject.Parse(retorno).ToString(), Request, HttpStatusCode.InternalServerError);
                
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}