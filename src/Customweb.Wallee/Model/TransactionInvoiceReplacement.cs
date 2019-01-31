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
    /// Transaction Invoice Replacement
    /// </summary>
    [DataContract]
    public partial class TransactionInvoiceReplacement :  IEquatable<TransactionInvoiceReplacement>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceReplacement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionInvoiceReplacement() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceReplacement" /> class.
        /// </summary>
        /// <param name="BillingAddress">BillingAddress</param>
        /// <param name="DueOn">The date on which the invoice should be paid on.</param>
        /// <param name="ExternalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required)</param>
        /// <param name="LineItems">LineItems (required)</param>
        /// <param name="MerchantReference">MerchantReference</param>
        /// <param name="SentToCustomer">When the connector is configured to send the invoice to the customer and this property is true the customer will receive an email with the updated invoice. When this property is false no invoice is sent.</param>
        public TransactionInvoiceReplacement(bool? SentToCustomer = default(bool?), List<LineItemCreate> LineItems = default(List<LineItemCreate>), AddressCreate BillingAddress = default(AddressCreate), DateTime? DueOn = default(DateTime?), string MerchantReference = default(string), string ExternalId = default(string))
        {
            // to ensure "ExternalId" is required (not null)
            if (ExternalId == null)
            {
                throw new ArgumentNullException("ExternalId is a required property for TransactionInvoiceReplacement and cannot be null");
            }
            else
            {
                this.ExternalId = ExternalId;
            }
            // to ensure "LineItems" is required (not null)
            if (LineItems == null)
            {
                throw new ArgumentNullException("LineItems is a required property for TransactionInvoiceReplacement and cannot be null");
            }
            else
            {
                this.LineItems = LineItems;
            }
            this.BillingAddress = BillingAddress;
            this.DueOn = DueOn;
            this.MerchantReference = MerchantReference;
            this.SentToCustomer = SentToCustomer;
        }

        /// <summary>
        /// BillingAddress
        /// </summary>
        /// <value>BillingAddress</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// The date on which the invoice should be paid on.
        /// </summary>
        /// <value>The date on which the invoice should be paid on.</value>
        [DataMember(Name="dueOn", EmitDefaultValue=false)]
        public DateTime? DueOn { get; set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
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
            return this.ToJson();
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
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
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
                if (this.BillingAddress != null)
                {
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                }
                if (this.DueOn != null)
                {
                    hash = hash * 59 + this.DueOn.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                }
                if (this.SentToCustomer != null)
                {
                    hash = hash * 59 + this.SentToCustomer.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
