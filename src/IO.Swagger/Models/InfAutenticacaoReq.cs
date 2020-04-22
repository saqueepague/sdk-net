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
    /// Informações da requisição de autenticação.
    /// </summary>
    [DataContract]
    public partial class InfAutenticacaoReq : IEquatable<InfAutenticacaoReq>
    { 
        /// <summary>
        /// Número do CPF do cliente a autenticar (11 dígitos).
        /// </summary>
        /// <value>Número do CPF do cliente a autenticar (11 dígitos).</value>
        [Required]
        [DataMember(Name="cpf")]
        public string Cpf { get; set; }

        /// <summary>
        /// Telefone do cliente favorecido a autenticar (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).
        /// </summary>
        /// <value>Telefone do cliente favorecido a autenticar (11 dígitos &#x3D; DDD com 0 quando número tem 8 dígitos, sem 0 quando número tem 9 dígitos).</value>
        [Required]
        [DataMember(Name="telefone")]
        public string Telefone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfAutenticacaoReq {\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InfAutenticacaoReq)obj);
        }

        /// <summary>
        /// Returns true if InfAutenticacaoReq instances are equal
        /// </summary>
        /// <param name="other">Instance of InfAutenticacaoReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfAutenticacaoReq other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Cpf == other.Cpf ||
                    Cpf != null &&
                    Cpf.Equals(other.Cpf)
                ) && 
                (
                    Telefone == other.Telefone ||
                    Telefone != null &&
                    Telefone.Equals(other.Telefone)
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
                    if (Cpf != null)
                    hashCode = hashCode * 59 + Cpf.GetHashCode();
                    if (Telefone != null)
                    hashCode = hashCode * 59 + Telefone.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InfAutenticacaoReq left, InfAutenticacaoReq right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InfAutenticacaoReq left, InfAutenticacaoReq right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
