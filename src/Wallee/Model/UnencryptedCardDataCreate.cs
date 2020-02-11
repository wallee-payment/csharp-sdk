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
    public partial class UnencryptedCardDataCreate :  IEquatable<UnencryptedCardDataCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnencryptedCardDataCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnencryptedCardDataCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnencryptedCardDataCreate" /> class.
        /// </summary>
        /// <param name="primaryAccountNumber">The primary account number (PAN) identifies the card. The number is numeric and typically printed on the front of the card. (required).</param>
        public UnencryptedCardDataCreate(string primaryAccountNumber)
        {
            // to ensure "primaryAccountNumber" is required (not null)
            if (primaryAccountNumber == null)
            {
                throw new InvalidDataException("primaryAccountNumber is a required property for UnencryptedCardDataCreate and cannot be null");
            }
            this.PrimaryAccountNumber = primaryAccountNumber;
        }

        /// <summary>
        /// The card holder name is the name printed onto the card. It identifies the person who owns the card.
        /// </summary>
        /// <value>The card holder name is the name printed onto the card. It identifies the person who owns the card.</value>
        [DataMember(Name="cardHolderName", EmitDefaultValue=true)]
        public string CardHolderName { get; set; }

        /// <summary>
        /// The card verification code (CVC) is a 3 to 4 digit code typically printed on the back of the card. It helps to ensure that the card holder is authorizing the transaction. For card not-present transactions this field is optional.
        /// </summary>
        /// <value>The card verification code (CVC) is a 3 to 4 digit code typically printed on the back of the card. It helps to ensure that the card holder is authorizing the transaction. For card not-present transactions this field is optional.</value>
        [DataMember(Name="cardVerificationCode", EmitDefaultValue=true)]
        public string CardVerificationCode { get; set; }

        /// <summary>
        /// The card expiry date indicates when the card expires. The format is the format yyyy-mm where yyyy is the year (e.g. 2019) and the mm is the month (e.g. 09).
        /// </summary>
        /// <value>The card expiry date indicates when the card expires. The format is the format yyyy-mm where yyyy is the year (e.g. 2019) and the mm is the month (e.g. 09).</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=true)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// The primary account number (PAN) identifies the card. The number is numeric and typically printed on the front of the card.
        /// </summary>
        /// <value>The primary account number (PAN) identifies the card. The number is numeric and typically printed on the front of the card.</value>
        [DataMember(Name="primaryAccountNumber", EmitDefaultValue=true)]
        public string PrimaryAccountNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnencryptedCardDataCreate {\n");
            sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
            sb.Append("  CardVerificationCode: ").Append(CardVerificationCode).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  PrimaryAccountNumber: ").Append(PrimaryAccountNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnencryptedCardDataCreate);
        }

        /// <summary>
        /// Returns true if UnencryptedCardDataCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of UnencryptedCardDataCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnencryptedCardDataCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardHolderName == input.CardHolderName ||
                    (this.CardHolderName != null &&
                    this.CardHolderName.Equals(input.CardHolderName))
                ) && 
                (
                    this.CardVerificationCode == input.CardVerificationCode ||
                    (this.CardVerificationCode != null &&
                    this.CardVerificationCode.Equals(input.CardVerificationCode))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.PrimaryAccountNumber == input.PrimaryAccountNumber ||
                    (this.PrimaryAccountNumber != null &&
                    this.PrimaryAccountNumber.Equals(input.PrimaryAccountNumber))
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
                if (this.CardHolderName != null)
                    hashCode = hashCode * 59 + this.CardHolderName.GetHashCode();
                if (this.CardVerificationCode != null)
                    hashCode = hashCode * 59 + this.CardVerificationCode.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.PrimaryAccountNumber != null)
                    hashCode = hashCode * 59 + this.PrimaryAccountNumber.GetHashCode();
                return hashCode;
            }
        }

    }

}
