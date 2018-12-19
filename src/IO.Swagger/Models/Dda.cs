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
    public partial class Dda : IEquatable<Dda>
    { 
        /// <summary>
        /// Número ID DDA.
        /// </summary>
        /// <value>Número ID DDA.</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Tipo de consulta de DDA a ser feita.
        /// </summary>
        /// <value>Tipo de consulta de DDA a ser feita.</value>
        [DataMember(Name="tipoConsulta")]
        public string TipoConsulta { get; set; }

        /// <summary>
        /// Número do CPF ou CNPJ (11 ou 14 dígitos).
        /// </summary>
        /// <value>Número do CPF ou CNPJ (11 ou 14 dígitos).</value>
        [DataMember(Name="cpfCNPJ")]
        public string CpfCNPJ { get; set; }

        /// <summary>
        /// Data de início do período da lista de DDA (caso a consulta seja por período, AAAAMMDD).
        /// </summary>
        /// <value>Data de início do período da lista de DDA (caso a consulta seja por período, AAAAMMDD).</value>
        [DataMember(Name="dataInicial")]
        public string DataInicial { get; set; }

        /// <summary>
        /// Data final do período da lista de DDA (caso a consulta seja por período, AAAAMMDD).
        /// </summary>
        /// <value>Data final do período da lista de DDA (caso a consulta seja por período, AAAAMMDD).</value>
        [DataMember(Name="dataFinal")]
        public string DataFinal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dda {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TipoConsulta: ").Append(TipoConsulta).Append("\n");
            sb.Append("  CpfCNPJ: ").Append(CpfCNPJ).Append("\n");
            sb.Append("  DataInicial: ").Append(DataInicial).Append("\n");
            sb.Append("  DataFinal: ").Append(DataFinal).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Dda)obj);
        }

        /// <summary>
        /// Returns true if Dda instances are equal
        /// </summary>
        /// <param name="other">Instance of Dda to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dda other)
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
                    TipoConsulta == other.TipoConsulta ||
                    TipoConsulta != null &&
                    TipoConsulta.Equals(other.TipoConsulta)
                ) && 
                (
                    CpfCNPJ == other.CpfCNPJ ||
                    CpfCNPJ != null &&
                    CpfCNPJ.Equals(other.CpfCNPJ)
                ) && 
                (
                    DataInicial == other.DataInicial ||
                    DataInicial != null &&
                    DataInicial.Equals(other.DataInicial)
                ) && 
                (
                    DataFinal == other.DataFinal ||
                    DataFinal != null &&
                    DataFinal.Equals(other.DataFinal)
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
                    if (TipoConsulta != null)
                    hashCode = hashCode * 59 + TipoConsulta.GetHashCode();
                    if (CpfCNPJ != null)
                    hashCode = hashCode * 59 + CpfCNPJ.GetHashCode();
                    if (DataInicial != null)
                    hashCode = hashCode * 59 + DataInicial.GetHashCode();
                    if (DataFinal != null)
                    hashCode = hashCode * 59 + DataFinal.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Dda left, Dda right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Dda left, Dda right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}