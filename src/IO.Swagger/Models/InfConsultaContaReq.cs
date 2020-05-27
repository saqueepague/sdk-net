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
    /// Informações da requisição de consulta de conta do favorecido do depósito.
    /// </summary>
    [DataContract]
    public partial class InfConsultaContaReq : IEquatable<InfConsultaContaReq>
    { 
        /// <summary>
        /// Código do banco utilizado na operação (3 dígitos).
        /// </summary>
        /// <value>Código do banco utilizado na operação (3 dígitos).</value>
        [DataMember(Name="codBanco")]
        public string CodBanco { get; set; }

        /// <summary>
        /// Número do CPF ou CNPJ do cliente favorecido da transação (11 dígitos ou 14 dígitos respectivamente).
        /// </summary>
        /// <value>Número do CPF ou CNPJ do cliente favorecido da transação (11 dígitos ou 14 dígitos respectivamente).</value>
        [DataMember(Name="cpfFavorecido")]
        public string CpfFavorecido { get; set; }

        /// <summary>
        /// Indica a modalidade de depósito desejada (2 dígitos, 00 = dinheiro, 01 = cheque).
        /// </summary>
        /// <value>Indica a modalidade de depósito desejada (2 dígitos, 00 = dinheiro, 01 = cheque).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ModalidadeDepositoEnum
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
        /// Indica a modalidade de depósito desejada (2 dígitos, 00 &#x3D; dinheiro, 01 &#x3D; cheque).
        /// </summary>
        /// <value>Indica a modalidade de depósito desejada (2 dígitos, 00 &#x3D; dinheiro, 01 &#x3D; cheque).</value>
        [Required]
        [DataMember(Name="modalidadeDeposito")]
        public ModalidadeDepositoEnum? ModalidadeDeposito { get; set; }

        /// <summary>
        /// Número da agência utilizada na operação.
        /// </summary>
        /// <value>Número da agência utilizada na operação.</value>
        [DataMember(Name="numAgencia")]
        public string NumAgencia { get; set; }

        /// <summary>
        /// Número da conta utilizada na operação.
        /// </summary>
        /// <value>Número da conta utilizada na operação.</value>
        [DataMember(Name="numConta")]
        public string NumConta { get; set; }

        /// <summary>
        /// Telefone do cliente favorecido da transação (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).
        /// </summary>
        /// <value>Telefone do cliente favorecido da transação (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).</value>
        [DataMember(Name="telefoneFavorecido")]
        public string TelefoneFavorecido { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaContaReq {\n");
            sb.Append("  CodBanco: ").Append(CodBanco).Append("\n");
            sb.Append("  CpfFavorecido: ").Append(CpfFavorecido).Append("\n");
            sb.Append("  ModalidadeDeposito: ").Append(ModalidadeDeposito).Append("\n");
            sb.Append("  NumAgencia: ").Append(NumAgencia).Append("\n");
            sb.Append("  NumConta: ").Append(NumConta).Append("\n");
            sb.Append("  TelefoneFavorecido: ").Append(TelefoneFavorecido).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaContaReq)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaContaReq instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaContaReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaContaReq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CodBanco == other.CodBanco ||
                    CodBanco != null &&
                    CodBanco.Equals(other.CodBanco)
                ) && 
                (
                    CpfFavorecido == other.CpfFavorecido ||
                    CpfFavorecido != null &&
                    CpfFavorecido.Equals(other.CpfFavorecido)
                ) && 
                (
                    ModalidadeDeposito == other.ModalidadeDeposito ||
                    ModalidadeDeposito != null &&
                    ModalidadeDeposito.Equals(other.ModalidadeDeposito)
                ) && 
                (
                    NumAgencia == other.NumAgencia ||
                    NumAgencia != null &&
                    NumAgencia.Equals(other.NumAgencia)
                ) && 
                (
                    NumConta == other.NumConta ||
                    NumConta != null &&
                    NumConta.Equals(other.NumConta)
                ) && 
                (
                    TelefoneFavorecido == other.TelefoneFavorecido ||
                    TelefoneFavorecido != null &&
                    TelefoneFavorecido.Equals(other.TelefoneFavorecido)
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
                    if (CodBanco != null)
                    hashCode = hashCode * 59 + CodBanco.GetHashCode();
                    if (CpfFavorecido != null)
                    hashCode = hashCode * 59 + CpfFavorecido.GetHashCode();
                    if (ModalidadeDeposito != null)
                    hashCode = hashCode * 59 + ModalidadeDeposito.GetHashCode();
                    if (NumAgencia != null)
                    hashCode = hashCode * 59 + NumAgencia.GetHashCode();
                    if (NumConta != null)
                    hashCode = hashCode * 59 + NumConta.GetHashCode();
                    if (TelefoneFavorecido != null)
                    hashCode = hashCode * 59 + TelefoneFavorecido.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaContaReq left, InfConsultaContaReq right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaContaReq left, InfConsultaContaReq right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
