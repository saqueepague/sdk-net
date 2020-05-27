/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.19.4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class RecargaApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de consulta dos possíveis produtos de recarga de transporte para o cartão informado pelo cliente. Operação relacionada a transação consultaProdutosRecarga.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de consulta produtos de recarga disponíveis para um cartão.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.19.4/consultaProdutosRecarga")]
        [ValidateModelState]
        [SwaggerOperation("ConsultaProdutosRecargaPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConsultaProdutosRecargaResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult ConsultaProdutosRecargaPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]ConsultaProdutosRecargaReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConsultaProdutosRecargaResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"InfConsultaProdutosRecarga\" : {\n    \"products\" : [ {\n      \"name\" : \"Produto de Recarga\",\n      \"id\" : \"1\"\n    }, {\n      \"name\" : \"Produto de Recarga\",\n      \"id\" : \"1\"\n    } ]\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConsultaProdutosRecargaResp>(exampleJson)
            : default(ConsultaProdutosRecargaResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de consulta dos produtos de recarga de cartão pré-pago de transporte. Traz uma lista de todas as operadoras e seus respectivos produtos/valores.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de consulta valores de recarga de cartão.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.19.4/consultaValoresRecarga")]
        [ValidateModelState]
        [SwaggerOperation("ConsultaValoresRecargaPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConsultaValoresRecargaResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult ConsultaValoresRecargaPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]ConsultaValoresRecargaReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConsultaValoresRecargaResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"InfConsultaValoresRecarga\" : {\n    \"valores\" : {\n      \"issuers\" : [ {\n        \"card_number_mask\" : \"XXXXXXXXXXXXXX-X\",\n        \"card_number_length\" : 15,\n        \"name\" : \"TEU\",\n        \"id\" : 1,\n        \"products\" : [ {\n          \"min_value\" : \"1000\",\n          \"fee\" : \"200\",\n          \"values\" : [ {\n            \"fee\" : \"200\",\n            \"id\" : \"1\",\n            \"value\" : \"2000\"\n          }, {\n            \"fee\" : \"200\",\n            \"id\" : \"1\",\n            \"value\" : \"2000\"\n          } ],\n          \"name\" : \"Bilhete Antecipado\",\n          \"id\" : \"1\",\n          \"max_value\" : \"9000\"\n        }, {\n          \"min_value\" : \"1000\",\n          \"fee\" : \"200\",\n          \"values\" : [ {\n            \"fee\" : \"200\",\n            \"id\" : \"1\",\n            \"value\" : \"2000\"\n          }, {\n            \"fee\" : \"200\",\n            \"id\" : \"1\",\n            \"value\" : \"2000\"\n          } ],\n          \"name\" : \"Bilhete Antecipado\",\n          \"id\" : \"1\",\n          \"max_value\" : \"9000\"\n        } ]\n      }, {\n        \"card_number_mask\" : \"XXXXXXXXXXXXXX-X\",\n        \"card_number_length\" : 15,\n        \"name\" : \"TEU\",\n        \"id\" : 1,\n        \"products\" : [ {\n          \"min_value\" : \"1000\",\n          \"fee\" : \"200\",\n          \"values\" : [ {\n            \"fee\" : \"200\",\n            \"id\" : \"1\",\n            \"value\" : \"2000\"\n          }, {\n            \"fee\" : \"200\",\n            \"id\" : \"1\",\n            \"value\" : \"2000\"\n          } ],\n          \"name\" : \"Bilhete Antecipado\",\n          \"id\" : \"1\",\n          \"max_value\" : \"9000\"\n        }, {\n          \"min_value\" : \"1000\",\n          \"fee\" : \"200\",\n          \"values\" : [ {\n            \"fee\" : \"200\",\n            \"id\" : \"1\",\n            \"value\" : \"2000\"\n          }, {\n            \"fee\" : \"200\",\n            \"id\" : \"1\",\n            \"value\" : \"2000\"\n          } ],\n          \"name\" : \"Bilhete Antecipado\",\n          \"id\" : \"1\",\n          \"max_value\" : \"9000\"\n        } ]\n      } ]\n    }\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConsultaValoresRecargaResp>(exampleJson)
            : default(ConsultaValoresRecargaResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de confirmação de recarga de cartão pré-pago de transporte (bilhetagem).</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de confirmação de operação de recarga.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.19.4/recargaConf")]
        [ValidateModelState]
        [SwaggerOperation("RecargaConfPost")]
        public virtual IActionResult RecargaConfPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]TransacConf body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de recarga de cartão pré-pago de transporte (bilhetagem) em dinheiro.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de operação de recarga de um cartão.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.19.4/recarga")]
        [ValidateModelState]
        [SwaggerOperation("RecargaPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(RecargaResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult RecargaPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]RecargaReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(RecargaResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfRecarga\" : {\n    \"recibo\" : \"@             TEU BILHETE ANTECIPADO             @                                                @ CARTAO: 036200005433591                        @ VALOR DA RECARGA: R$ 48,00                     @ TAXAS: R$ 2,00                                 @ TOTAL PAGO: R$ 50,00                           \"\n  },\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RecargaResp>(exampleJson)
            : default(RecargaResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="clientSecret">Cliente Secret.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.19.4/token")]
        [ValidateModelState]
        [SwaggerOperation("TokenPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(InfTokenResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult TokenPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string clientSecret)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InfTokenResp));

            string exampleJson = null;
            exampleJson = "{\n  \"access_token\" : \"847c2530-9819-434b-82fb-a9058a1ec957\",\n  \"token_type\" : \"bearer\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InfTokenResp>(exampleJson)
            : default(InfTokenResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
