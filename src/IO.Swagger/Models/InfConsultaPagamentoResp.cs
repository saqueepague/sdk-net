/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.22.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// Informações da resposta da requisição de consulta de pagamento.
    /// </summary>
    [DataContract]
    public partial class InfConsultaPagamentoResp : IEquatable<InfConsultaPagamentoResp>
    { 
        /// <summary>
        /// Valor do pagamento (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor do pagamento (12 dígitos, incluindo centavos).</value>
        [Required]
        [DataMember(Name="valor")]
        public string Valor { get; set; }

        /// <summary>
        /// Cedente (beneficiário).
        /// </summary>
        /// <value>Cedente (beneficiário).</value>
        [Required]
        [DataMember(Name="cedente")]
        public string Cedente { get; set; }

        /// <summary>
        /// Data de pagamento atualizada pelo parceiro (AAAAMMDD).
        /// </summary>
        /// <value>Data de pagamento atualizada pelo parceiro (AAAAMMDD).</value>
        [Required]
        [DataMember(Name="dataPagamento")]
        public string DataPagamento { get; set; }

        /// <summary>
        /// Mensagem informativa quanto à alteração de valores e/ou data de pagamento pelo paceiro.
        /// </summary>
        /// <value>Mensagem informativa quanto à alteração de valores e/ou data de pagamento pelo paceiro.</value>
        [DataMember(Name="mensagem")]
        public string Mensagem { get; set; }

        /// <summary>
        /// Valor de desconto (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor de desconto (12 dígitos, incluindo centavos).</value>
        [Required]
        [DataMember(Name="desconto")]
        public string Desconto { get; set; }

        /// <summary>
        /// Gets or Sets CodBarras
        /// </summary>
        [DataMember(Name="codBarras")]
        public InfConsultaPagamentoRespCodBarras CodBarras { get; set; }

        /// <summary>
        /// Gets or Sets Cip
        /// </summary>
        [DataMember(Name="cip")]
        public InfConsultaPagamentoRespCip Cip { get; set; }

        /// <summary>
        /// Aceita pagamento parcial (00 = não, 00 = sim).
        /// </summary>
        /// <value>Aceita pagamento parcial (00 = não, 00 = sim).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AceitaPagamentoParcialEnum
        {
            
            /// <summary>
            /// Enum _00Enum for 00
            /// </summary>
            [EnumMember(Value = "00")]
            _00Enum = 1,
            
            /// <summary>
            /// Enum _01Enum for 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01Enum = 2
        }

        /// <summary>
        /// Aceita pagamento parcial (00 &#x3D; não, 00 &#x3D; sim).
        /// </summary>
        /// <value>Aceita pagamento parcial (00 &#x3D; não, 00 &#x3D; sim).</value>
        [DataMember(Name="aceitaPagamentoParcial")]
        public AceitaPagamentoParcialEnum? AceitaPagamentoParcial { get; set; }

        /// <summary>
        /// Valor mínimo do pagamento (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor mínimo do pagamento (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorMinimo")]
        public string ValorMinimo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaPagamentoResp {\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Cedente: ").Append(Cedente).Append("\n");
            sb.Append("  DataPagamento: ").Append(DataPagamento).Append("\n");
            sb.Append("  Mensagem: ").Append(Mensagem).Append("\n");
            sb.Append("  Desconto: ").Append(Desconto).Append("\n");
            sb.Append("  CodBarras: ").Append(CodBarras).Append("\n");
            sb.Append("  Cip: ").Append(Cip).Append("\n");
            sb.Append("  AceitaPagamentoParcial: ").Append(AceitaPagamentoParcial).Append("\n");
            sb.Append("  ValorMinimo: ").Append(ValorMinimo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InfConsultaPagamentoResp)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaPagamentoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaPagamentoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaPagamentoResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Valor == other.Valor ||
                    Valor != null &&
                    Valor.Equals(other.Valor)
                ) && 
                (
                    Cedente == other.Cedente ||
                    Cedente != null &&
                    Cedente.Equals(other.Cedente)
                ) && 
                (
                    DataPagamento == other.DataPagamento ||
                    DataPagamento != null &&
                    DataPagamento.Equals(other.DataPagamento)
                ) && 
                (
                    Mensagem == other.Mensagem ||
                    Mensagem != null &&
                    Mensagem.Equals(other.Mensagem)
                ) && 
                (
                    Desconto == other.Desconto ||
                    Desconto != null &&
                    Desconto.Equals(other.Desconto)
                ) && 
                (
                    CodBarras == other.CodBarras ||
                    CodBarras != null &&
                    CodBarras.Equals(other.CodBarras)
                ) && 
                (
                    Cip == other.Cip ||
                    Cip != null &&
                    Cip.Equals(other.Cip)
                ) && 
                (
                    AceitaPagamentoParcial == other.AceitaPagamentoParcial ||
                    AceitaPagamentoParcial != null &&
                    AceitaPagamentoParcial.Equals(other.AceitaPagamentoParcial)
                ) && 
                (
                    ValorMinimo == other.ValorMinimo ||
                    ValorMinimo != null &&
                    ValorMinimo.Equals(other.ValorMinimo)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Valor != null)
                    hashCode = hashCode * 59 + Valor.GetHashCode();
                    if (Cedente != null)
                    hashCode = hashCode * 59 + Cedente.GetHashCode();
                    if (DataPagamento != null)
                    hashCode = hashCode * 59 + DataPagamento.GetHashCode();
                    if (Mensagem != null)
                    hashCode = hashCode * 59 + Mensagem.GetHashCode();
                    if (Desconto != null)
                    hashCode = hashCode * 59 + Desconto.GetHashCode();
                    if (CodBarras != null)
                    hashCode = hashCode * 59 + CodBarras.GetHashCode();
                    if (Cip != null)
                    hashCode = hashCode * 59 + Cip.GetHashCode();
                    if (AceitaPagamentoParcial != null)
                    hashCode = hashCode * 59 + AceitaPagamentoParcial.GetHashCode();
                    if (ValorMinimo != null)
                    hashCode = hashCode * 59 + ValorMinimo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaPagamentoResp left, InfConsultaPagamentoResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaPagamentoResp left, InfConsultaPagamentoResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
