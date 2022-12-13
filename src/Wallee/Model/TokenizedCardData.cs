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
    /// This model holds the card data in plain.
    /// </summary>
    [DataContract]
    public partial class TokenizedCardData :  IEquatable<TokenizedCardData>
    {
        /// <summary>
        /// Gets or Sets RecurringIndicator
        /// </summary>
        [DataMember(Name="recurringIndicator", EmitDefaultValue=false)]
        public RecurringIndicator? RecurringIndicator { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizedCardData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TokenizedCardData()
        {
        }

        /// <summary>
        /// The additional authentication value used to secure the tokenized card transactions.
        /// </summary>
        /// <value>The additional authentication value used to secure the tokenized card transactions.</value>
        [DataMember(Name="cryptogram", EmitDefaultValue=false)]
        public CardCryptogram Cryptogram { get; private set; }


        /// <summary>
        /// Gets or Sets TokenRequestorId
        /// </summary>
        [DataMember(Name="tokenRequestorId", EmitDefaultValue=false)]
        public string TokenRequestorId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenizedCardData {\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("  RecurringIndicator: ").Append(RecurringIndicator).Append("\n");
            sb.Append("  TokenRequestorId: ").Append(TokenRequestorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TokenizedCardData);
        }

        /// <summary>
        /// Returns true if TokenizedCardData instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenizedCardData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenizedCardData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cryptogram == input.Cryptogram ||
                    (this.Cryptogram != null &&
                    this.Cryptogram.Equals(input.Cryptogram))
                ) && 
                (
                    this.RecurringIndicator == input.RecurringIndicator ||
                    (this.RecurringIndicator != null &&
                    this.RecurringIndicator.Equals(input.RecurringIndicator))
                ) && 
                (
                    this.TokenRequestorId == input.TokenRequestorId ||
                    (this.TokenRequestorId != null &&
                    this.TokenRequestorId.Equals(input.TokenRequestorId))
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
                int hashCode = 41;
                if (this.Cryptogram != null)
                    hashCode = hashCode * 59 + this.Cryptogram.GetHashCode();
                if (this.RecurringIndicator != null)
                    hashCode = hashCode * 59 + this.RecurringIndicator.GetHashCode();
                if (this.TokenRequestorId != null)
                    hashCode = hashCode * 59 + this.TokenRequestorId.GetHashCode();
                return hashCode;
            }
        }

    }

}
