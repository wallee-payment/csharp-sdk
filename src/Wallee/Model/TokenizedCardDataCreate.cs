/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// TokenizedCardDataCreate
    /// </summary>
    [DataContract(Name = "TokenizedCardData.Create")]
    public partial class TokenizedCardDataCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PanType
        /// </summary>
        [DataMember(Name = "panType", EmitDefaultValue = false)]
        public PanType? PanType { get; set; }

        /// <summary>
        /// Gets or Sets RecurringIndicator
        /// </summary>
        [DataMember(Name = "recurringIndicator", EmitDefaultValue = false)]
        public RecurringIndicator? RecurringIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizedCardDataCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenizedCardDataCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizedCardDataCreate" /> class.
        /// </summary>
        /// <param name="expiryDate">The expiry date of the card, indicating its validity period in yyyy-mm format (e.g., 2023-09)..</param>
        /// <param name="panType">panType.</param>
        /// <param name="cardHolderName">The name of the cardholder, as printed on the card, identifying the card owner..</param>
        /// <param name="cardVerificationCode">The security code used to validate the card during transactions..</param>
        /// <param name="primaryAccountNumber">The card&#39;s primary account number (PAN), the unique identifier of the card. (required).</param>
        /// <param name="recurringIndicator">recurringIndicator.</param>
        /// <param name="schemeTransactionReference">A reference specific to the card&#39;s transaction within its payment scheme..</param>
        /// <param name="tokenRequestorId">The token requestor identifier (TRID) identifies the entity requesting tokenization for a card transaction..</param>
        /// <param name="cryptogram">cryptogram.</param>
        public TokenizedCardDataCreate(string expiryDate = default, PanType? panType = default, string cardHolderName = default, string cardVerificationCode = default, string primaryAccountNumber = default, RecurringIndicator? recurringIndicator = default, string schemeTransactionReference = default, string tokenRequestorId = default, CardCryptogramCreate cryptogram = default)
        {
            // to ensure "primaryAccountNumber" is required (not null)
            if (primaryAccountNumber == null)
            {
                throw new ArgumentNullException("primaryAccountNumber is a required property for TokenizedCardDataCreate and cannot be null");
            }
            this.PrimaryAccountNumber = primaryAccountNumber;
            this.ExpiryDate = expiryDate;
            this.PanType = panType;
            this.CardHolderName = cardHolderName;
            this.CardVerificationCode = cardVerificationCode;
            this.RecurringIndicator = recurringIndicator;
            this.SchemeTransactionReference = schemeTransactionReference;
            this.TokenRequestorId = tokenRequestorId;
            this.Cryptogram = cryptogram;
        }

        /// <summary>
        /// The expiry date of the card, indicating its validity period in yyyy-mm format (e.g., 2023-09).
        /// </summary>
        /// <value>The expiry date of the card, indicating its validity period in yyyy-mm format (e.g., 2023-09).</value>
        [DataMember(Name = "expiryDate", EmitDefaultValue = false)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// The name of the cardholder, as printed on the card, identifying the card owner.
        /// </summary>
        /// <value>The name of the cardholder, as printed on the card, identifying the card owner.</value>
        [DataMember(Name = "cardHolderName", EmitDefaultValue = false)]
        public string CardHolderName { get; set; }

        /// <summary>
        /// The security code used to validate the card during transactions.
        /// </summary>
        /// <value>The security code used to validate the card during transactions.</value>
        [DataMember(Name = "cardVerificationCode", EmitDefaultValue = false)]
        public string CardVerificationCode { get; set; }

        /// <summary>
        /// The card&#39;s primary account number (PAN), the unique identifier of the card.
        /// </summary>
        /// <value>The card&#39;s primary account number (PAN), the unique identifier of the card.</value>
        [DataMember(Name = "primaryAccountNumber", IsRequired = true, EmitDefaultValue = true)]
        public string PrimaryAccountNumber { get; set; }

        /// <summary>
        /// A reference specific to the card&#39;s transaction within its payment scheme.
        /// </summary>
        /// <value>A reference specific to the card&#39;s transaction within its payment scheme.</value>
        [DataMember(Name = "schemeTransactionReference", EmitDefaultValue = false)]
        public string SchemeTransactionReference { get; set; }

        /// <summary>
        /// The token requestor identifier (TRID) identifies the entity requesting tokenization for a card transaction.
        /// </summary>
        /// <value>The token requestor identifier (TRID) identifies the entity requesting tokenization for a card transaction.</value>
        [DataMember(Name = "tokenRequestorId", EmitDefaultValue = false)]
        public string TokenRequestorId { get; set; }

        /// <summary>
        /// Gets or Sets Cryptogram
        /// </summary>
        [DataMember(Name = "cryptogram", EmitDefaultValue = false)]
        public CardCryptogramCreate Cryptogram { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenizedCardDataCreate {\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  PanType: ").Append(PanType).Append("\n");
            sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
            sb.Append("  CardVerificationCode: ").Append(CardVerificationCode).Append("\n");
            sb.Append("  PrimaryAccountNumber: ").Append(PrimaryAccountNumber).Append("\n");
            sb.Append("  RecurringIndicator: ").Append(RecurringIndicator).Append("\n");
            sb.Append("  SchemeTransactionReference: ").Append(SchemeTransactionReference).Append("\n");
            sb.Append("  TokenRequestorId: ").Append(TokenRequestorId).Append("\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (this.ExpiryDate != null) {
                // ExpiryDate (string) pattern
                Regex regexExpiryDate = new Regex(@"(\d{4})-(11|12|10|0[1-9])", RegexOptions.CultureInvariant);
                if (!regexExpiryDate.Match(this.ExpiryDate).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiryDate, must match a pattern of " + regexExpiryDate, new [] { "ExpiryDate" });
                }
            }

            // CardHolderName (string) maxLength
            if (this.CardHolderName != null && this.CardHolderName.Length > 100)
            {
                yield return new ValidationResult("Invalid value for CardHolderName, length must be less than 100.", new [] { "CardHolderName" });
            }

            // CardVerificationCode (string) maxLength
            if (this.CardVerificationCode != null && this.CardVerificationCode.Length > 4)
            {
                yield return new ValidationResult("Invalid value for CardVerificationCode, length must be less than 4.", new [] { "CardVerificationCode" });
            }

            // CardVerificationCode (string) minLength
            if (this.CardVerificationCode != null && this.CardVerificationCode.Length < 3)
            {
                yield return new ValidationResult("Invalid value for CardVerificationCode, length must be greater than 3.", new [] { "CardVerificationCode" });
            }

            if (this.CardVerificationCode != null) {
                // CardVerificationCode (string) pattern
                Regex regexCardVerificationCode = new Regex(@"([0-9 ]+)", RegexOptions.CultureInvariant);
                if (!regexCardVerificationCode.Match(this.CardVerificationCode).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardVerificationCode, must match a pattern of " + regexCardVerificationCode, new [] { "CardVerificationCode" });
                }
            }

            // PrimaryAccountNumber (string) maxLength
            if (this.PrimaryAccountNumber != null && this.PrimaryAccountNumber.Length > 30)
            {
                yield return new ValidationResult("Invalid value for PrimaryAccountNumber, length must be less than 30.", new [] { "PrimaryAccountNumber" });
            }

            // PrimaryAccountNumber (string) minLength
            if (this.PrimaryAccountNumber != null && this.PrimaryAccountNumber.Length < 10)
            {
                yield return new ValidationResult("Invalid value for PrimaryAccountNumber, length must be greater than 10.", new [] { "PrimaryAccountNumber" });
            }

            if (this.PrimaryAccountNumber != null) {
                // PrimaryAccountNumber (string) pattern
                Regex regexPrimaryAccountNumber = new Regex(@"([0-9 ]+)", RegexOptions.CultureInvariant);
                if (!regexPrimaryAccountNumber.Match(this.PrimaryAccountNumber).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrimaryAccountNumber, must match a pattern of " + regexPrimaryAccountNumber, new [] { "PrimaryAccountNumber" });
                }
            }

            // SchemeTransactionReference (string) maxLength
            if (this.SchemeTransactionReference != null && this.SchemeTransactionReference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for SchemeTransactionReference, length must be less than 100.", new [] { "SchemeTransactionReference" });
            }

            yield break;
        }
    }

}
