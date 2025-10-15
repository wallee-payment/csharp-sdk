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
    /// CardCryptogramCreate
    /// </summary>
    [DataContract]
    public partial class CardCryptogramCreate :  IEquatable<CardCryptogramCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardCryptogramCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardCryptogramCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardCryptogramCreate" /> class.
        /// </summary>
        /// <param name="value">The cryptogram value used for securing card transactions, format varying based on the PAN type. (required).</param>
        public CardCryptogramCreate(string value)
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for CardCryptogramCreate and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// The Electronic Commerce Indicator (ECI) represents the authentication level and indicates liability shift during online or card-not-present transactions.
        /// </summary>
        /// <value>The Electronic Commerce Indicator (ECI) represents the authentication level and indicates liability shift during online or card-not-present transactions.</value>
        [DataMember(Name="eci", EmitDefaultValue=false)]
        public string Eci { get; set; }

        /// <summary>
        /// The cryptogram value used for securing card transactions, format varying based on the PAN type.
        /// </summary>
        /// <value>The cryptogram value used for securing card transactions, format varying based on the PAN type.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardCryptogramCreate {\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as CardCryptogramCreate);
        }

        /// <summary>
        /// Returns true if CardCryptogramCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of CardCryptogramCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardCryptogramCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Eci == input.Eci ||
                    (this.Eci != null &&
                    this.Eci.Equals(input.Eci))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Eci != null)
                    hashCode = hashCode * 59 + this.Eci.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}
