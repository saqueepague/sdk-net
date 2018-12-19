/*
 * Saque e Pague Transaction
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.17.0
 * Contact: captura_atm@saqueepague.com.br
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
    /// Informações da resposta da requisição de consulta de conta.
    /// </summary>
    [DataContract]
    public partial class InfConsultaContaResp : IEquatable<InfConsultaContaResp>
    {         /// <summary>
        /// Gets or Sets ModalidadeDeposito
        /// </summary>
        public enum ModalidadeDeposito1
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
        /// Gets or Sets ModalidadeDeposito
        /// </summary>
        [DataMember(Name="modalidadeDeposito")]
        public ModalidadeDeposito1? ModalidadeDeposito { get; set; }

        /// <summary>
        /// Nome do cliente titular da conta (até 60 caracteres).
        /// </summary>
        /// <value>Nome do cliente titular da conta (até 60 caracteres).</value>
        [DataMember(Name="nomeCliente")]
        public string NomeCliente { get; set; }
        /// <summary>
        /// Gets or Sets SolicDoc
        /// </summary>
        public enum eSolicDoc
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
        /// Gets or Sets SolicDoc
        /// </summary>
        [DataMember(Name="solicDoc")]
        public eSolicDoc? SolicDoc { get; set; }
        /// <summary>
        /// Gets or Sets HabilitaDeposito
        /// </summary>
        public enum eHabilitaDeposito
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
        /// Gets or Sets HabilitaDeposito
        /// </summary>
        [DataMember(Name="habilitaDeposito")]
        public eHabilitaDeposito? HabilitaDeposito { get; set; }
        /// <summary>
        /// Gets or Sets DepositoIdentificado
        /// </summary>
        public enum eDepositoIdentificado
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
        /// Gets or Sets DepositoIdentificado
        /// </summary>
        [DataMember(Name="depositoIdentificado")]
        public eDepositoIdentificado? DepositoIdentificado { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaContaResp {\n");
            sb.Append("  ModalidadeDeposito: ").Append(ModalidadeDeposito).Append("\n");
            sb.Append("  NomeCliente: ").Append(NomeCliente).Append("\n");
            sb.Append("  SolicDoc: ").Append(SolicDoc).Append("\n");
            sb.Append("  HabilitaDeposito: ").Append(HabilitaDeposito).Append("\n");
            sb.Append("  DepositoIdentificado: ").Append(DepositoIdentificado).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaContaResp)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaContaResp instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaContaResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaContaResp other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ModalidadeDeposito == other.ModalidadeDeposito ||
                    ModalidadeDeposito != null &&
                    ModalidadeDeposito.Equals(other.ModalidadeDeposito)
                ) && 
                (
                    NomeCliente == other.NomeCliente ||
                    NomeCliente != null &&
                    NomeCliente.Equals(other.NomeCliente)
                ) && 
                (
                    SolicDoc == other.SolicDoc ||
                    SolicDoc != null &&
                    SolicDoc.Equals(other.SolicDoc)
                ) && 
                (
                    HabilitaDeposito == other.HabilitaDeposito ||
                    HabilitaDeposito != null &&
                    HabilitaDeposito.Equals(other.HabilitaDeposito)
                ) && 
                (
                    DepositoIdentificado == other.DepositoIdentificado ||
                    DepositoIdentificado != null &&
                    DepositoIdentificado.Equals(other.DepositoIdentificado)
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
                    if (ModalidadeDeposito != null)
                    hashCode = hashCode * 59 + ModalidadeDeposito.GetHashCode();
                    if (NomeCliente != null)
                    hashCode = hashCode * 59 + NomeCliente.GetHashCode();
                    if (SolicDoc != null)
                    hashCode = hashCode * 59 + SolicDoc.GetHashCode();
                    if (HabilitaDeposito != null)
                    hashCode = hashCode * 59 + HabilitaDeposito.GetHashCode();
                    if (DepositoIdentificado != null)
                    hashCode = hashCode * 59 + DepositoIdentificado.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaContaResp left, InfConsultaContaResp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaContaResp left, InfConsultaContaResp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}