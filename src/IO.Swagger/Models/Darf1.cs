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
    public partial class Darf1 : IEquatable<Darf1>
    { 
        /// <summary>
        /// Data de apuração do DARF (AAAAMMDD).
        /// </summary>
        /// <value>Data de apuração do DARF (AAAAMMDD).</value>
        [DataMember(Name="periodoApuracao")]
        public string PeriodoApuracao { get; set; }

        /// <summary>
        /// Código da receita do DARF.
        /// </summary>
        /// <value>Código da receita do DARF.</value>
        [DataMember(Name="codReceita")]
        public string CodReceita { get; set; }

        /// <summary>
        /// Número de referência.
        /// </summary>
        /// <value>Número de referência.</value>
        [DataMember(Name="numReferencia")]
        public string NumReferencia { get; set; }

        /// <summary>
        /// Data de vencimento do DARF (AAAAMMDD).
        /// </summary>
        /// <value>Data de vencimento do DARF (AAAAMMDD).</value>
        [DataMember(Name="dataVencimento")]
        public string DataVencimento { get; set; }

        /// <summary>
        /// Valor principal do DARF (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor principal do DARF (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorPrincipal")]
        public string ValorPrincipal { get; set; }

        /// <summary>
        /// Valor da multa (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor da multa (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorMulta")]
        public string ValorMulta { get; set; }

        /// <summary>
        /// Valor relativo aos juros (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor relativo aos juros (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorJuros")]
        public string ValorJuros { get; set; }

        /// <summary>
        /// Valor total de pagamento do DARF (12 dígitos, incluindo centavos).
        /// </summary>
        /// <value>Valor total de pagamento do DARF (12 dígitos, incluindo centavos).</value>
        [DataMember(Name="valorTotal")]
        public string ValorTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Darf1 {\n");
            sb.Append("  PeriodoApuracao: ").Append(PeriodoApuracao).Append("\n");
            sb.Append("  CodReceita: ").Append(CodReceita).Append("\n");
            sb.Append("  NumReferencia: ").Append(NumReferencia).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  ValorPrincipal: ").Append(ValorPrincipal).Append("\n");
            sb.Append("  ValorMulta: ").Append(ValorMulta).Append("\n");
            sb.Append("  ValorJuros: ").Append(ValorJuros).Append("\n");
            sb.Append("  ValorTotal: ").Append(ValorTotal).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Darf1)obj);
        }

        /// <summary>
        /// Returns true if Darf1 instances are equal
        /// </summary>
        /// <param name="other">Instance of Darf1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Darf1 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PeriodoApuracao == other.PeriodoApuracao ||
                    PeriodoApuracao != null &&
                    PeriodoApuracao.Equals(other.PeriodoApuracao)
                ) && 
                (
                    CodReceita == other.CodReceita ||
                    CodReceita != null &&
                    CodReceita.Equals(other.CodReceita)
                ) && 
                (
                    NumReferencia == other.NumReferencia ||
                    NumReferencia != null &&
                    NumReferencia.Equals(other.NumReferencia)
                ) && 
                (
                    DataVencimento == other.DataVencimento ||
                    DataVencimento != null &&
                    DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    ValorPrincipal == other.ValorPrincipal ||
                    ValorPrincipal != null &&
                    ValorPrincipal.Equals(other.ValorPrincipal)
                ) && 
                (
                    ValorMulta == other.ValorMulta ||
                    ValorMulta != null &&
                    ValorMulta.Equals(other.ValorMulta)
                ) && 
                (
                    ValorJuros == other.ValorJuros ||
                    ValorJuros != null &&
                    ValorJuros.Equals(other.ValorJuros)
                ) && 
                (
                    ValorTotal == other.ValorTotal ||
                    ValorTotal != null &&
                    ValorTotal.Equals(other.ValorTotal)
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
                    if (PeriodoApuracao != null)
                    hashCode = hashCode * 59 + PeriodoApuracao.GetHashCode();
                    if (CodReceita != null)
                    hashCode = hashCode * 59 + CodReceita.GetHashCode();
                    if (NumReferencia != null)
                    hashCode = hashCode * 59 + NumReferencia.GetHashCode();
                    if (DataVencimento != null)
                    hashCode = hashCode * 59 + DataVencimento.GetHashCode();
                    if (ValorPrincipal != null)
                    hashCode = hashCode * 59 + ValorPrincipal.GetHashCode();
                    if (ValorMulta != null)
                    hashCode = hashCode * 59 + ValorMulta.GetHashCode();
                    if (ValorJuros != null)
                    hashCode = hashCode * 59 + ValorJuros.GetHashCode();
                    if (ValorTotal != null)
                    hashCode = hashCode * 59 + ValorTotal.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Darf1 left, Darf1 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Darf1 left, Darf1 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}