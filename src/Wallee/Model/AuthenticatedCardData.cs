using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// This model holds the card data and optional cardholder authentication details.
    /// </summary>
    [DataContract]
    public partial class AuthenticatedCardData : TokenizedCardData,  IEquatable<AuthenticatedCardData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedCardData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AuthenticatedCardData()
        {
        }




        /// <summary>
        /// The cardholder authentication information. The authentication is optional and can be provided if the cardholder has been already authenticated (e.g. in 3-D Secure system).
        /// </summary>
        /// <value>The cardholder authentication information. The authentication is optional and can be provided if the cardholder has been already authenticated (e.g. in 3-D Secure system).</value>
        [DataMember(Name="cardholderAuthentication", EmitDefaultValue=false)]
        public CardholderAuthentication CardholderAuthentication { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticatedCardData {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("  RecurringIndicator: ").Append(RecurringIndicator).Append("\n");
            sb.Append("  TokenRequestorId: ").Append(TokenRequestorId).Append("\n");
            sb.Append("  CardholderAuthentication: ").Append(CardholderAuthentication).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthenticatedCardData);
        }

        /// <summary>
        /// Returns true if AuthenticatedCardData instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticatedCardData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticatedCardData input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Cryptogram == input.Cryptogram ||
                    (this.Cryptogram != null &&
                    this.Cryptogram.Equals(input.Cryptogram))
                ) && base.Equals(input) && 
                (
                    this.RecurringIndicator == input.RecurringIndicator ||
                    (this.RecurringIndicator != null &&
                    this.RecurringIndicator.Equals(input.RecurringIndicator))
                ) && base.Equals(input) && 
                (
                    this.TokenRequestorId == input.TokenRequestorId ||
                    (this.TokenRequestorId != null &&
                    this.TokenRequestorId.Equals(input.TokenRequestorId))
                ) && base.Equals(input) && 
                (
                    this.CardholderAuthentication == input.CardholderAuthentication ||
                    (this.CardholderAuthentication != null &&
                    this.CardholderAuthentication.Equals(input.CardholderAuthentication))
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
                int hashCode = base.GetHashCode();
                if (this.Cryptogram != null)
                    hashCode = hashCode * 59 + this.Cryptogram.GetHashCode();
                if (this.RecurringIndicator != null)
                    hashCode = hashCode * 59 + this.RecurringIndicator.GetHashCode();
                if (this.TokenRequestorId != null)
                    hashCode = hashCode * 59 + this.TokenRequestorId.GetHashCode();
                if (this.CardholderAuthentication != null)
                    hashCode = hashCode * 59 + this.CardholderAuthentication.GetHashCode();
                return hashCode;
            }
        }

    }

}
