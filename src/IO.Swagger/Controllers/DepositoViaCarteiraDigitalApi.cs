/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.25.2
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
    public class DepositoViaCarteiraDigitalApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de consulta de conta de favorecido, usada previamente ao depósito para verificar se a conta é válida e está habilitada para depósito.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de consulta de conta.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.25.2/consultaConta")]
        [ValidateModelState]
        [SwaggerOperation("ConsultaContaPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConsultaContaResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult ConsultaContaPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]ConsultaContaReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConsultaContaResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"InfConsultaConta\" : {\n    \"solicDoc\" : \"00\",\n    \"numAgencia\" : \"4029\",\n    \"numConta\" : \"0082348296\",\n    \"modalidadeDeposito\" : \"00\",\n    \"depositoVarejista\" : \"01\",\n    \"nomeCliente\" : \"Carl Edward Sagan\",\n    \"depositoIdentificado\" : \"00\",\n    \"habilitaDeposito\" : \"01\",\n    \"codBanco\" : \"237\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConsultaContaResp>(exampleJson)
            : default(ConsultaContaResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Operação de consulta de taxas dinâmicas, requisitado antes de depósito ou saque de carteira de digital.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de consulta de taxas.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.25.2/consultaTaxas")]
        [ValidateModelState]
        [SwaggerOperation("ConsultaTaxasPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConsultaTaxasResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult ConsultaTaxasPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]ConsultaTaxasReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConsultaTaxasResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfConsultaTaxas\" : {\n    \"transactions_fees\" : [ {\n      \"fees\" : [ {\n        \"min_amount\" : \"000\",\n        \"max_amount\" : \"10000\",\n        \"id\" : \"0201\",\n        \"value\" : \"000\"\n      }, {\n        \"min_amount\" : \"000\",\n        \"max_amount\" : \"10000\",\n        \"id\" : \"0201\",\n        \"value\" : \"000\"\n      } ],\n      \"name\" : \"deposit\",\n      \"id\" : \"01\"\n    }, {\n      \"fees\" : [ {\n        \"min_amount\" : \"000\",\n        \"max_amount\" : \"10000\",\n        \"id\" : \"0201\",\n        \"value\" : \"000\"\n      }, {\n        \"min_amount\" : \"000\",\n        \"max_amount\" : \"10000\",\n        \"id\" : \"0201\",\n        \"value\" : \"000\"\n      } ],\n      \"name\" : \"deposit\",\n      \"id\" : \"01\"\n    } ]\n  },\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConsultaTaxasResp>(exampleJson)
            : default(ConsultaTaxasResp);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Confirmação de operação de depósito.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Requisição de confirmação de operação de depósito.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.25.2/depositoConf")]
        [ValidateModelState]
        [SwaggerOperation("DepositoConfPost")]
        public virtual IActionResult DepositoConfPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]TransacConf body)
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
        /// <remarks>Operação de depósito em dinheiro, cartão é opcional nesta operação.</remarks>
        /// <param name="authenticationType">Tipo de autenticação requerida.</param>
        /// <param name="clientId">Identificação do cliente.</param>
        /// <param name="token">Chave para validação do acesso ao serviço.</param>
        /// <param name="body">Objeto da requisição de depósito, cartão é opcional.</param>
        /// <response code="200">Retorno com sucesso ou com Erro de negócio.</response>
        /// <response code="400">Bad Request ou Erro interno ao qual inviabilizou uma resposta.</response>
        /// <response code="401">Acesso não autorizado.</response>
        [HttpPost]
        [Route("/saqueepague/SepTransaction/1.25.2/deposito")]
        [ValidateModelState]
        [SwaggerOperation("DepositoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(DepositoResp), description: "Retorno com sucesso ou com Erro de negócio.")]
        public virtual IActionResult DepositoPost([FromHeader][Required()]string authenticationType, [FromHeader][Required()]string clientId, [FromHeader][Required()]string token, [FromBody]DepositoReq body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DepositoResp));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\n  \"InfTransacao\" : {\n    \"cdProc\" : \"029100\",\n    \"mensagemCliente\" : \"Esta &eacute; uma mensagem para exibi&ccedil;&atilde;o em tela.\",\n    \"nsu\" : \"000080247206\",\n    \"codMoeda\" : \"986\",\n    \"codOperadora\" : \"00000000914\",\n    \"dataLocal\" : \"1122\",\n    \"errorMessage\" : \"\",\n    \"valor\" : \"5000\",\n    \"horaLocal\" : \"151032\",\n    \"nsuResposta\" : \"820\",\n    \"dataHora\" : \"1122151032\"\n  },\n  \"Cripto\" : {\n    \"hash\" : \"hash\"\n  },\n  \"InfDeposito\" : {\n    \"recibo\" : \"@            COMPROVANTE DE DEPOSITO             @------------------------------------------------@ Agencia....: 0101                              @ Conta......: 74414-0                           @ Nome.......: EUGENIO SCHMITT COELHO            @@------------------------------------------------@ Favorecido: EUGENIO SCHMITT COELHO             @ Agencia Destino:                           0101@ Conta Destino:         Conta Corrente - 74414-0@@Tipo            NSU                        Valor@Dinheiro        697841472523             R$20,00@------------------------------------------------@               SAC - 0800 123 4569@      SAC - DEF. AUDITIVO - 0800 123 4568@            OUVIDORIA - 0800 123 4567@@             www.siteparceiro.com.br@\"\n  },\n  \"Terminal\" : {\n    \"codEstab\" : \"000000000742673\",\n    \"tipo\" : \"008\",\n    \"id\" : \"05100004\"\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DepositoResp>(exampleJson)
            : default(DepositoResp);
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
        [Route("/saqueepague/SepTransaction/1.25.2/token")]
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
