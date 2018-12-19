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
    /// 
    /// </summary>
    [DataContract]
    public partial class Issuer : IEquatable<Issuer>
    { 
        /// <summary>
        /// Identificador do cartão.
        /// </summary>
        /// <value>Identificador do cartão.</value>
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Nome do cartão.
        /// </summary>
        /// <value>Nome do cartão.</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Quantidade de caracteres do cartão.
        /// </summary>
        /// <value>Quantidade de caracteres do cartão.</value>
        [DataMember(Name="card_number_length")]
        public int? CardNumberLength { get; set; }

        /// <summary>
        /// Máscara de números do cartão.
        /// </summary>
        /// <value>Máscara de números do cartão.</value>
        [DataMember(Name="card_number_mask")]
        public string CardNumberMask { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="products")]
        public List<Product1> Products { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Issuer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CardNumberLength: ").Append(CardNumberLength).Append("\n");
            sb.Append("  CardNumberMask: ").Append(CardNumberMask).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Issuer)obj);
        }

        /// <summary>
        /// Returns true if Issuer instances are equal
        /// </summary>
        /// <param name="other">Instance of Issuer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Issuer other)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    CardNumberLength == other.CardNumberLength ||
                    CardNumberLength != null &&
                    CardNumberLength.Equals(other.CardNumberLength)
                ) && 
                (
                    CardNumberMask == other.CardNumberMask ||
                    CardNumberMask != null &&
                    CardNumberMask.Equals(other.CardNumberMask)
                ) && 
                (
                    Products == other.Products ||
                    Products != null &&
                    Products.SequenceEqual(other.Products)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (CardNumberLength != null)
                    hashCode = hashCode * 59 + CardNumberLength.GetHashCode();
                    if (CardNumberMask != null)
                    hashCode = hashCode * 59 + CardNumberMask.GetHashCode();
                    if (Products != null)
                    hashCode = hashCode * 59 + Products.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Issuer left, Issuer right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Issuer left, Issuer right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}