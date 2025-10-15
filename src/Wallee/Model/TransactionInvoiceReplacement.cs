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
    /// TransactionInvoiceReplacement
    /// </summary>
    [DataContract]
    public partial class TransactionInvoiceReplacement :  IEquatable<TransactionInvoiceReplacement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceReplacement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionInvoiceReplacement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceReplacement" /> class.
        /// </summary>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="lineItems">The invoiced line items that will appear on the invoice document. (required).</param>
        public TransactionInvoiceReplacement(string externalId, List<LineItemCreate> lineItems)
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for TransactionInvoiceReplacement and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "lineItems" is required (not null)
            if (lineItems == null)
            {
                throw new InvalidDataException("lineItems is a required property for TransactionInvoiceReplacement and cannot be null");
            }
            this.LineItems = lineItems;
        }

        /// <summary>
        /// The address associated with the invoice, used for billing purposes.
        /// </summary>
        /// <value>The address associated with the invoice, used for billing purposes.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// The due date for payment of the invoice.
        /// </summary>
        /// <value>The due date for payment of the invoice.</value>
        [DataMember(Name="dueOn", EmitDefaultValue=false)]
        public DateTime? DueOn { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The invoiced line items that will appear on the invoice document.
        /// </summary>
        /// <value>The invoiced line items that will appear on the invoice document.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the invoice.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the invoice.</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Whether the invoice will be sent to the customer via email.
        /// </summary>
        /// <value>Whether the invoice will be sent to the customer via email.</value>
        [DataMember(Name="sentToCustomer", EmitDefaultValue=false)]
        public bool? SentToCustomer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionInvoiceReplacement {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  SentToCustomer: ").Append(SentToCustomer).Append("\n");
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
            return this.Equals(input as TransactionInvoiceReplacement);
        }

        /// <summary>
        /// Returns true if TransactionInvoiceReplacement instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionInvoiceReplacement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInvoiceReplacement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.DueOn == input.DueOn ||
                    (this.DueOn != null &&
                    this.DueOn.Equals(input.DueOn))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.SentToCustomer == input.SentToCustomer ||
                    (this.SentToCustomer != null &&
                    this.SentToCustomer.Equals(input.SentToCustomer))
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
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.DueOn != null)
                    hashCode = hashCode * 59 + this.DueOn.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.SentToCustomer != null)
                    hashCode = hashCode * 59 + this.SentToCustomer.GetHashCode();
                return hashCode;
            }
        }

    }

}
