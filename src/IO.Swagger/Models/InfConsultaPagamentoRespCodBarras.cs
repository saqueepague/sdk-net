/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.19.1
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
    /// 
    /// </summary>
    [DataContract]
    public partial class InfConsultaPagamentoRespCodBarras : IEquatable<InfConsultaPagamentoRespCodBarras>
    { 
        /// <summary>
        /// Código de barras do documento.Necessário caso no ConsultaPagamento o objeto infConsultaPagamento tenha sido apenas com CPF.
        /// </summary>
        /// <value>Código de barras do documento.Necessário caso no ConsultaPagamento o objeto infConsultaPagamento tenha sido apenas com CPF.</value>
        [DataMember(Name="codigo")]
        public string Codigo { get; set; }

        /// <summary>
        /// Data de vencimento (AAAAMMDD).
        /// </summary>
        /// <value>Data de vencimento (AAAAMMDD).</value>
        [DataMember(Name="dataVencimento")]
        public string DataVencimento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfConsultaPagamentoRespCodBarras {\n");
            sb.Append("  Codigo: ").Append(Codigo).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfConsultaPagamentoRespCodBarras)obj);
        }

        /// <summary>
        /// Returns true if InfConsultaPagamentoRespCodBarras instances are equal
        /// </summary>
        /// <param name="other">Instance of InfConsultaPagamentoRespCodBarras to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfConsultaPagamentoRespCodBarras other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Codigo == other.Codigo ||
                    Codigo != null &&
                    Codigo.Equals(other.Codigo)
                ) && 
                (
                    DataVencimento == other.DataVencimento ||
                    DataVencimento != null &&
                    DataVencimento.Equals(other.DataVencimento)
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
                    if (Codigo != null)
                    hashCode = hashCode * 59 + Codigo.GetHashCode();
                    if (DataVencimento != null)
                    hashCode = hashCode * 59 + DataVencimento.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfConsultaPagamentoRespCodBarras left, InfConsultaPagamentoRespCodBarras right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfConsultaPagamentoRespCodBarras left, InfConsultaPagamentoRespCodBarras right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
