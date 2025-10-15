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
    /// AuthenticatedCardDataCreate
    /// </summary>
    [DataContract]
    public partial class AuthenticatedCardDataCreate :  IEquatable<AuthenticatedCardDataCreate>
    {
        /// <summary>
        /// The type of PAN or token, indicating the source or security method of the card information.
        /// </summary>
        /// <value>The type of PAN or token, indicating the source or security method of the card information.</value>
        [DataMember(Name="panType", EmitDefaultValue=false)]
        public PanType? PanType { get; set; }
        /// <summary>
        /// The indicator used to distinguish between recurring and one-time transactions. If omitted, it will be automatically determined based on the transaction&#39;s properties.
        /// </summary>
        /// <value>The indicator used to distinguish between recurring and one-time transactions. If omitted, it will be automatically determined based on the transaction&#39;s properties.</value>
        [DataMember(Name="recurringIndicator", EmitDefaultValue=false)]
        public RecurringIndicator? RecurringIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedCardDataCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticatedCardDataCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedCardDataCreate" /> class.
        /// </summary>
        /// <param name="primaryAccountNumber">The card&#39;s primary account number (PAN), the unique identifier of the card. (required).</param>
        public AuthenticatedCardDataCreate(string primaryAccountNumber)
        {
            // to ensure "primaryAccountNumber" is required (not null)
            if (primaryAccountNumber == null)
            {
                throw new InvalidDataException("primaryAccountNumber is a required property for AuthenticatedCardDataCreate and cannot be null");
            }
            this.PrimaryAccountNumber = primaryAccountNumber;
        }

        /// <summary>
        /// The name of the cardholder, as printed on the card, identifying the card owner.
        /// </summary>
        /// <value>The name of the cardholder, as printed on the card, identifying the card owner.</value>
        [DataMember(Name="cardHolderName", EmitDefaultValue=false)]
        public string CardHolderName { get; set; }

        /// <summary>
        /// The security code used to validate the card during transactions.
        /// </summary>
        /// <value>The security code used to validate the card during transactions.</value>
        [DataMember(Name="cardVerificationCode", EmitDefaultValue=false)]
        public string CardVerificationCode { get; set; }

        /// <summary>
        /// Optional authentication details for the cardholder, such as 3D Secure authentication, used when the cardholder has already been verified during the transaction for added security.
        /// </summary>
        /// <value>Optional authentication details for the cardholder, such as 3D Secure authentication, used when the cardholder has already been verified during the transaction for added security.</value>
        [DataMember(Name="cardholderAuthentication", EmitDefaultValue=false)]
        public CardholderAuthenticationCreate CardholderAuthentication { get; set; }

        /// <summary>
        /// An additional authentication value that enhances the security of tokenized card transactions.
        /// </summary>
        /// <value>An additional authentication value that enhances the security of tokenized card transactions.</value>
        [DataMember(Name="cryptogram", EmitDefaultValue=false)]
        public CardCryptogramCreate Cryptogram { get; set; }

        /// <summary>
        /// The expiry date of the card, indicating its validity period in yyyy-mm format (e.g., 2023-09).
        /// </summary>
        /// <value>The expiry date of the card, indicating its validity period in yyyy-mm format (e.g., 2023-09).</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public string ExpiryDate { get; set; }


        /// <summary>
        /// The card&#39;s primary account number (PAN), the unique identifier of the card.
        /// </summary>
        /// <value>The card&#39;s primary account number (PAN), the unique identifier of the card.</value>
        [DataMember(Name="primaryAccountNumber", EmitDefaultValue=false)]
        public string PrimaryAccountNumber { get; set; }


        /// <summary>
        /// A reference specific to the card&#39;s transaction within its payment scheme.
        /// </summary>
        /// <value>A reference specific to the card&#39;s transaction within its payment scheme.</value>
        [DataMember(Name="schemeTransactionReference", EmitDefaultValue=false)]
        public string SchemeTransactionReference { get; set; }

        /// <summary>
        /// The token requestor identifier (TRID) identifies the entity requesting tokenization for a card transaction.
        /// </summary>
        /// <value>The token requestor identifier (TRID) identifies the entity requesting tokenization for a card transaction.</value>
        [DataMember(Name="tokenRequestorId", EmitDefaultValue=false)]
        public string TokenRequestorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticatedCardDataCreate {\n");
            sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
            sb.Append("  CardVerificationCode: ").Append(CardVerificationCode).Append("\n");
            sb.Append("  CardholderAuthentication: ").Append(CardholderAuthentication).Append("\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  PanType: ").Append(PanType).Append("\n");
            sb.Append("  PrimaryAccountNumber: ").Append(PrimaryAccountNumber).Append("\n");
            sb.Append("  RecurringIndicator: ").Append(RecurringIndicator).Append("\n");
            sb.Append("  SchemeTransactionReference: ").Append(SchemeTransactionReference).Append("\n");
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
            return this.Equals(input as AuthenticatedCardDataCreate);
        }

        /// <summary>
        /// Returns true if AuthenticatedCardDataCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticatedCardDataCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticatedCardDataCreate input)
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
                    this.CardholderAuthentication == input.CardholderAuthentication ||
                    (this.CardholderAuthentication != null &&
                    this.CardholderAuthentication.Equals(input.CardholderAuthentication))
                ) && 
                (
                    this.Cryptogram == input.Cryptogram ||
                    (this.Cryptogram != null &&
                    this.Cryptogram.Equals(input.Cryptogram))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.PanType == input.PanType ||
                    (this.PanType != null &&
                    this.PanType.Equals(input.PanType))
                ) && 
                (
                    this.PrimaryAccountNumber == input.PrimaryAccountNumber ||
                    (this.PrimaryAccountNumber != null &&
                    this.PrimaryAccountNumber.Equals(input.PrimaryAccountNumber))
                ) && 
                (
                    this.RecurringIndicator == input.RecurringIndicator ||
                    (this.RecurringIndicator != null &&
                    this.RecurringIndicator.Equals(input.RecurringIndicator))
                ) && 
                (
                    this.SchemeTransactionReference == input.SchemeTransactionReference ||
                    (this.SchemeTransactionReference != null &&
                    this.SchemeTransactionReference.Equals(input.SchemeTransactionReference))
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
                if (this.CardHolderName != null)
                    hashCode = hashCode * 59 + this.CardHolderName.GetHashCode();
                if (this.CardVerificationCode != null)
                    hashCode = hashCode * 59 + this.CardVerificationCode.GetHashCode();
                if (this.CardholderAuthentication != null)
                    hashCode = hashCode * 59 + this.CardholderAuthentication.GetHashCode();
                if (this.Cryptogram != null)
                    hashCode = hashCode * 59 + this.Cryptogram.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.PanType != null)
                    hashCode = hashCode * 59 + this.PanType.GetHashCode();
                if (this.PrimaryAccountNumber != null)
                    hashCode = hashCode * 59 + this.PrimaryAccountNumber.GetHashCode();
                if (this.RecurringIndicator != null)
                    hashCode = hashCode * 59 + this.RecurringIndicator.GetHashCode();
                if (this.SchemeTransactionReference != null)
                    hashCode = hashCode * 59 + this.SchemeTransactionReference.GetHashCode();
                if (this.TokenRequestorId != null)
                    hashCode = hashCode * 59 + this.TokenRequestorId.GetHashCode();
                return hashCode;
            }
        }

    }

}
