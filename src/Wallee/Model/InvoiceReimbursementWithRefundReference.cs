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
    /// InvoiceReimbursementWithRefundReference
    /// </summary>
    [DataContract]
    public partial class InvoiceReimbursementWithRefundReference : InvoiceReimbursement,  IEquatable<InvoiceReimbursementWithRefundReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReimbursementWithRefundReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InvoiceReimbursementWithRefundReference()
        {
        }






















        /// <summary>
        /// Gets or Sets RefundMerchantReference
        /// </summary>
        [DataMember(Name="refundMerchantReference", EmitDefaultValue=false)]
        public string RefundMerchantReference { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceReimbursementWithRefundReference {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DiscardedBy: ").Append(DiscardedBy).Append("\n");
            sb.Append("  DiscardedOn: ").Append(DiscardedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PaymentConnectorConfiguration: ").Append(PaymentConnectorConfiguration).Append("\n");
            sb.Append("  PaymentInitiationAdviceFile: ").Append(PaymentInitiationAdviceFile).Append("\n");
            sb.Append("  ProcessedBy: ").Append(ProcessedBy).Append("\n");
            sb.Append("  ProcessedOn: ").Append(ProcessedOn).Append("\n");
            sb.Append("  RecipientCity: ").Append(RecipientCity).Append("\n");
            sb.Append("  RecipientCountry: ").Append(RecipientCountry).Append("\n");
            sb.Append("  RecipientFamilyName: ").Append(RecipientFamilyName).Append("\n");
            sb.Append("  RecipientGivenName: ").Append(RecipientGivenName).Append("\n");
            sb.Append("  RecipientIban: ").Append(RecipientIban).Append("\n");
            sb.Append("  RecipientPostcode: ").Append(RecipientPostcode).Append("\n");
            sb.Append("  RecipientStreet: ").Append(RecipientStreet).Append("\n");
            sb.Append("  SenderIban: ").Append(SenderIban).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  RefundMerchantReference: ").Append(RefundMerchantReference).Append("\n");
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
            return this.Equals(input as InvoiceReimbursementWithRefundReference);
        }

        /// <summary>
        /// Returns true if InvoiceReimbursementWithRefundReference instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceReimbursementWithRefundReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceReimbursementWithRefundReference input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.DiscardedBy == input.DiscardedBy ||
                    (this.DiscardedBy != null &&
                    this.DiscardedBy.Equals(input.DiscardedBy))
                ) && base.Equals(input) && 
                (
                    this.DiscardedOn == input.DiscardedOn ||
                    (this.DiscardedOn != null &&
                    this.DiscardedOn.Equals(input.DiscardedOn))
                ) && base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && base.Equals(input) && 
                (
                    this.PaymentConnectorConfiguration == input.PaymentConnectorConfiguration ||
                    (this.PaymentConnectorConfiguration != null &&
                    this.PaymentConnectorConfiguration.Equals(input.PaymentConnectorConfiguration))
                ) && base.Equals(input) && 
                (
                    this.PaymentInitiationAdviceFile == input.PaymentInitiationAdviceFile ||
                    (this.PaymentInitiationAdviceFile != null &&
                    this.PaymentInitiationAdviceFile.Equals(input.PaymentInitiationAdviceFile))
                ) && base.Equals(input) && 
                (
                    this.ProcessedBy == input.ProcessedBy ||
                    (this.ProcessedBy != null &&
                    this.ProcessedBy.Equals(input.ProcessedBy))
                ) && base.Equals(input) && 
                (
                    this.ProcessedOn == input.ProcessedOn ||
                    (this.ProcessedOn != null &&
                    this.ProcessedOn.Equals(input.ProcessedOn))
                ) && base.Equals(input) && 
                (
                    this.RecipientCity == input.RecipientCity ||
                    (this.RecipientCity != null &&
                    this.RecipientCity.Equals(input.RecipientCity))
                ) && base.Equals(input) && 
                (
                    this.RecipientCountry == input.RecipientCountry ||
                    (this.RecipientCountry != null &&
                    this.RecipientCountry.Equals(input.RecipientCountry))
                ) && base.Equals(input) && 
                (
                    this.RecipientFamilyName == input.RecipientFamilyName ||
                    (this.RecipientFamilyName != null &&
                    this.RecipientFamilyName.Equals(input.RecipientFamilyName))
                ) && base.Equals(input) && 
                (
                    this.RecipientGivenName == input.RecipientGivenName ||
                    (this.RecipientGivenName != null &&
                    this.RecipientGivenName.Equals(input.RecipientGivenName))
                ) && base.Equals(input) && 
                (
                    this.RecipientIban == input.RecipientIban ||
                    (this.RecipientIban != null &&
                    this.RecipientIban.Equals(input.RecipientIban))
                ) && base.Equals(input) && 
                (
                    this.RecipientPostcode == input.RecipientPostcode ||
                    (this.RecipientPostcode != null &&
                    this.RecipientPostcode.Equals(input.RecipientPostcode))
                ) && base.Equals(input) && 
                (
                    this.RecipientStreet == input.RecipientStreet ||
                    (this.RecipientStreet != null &&
                    this.RecipientStreet.Equals(input.RecipientStreet))
                ) && base.Equals(input) && 
                (
                    this.SenderIban == input.SenderIban ||
                    (this.SenderIban != null &&
                    this.SenderIban.Equals(input.SenderIban))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && base.Equals(input) && 
                (
                    this.RefundMerchantReference == input.RefundMerchantReference ||
                    (this.RefundMerchantReference != null &&
                    this.RefundMerchantReference.Equals(input.RefundMerchantReference))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DiscardedBy != null)
                    hashCode = hashCode * 59 + this.DiscardedBy.GetHashCode();
                if (this.DiscardedOn != null)
                    hashCode = hashCode * 59 + this.DiscardedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PaymentConnectorConfiguration != null)
                    hashCode = hashCode * 59 + this.PaymentConnectorConfiguration.GetHashCode();
                if (this.PaymentInitiationAdviceFile != null)
                    hashCode = hashCode * 59 + this.PaymentInitiationAdviceFile.GetHashCode();
                if (this.ProcessedBy != null)
                    hashCode = hashCode * 59 + this.ProcessedBy.GetHashCode();
                if (this.ProcessedOn != null)
                    hashCode = hashCode * 59 + this.ProcessedOn.GetHashCode();
                if (this.RecipientCity != null)
                    hashCode = hashCode * 59 + this.RecipientCity.GetHashCode();
                if (this.RecipientCountry != null)
                    hashCode = hashCode * 59 + this.RecipientCountry.GetHashCode();
                if (this.RecipientFamilyName != null)
                    hashCode = hashCode * 59 + this.RecipientFamilyName.GetHashCode();
                if (this.RecipientGivenName != null)
                    hashCode = hashCode * 59 + this.RecipientGivenName.GetHashCode();
                if (this.RecipientIban != null)
                    hashCode = hashCode * 59 + this.RecipientIban.GetHashCode();
                if (this.RecipientPostcode != null)
                    hashCode = hashCode * 59 + this.RecipientPostcode.GetHashCode();
                if (this.RecipientStreet != null)
                    hashCode = hashCode * 59 + this.RecipientStreet.GetHashCode();
                if (this.SenderIban != null)
                    hashCode = hashCode * 59 + this.SenderIban.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.RefundMerchantReference != null)
                    hashCode = hashCode * 59 + this.RefundMerchantReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
