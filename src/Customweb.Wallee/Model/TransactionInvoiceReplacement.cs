
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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// TransactionInvoiceReplacement model.
    /// </summary>
    [DataContract]
    public partial class TransactionInvoiceReplacement :  IEquatable<TransactionInvoiceReplacement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceReplacement" /> class.
        /// </summary>
        /// <param name="DueOn">The date on which the invoice should be paid on.</param>
        /// <param name="ExternalId">ExternalId</param>
        /// <param name="LineItems">LineItems</param>
        /// <param name="MerchantReference">MerchantReference</param>
        /// <param name="SentToCustomer">When the connector is configured to send the invoice to the customer and this property is true the customer will receive an email with the updated invoice. When this property is false no invoice is sent.</param>
        public TransactionInvoiceReplacement(DateTime? DueOn = default(DateTime?), string ExternalId = default(string), List<LineItemCreate> LineItems = default(List<LineItemCreate>), string MerchantReference = default(string), bool? SentToCustomer = default(bool?))
        {
            this.DueOn = DueOn;
            this.ExternalId = ExternalId;
            this.LineItems = LineItems;
            this.MerchantReference = MerchantReference;
            this.SentToCustomer = SentToCustomer;
        }

        /// <summary>
        /// The date on which the invoice should be paid on.
        /// </summary>
        /// <value>The date on which the invoice should be paid on.</value>
        [DataMember(Name="dueOn", EmitDefaultValue=false)]
        public DateTime? DueOn { get; set; }

        /// <summary>
        /// ExternalId
        /// </summary>
        /// <value>ExternalId</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// LineItems
        /// </summary>
        /// <value>LineItems</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// MerchantReference
        /// </summary>
        /// <value>MerchantReference</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// When the connector is configured to send the invoice to the customer and this property is true the customer will receive an email with the updated invoice. When this property is false no invoice is sent.
        /// </summary>
        /// <value>When the connector is configured to send the invoice to the customer and this property is true the customer will receive an email with the updated invoice. When this property is false no invoice is sent.</value>
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
            return this.Equals(obj as TransactionInvoiceReplacement);
        }

        /// <summary>
        /// Returns true if TransactionInvoiceReplacement instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionInvoiceReplacement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInvoiceReplacement other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.DueOn == other.DueOn ||
                    this.DueOn != null &&
                    this.DueOn.Equals(other.DueOn)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.SentToCustomer == other.SentToCustomer ||
                    this.SentToCustomer != null &&
                    this.SentToCustomer.Equals(other.SentToCustomer)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DueOn != null)
                    hash = hash * 59 + this.DueOn.GetHashCode();
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.MerchantReference != null)
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                if (this.SentToCustomer != null)
                    hash = hash * 59 + this.SentToCustomer.GetHashCode();
                return hash;
            }
        }

    }

}
