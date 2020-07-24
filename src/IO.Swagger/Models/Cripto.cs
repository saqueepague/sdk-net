/*
 * Saque e Pague Transacional
 *
 * Modelo de API para transações da Saque e Pague. O parceiro interessado deve implementar as operações desejadas para que a SeP consiga se comunicar com o mesmo.
 *
 * OpenAPI spec version: 1.19.7
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
    /// Informações relacionadas a criptografia e senhas da requisição. Varia dependendo da necessidade de cada transação.
    /// </summary>
    [DataContract]
    public partial class Cripto : IEquatable<Cripto>
    { 
        /// <summary>
        /// Em caso de cartão com chip, contém o criptograma dele.
        /// </summary>
        /// <value>Em caso de cartão com chip, contém o criptograma dele.</value>
        [DataMember(Name="criptogramaChip")]
        public string CriptogramaChip { get; set; }

        /// <summary>
        /// Hash de todos os campos que compõem a transação.
        /// </summary>
        /// <value>Hash de todos os campos que compõem a transação.</value>
        [DataMember(Name="hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Identificação positiva informada pelo usuário, caso utilizada, com no mínimo 8 dígitos corresponde às posições (botões) em cada tela apresentada. Caso a senha tenha menos de oito sílabas, são adicionados zeros para as telas não existentes (dado criptografado).
        /// </summary>
        /// <value>Identificação positiva informada pelo usuário, caso utilizada, com no mínimo 8 dígitos corresponde às posições (botões) em cada tela apresentada. Caso a senha tenha menos de oito sílabas, são adicionados zeros para as telas não existentes (dado criptografado).</value>
        [DataMember(Name="idPositiva")]
        public string IdPositiva { get; set; }

        /// <summary>
        /// Gets or Sets RespostaCliente
        /// </summary>
        [DataMember(Name="respostaCliente")]
        public CriptoRespostaCliente RespostaCliente { get; set; }

        /// <summary>
        /// Senha numérica criptografada.
        /// </summary>
        /// <value>Senha numérica criptografada.</value>
        [DataMember(Name="senha")]
        public string Senha { get; set; }

        /// <summary>
        /// Tamanho da senha numérica.
        /// </summary>
        /// <value>Tamanho da senha numérica.</value>
        [DataMember(Name="tamanhoSenha")]
        public string TamanhoSenha { get; set; }

        /// <summary>
        /// Em caso de biometria, contém o template gerado.
        /// </summary>
        /// <value>Em caso de biometria, contém o template gerado.</value>
        [DataMember(Name="templateBiometria")]
        public string TemplateBiometria { get; set; }

        /// <summary>
        /// Em caso de utilização de token para autenticação, contém o token informado pelo usuário.
        /// </summary>
        /// <value>Em caso de utilização de token para autenticação, contém o token informado pelo usuário.</value>
        [DataMember(Name="token")]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cripto {\n");
            sb.Append("  CriptogramaChip: ").Append(CriptogramaChip).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  IdPositiva: ").Append(IdPositiva).Append("\n");
            sb.Append("  RespostaCliente: ").Append(RespostaCliente).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            sb.Append("  TamanhoSenha: ").Append(TamanhoSenha).Append("\n");
            sb.Append("  TemplateBiometria: ").Append(TemplateBiometria).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Cripto)obj);
        }

        /// <summary>
        /// Returns true if Cripto instances are equal
        /// </summary>
        /// <param name="other">Instance of Cripto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cripto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CriptogramaChip == other.CriptogramaChip ||
                    CriptogramaChip != null &&
                    CriptogramaChip.Equals(other.CriptogramaChip)
                ) && 
                (
                    Hash == other.Hash ||
                    Hash != null &&
                    Hash.Equals(other.Hash)
                ) && 
                (
                    IdPositiva == other.IdPositiva ||
                    IdPositiva != null &&
                    IdPositiva.Equals(other.IdPositiva)
                ) && 
                (
                    RespostaCliente == other.RespostaCliente ||
                    RespostaCliente != null &&
                    RespostaCliente.Equals(other.RespostaCliente)
                ) && 
                (
                    Senha == other.Senha ||
                    Senha != null &&
                    Senha.Equals(other.Senha)
                ) && 
                (
                    TamanhoSenha == other.TamanhoSenha ||
                    TamanhoSenha != null &&
                    TamanhoSenha.Equals(other.TamanhoSenha)
                ) && 
                (
                    TemplateBiometria == other.TemplateBiometria ||
                    TemplateBiometria != null &&
                    TemplateBiometria.Equals(other.TemplateBiometria)
                ) && 
                (
                    Token == other.Token ||
                    Token != null &&
                    Token.Equals(other.Token)
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
                    if (CriptogramaChip != null)
                    hashCode = hashCode * 59 + CriptogramaChip.GetHashCode();
                    if (Hash != null)
                    hashCode = hashCode * 59 + Hash.GetHashCode();
                    if (IdPositiva != null)
                    hashCode = hashCode * 59 + IdPositiva.GetHashCode();
                    if (RespostaCliente != null)
                    hashCode = hashCode * 59 + RespostaCliente.GetHashCode();
                    if (Senha != null)
                    hashCode = hashCode * 59 + Senha.GetHashCode();
                    if (TamanhoSenha != null)
                    hashCode = hashCode * 59 + TamanhoSenha.GetHashCode();
                    if (TemplateBiometria != null)
                    hashCode = hashCode * 59 + TemplateBiometria.GetHashCode();
                    if (Token != null)
                    hashCode = hashCode * 59 + Token.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Cripto left, Cripto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Cripto left, Cripto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
