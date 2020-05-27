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
    /// 
    /// </summary>
    [DataContract]
    public partial class FeeObj : IEquatable<FeeObj>
    { 
        /// <summary>
        /// Número identificador da taxa.
        /// </summary>
        /// <value>Número identificador da taxa.</value>
        [Required]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Limite superior de valor para aplicação desta taxa.
        /// </summary>
        /// <value>Limite superior de valor para aplicação desta taxa.</value>
        [Required]
        [DataMember(Name="max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// Limite inferior de valor para aplicação desta taxa.
        /// </summary>
        /// <value>Limite inferior de valor para aplicação desta taxa.</value>
        [Required]
        [DataMember(Name="min_amount")]
        public string MinAmount { get; set; }

        /// <summary>
        /// Valor da taxa a ser aplicada.
        /// </summary>
        /// <value>Valor da taxa a ser aplicada.</value>
        [Required]
        [DataMember(Name="value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeObj {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  MinAmount: ").Append(MinAmount).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FeeObj)obj);
        }

        /// <summary>
        /// Returns true if FeeObj instances are equal
        /// </summary>
        /// <param name="other">Instance of FeeObj to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeObj other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    MaxAmount == other.MaxAmount ||
                    MaxAmount != null &&
                    MaxAmount.Equals(other.MaxAmount)
                ) && 
                (
                    MinAmount == other.MinAmount ||
                    MinAmount != null &&
                    MinAmount.Equals(other.MinAmount)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (MaxAmount != null)
                    hashCode = hashCode * 59 + MaxAmount.GetHashCode();
                    if (MinAmount != null)
                    hashCode = hashCode * 59 + MinAmount.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FeeObj left, FeeObj right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FeeObj left, FeeObj right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
