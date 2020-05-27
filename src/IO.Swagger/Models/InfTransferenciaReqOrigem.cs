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
    /// Informações sobre a origem da tranferência.
    /// </summary>
    [DataContract]
    public partial class InfTransferenciaReqOrigem : IEquatable<InfTransferenciaReqOrigem>
    { 
        /// <summary>
        /// Tipo de conta do extrato (CC = conta corrente, CP = conta poupança, CS = conta salário).
        /// </summary>
        /// <value>Tipo de conta do extrato (CC = conta corrente, CP = conta poupança, CS = conta salário).</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TipoContaEnum
        {
            
            /// <summary>
            /// Enum CCEnum for CC
            /// </summary>
            [EnumMember(Value = "CC")]
            CCEnum = 1,
            
            /// <summary>
            /// Enum CPEnum for CP
            /// </summary>
            [EnumMember(Value = "CP")]
            CPEnum = 2,
            
            /// <summary>
            /// Enum CSEnum for CS
            /// </summary>
            [EnumMember(Value = "CS")]
            CSEnum = 3
        }

        /// <summary>
        /// Tipo de conta do extrato (CC &#x3D; conta corrente, CP &#x3D; conta poupança, CS &#x3D; conta salário).
        /// </summary>
        /// <value>Tipo de conta do extrato (CC &#x3D; conta corrente, CP &#x3D; conta poupança, CS &#x3D; conta salário).</value>
        [Required]
        [DataMember(Name="tipoConta")]
        public TipoContaEnum? TipoConta { get; set; }

        /// <summary>
        /// Código do banco de origem da transferência (3 dígitos).
        /// </summary>
        /// <value>Código do banco de origem da transferência (3 dígitos).</value>
        [Required]
        [DataMember(Name="codBanco")]
        public string CodBanco { get; set; }

        /// <summary>
        /// Número da agência de origem da transferência.
        /// </summary>
        /// <value>Número da agência de origem da transferência.</value>
        [Required]
        [DataMember(Name="numAgencia")]
        public string NumAgencia { get; set; }

        /// <summary>
        /// Número da conta de origem da transferência.
        /// </summary>
        /// <value>Número da conta de origem da transferência.</value>
        [Required]
        [DataMember(Name="numConta")]
        public string NumConta { get; set; }

        /// <summary>
        /// Número do CPF ou CNPJ de origem da transferência (11 dígitos ou 14 dígitos respectivamente).
        /// </summary>
        /// <value>Número do CPF ou CNPJ de origem da transferência (11 dígitos ou 14 dígitos respectivamente).</value>
        [DataMember(Name="cpfcnpj")]
        public string Cpfcnpj { get; set; }

        /// <summary>
        /// Nome de origem da transferência.
        /// </summary>
        /// <value>Nome de origem da transferência.</value>
        [DataMember(Name="nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfTransferenciaReqOrigem {\n");
            sb.Append("  TipoConta: ").Append(TipoConta).Append("\n");
            sb.Append("  CodBanco: ").Append(CodBanco).Append("\n");
            sb.Append("  NumAgencia: ").Append(NumAgencia).Append("\n");
            sb.Append("  NumConta: ").Append(NumConta).Append("\n");
            sb.Append("  Cpfcnpj: ").Append(Cpfcnpj).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfTransferenciaReqOrigem)obj);
        }

        /// <summary>
        /// Returns true if InfTransferenciaReqOrigem instances are equal
        /// </summary>
        /// <param name="other">Instance of InfTransferenciaReqOrigem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfTransferenciaReqOrigem other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TipoConta == other.TipoConta ||
                    TipoConta != null &&
                    TipoConta.Equals(other.TipoConta)
                ) && 
                (
                    CodBanco == other.CodBanco ||
                    CodBanco != null &&
                    CodBanco.Equals(other.CodBanco)
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
                    Cpfcnpj == other.Cpfcnpj ||
                    Cpfcnpj != null &&
                    Cpfcnpj.Equals(other.Cpfcnpj)
                ) && 
                (
                    Nome == other.Nome ||
                    Nome != null &&
                    Nome.Equals(other.Nome)
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
                    if (TipoConta != null)
                    hashCode = hashCode * 59 + TipoConta.GetHashCode();
                    if (CodBanco != null)
                    hashCode = hashCode * 59 + CodBanco.GetHashCode();
                    if (NumAgencia != null)
                    hashCode = hashCode * 59 + NumAgencia.GetHashCode();
                    if (NumConta != null)
                    hashCode = hashCode * 59 + NumConta.GetHashCode();
                    if (Cpfcnpj != null)
                    hashCode = hashCode * 59 + Cpfcnpj.GetHashCode();
                    if (Nome != null)
                    hashCode = hashCode * 59 + Nome.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfTransferenciaReqOrigem left, InfTransferenciaReqOrigem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfTransferenciaReqOrigem left, InfTransferenciaReqOrigem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
