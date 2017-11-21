/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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
    /// The payment link defines an URL to automatically create transactions.
    /// </summary>
    [DataContract]
    public partial class PaymentLink :  IEquatable<PaymentLink>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentLink()
        {
        }

        /// <summary>
        /// The allowed payment method configurations restrict the payment methods which can be used with this payment link.
        /// </summary>
        /// <value>The allowed payment method configurations restrict the payment methods which can be used with this payment link.</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// The payment link can be conducted in a specific space view. The space view may apply a specific design to the payment page.
        /// </summary>
        /// <value>The payment link can be conducted in a specific space view. The space view may apply a specific design to the payment page.</value>
        [DataMember(Name="appliedSpaceView", EmitDefaultValue=false)]
        public long? AppliedSpaceView { get; private set; }

        /// <summary>
        /// The available from date defines the earliest date on which the payment link can be used. When no date is specified there will be no restriction.
        /// </summary>
        /// <value>The available from date defines the earliest date on which the payment link can be used. When no date is specified there will be no restriction.</value>
        [DataMember(Name="availableFrom", EmitDefaultValue=false)]
        public DateTime? AvailableFrom { get; private set; }

        /// <summary>
        /// The available from date defines the latest date on which the payment link can be used to initialize a transaction. When no date is specified there will be no restriction.
        /// </summary>
        /// <value>The available from date defines the latest date on which the payment link can be used to initialize a transaction. When no date is specified there will be no restriction.</value>
        [DataMember(Name="availableUntil", EmitDefaultValue=false)]
        public DateTime? AvailableUntil { get; private set; }

        /// <summary>
        /// By making the billing address required the transaction can only be created when a billing address is provided within the request.
        /// </summary>
        /// <value>By making the billing address required the transaction can only be created when a billing address is provided within the request.</value>
        [DataMember(Name="billingAddressRequired", EmitDefaultValue=false)]
        public bool? BillingAddressRequired { get; private set; }

        /// <summary>
        /// The currency defines in which currency the payment is executed in. If no currency is defined it has to be specified within the request parameter &#39;currency&#39;.
        /// </summary>
        /// <value>The currency defines in which currency the payment is executed in. If no currency is defined it has to be specified within the request parameter &#39;currency&#39;.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The language defines the language of the payment page. If no language is provided it can be provided through the request parameter.
        /// </summary>
        /// <value>The language defines the language of the payment page. If no language is provided it can be provided through the request parameter.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The line items allows to define the line items for this payment link. When the line items are defined they cannot be overridden through the request parameters.
        /// </summary>
        /// <value>The line items allows to define the line items for this payment link. When the line items are defined they cannot be overridden through the request parameters.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The maximal number of transactions limits the number of transactions which can be created with this payment link.
        /// </summary>
        /// <value>The maximal number of transactions limits the number of transactions which can be created with this payment link.</value>
        [DataMember(Name="maximalNumberOfTransactions", EmitDefaultValue=false)]
        public int? MaximalNumberOfTransactions { get; private set; }

        /// <summary>
        /// The payment link name is used internally to identify the payment link. For example the name is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The payment link name is used internally to identify the payment link. For example the name is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// By making the shipping address required the transaction can only be created when a shipping address is provided within the request.
        /// </summary>
        /// <value>By making the shipping address required the transaction can only be created when a shipping address is provided within the request.</value>
        [DataMember(Name="shippingAddressRequired", EmitDefaultValue=false)]
        public bool? ShippingAddressRequired { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }

        /// <summary>
        /// The URL defines the URL to which the user has to be forwarded to initialize the payment.
        /// </summary>
        /// <value>The URL defines the URL to which the user has to be forwarded to initialize the payment.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

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
            return this.Equals(obj as PaymentLink);
        }

        /// <summary>
        /// Returns true if PaymentLink instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLink other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AllowedPaymentMethodConfigurations == other.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(other.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.AppliedSpaceView == other.AppliedSpaceView ||
                    this.AppliedSpaceView != null &&
                    this.AppliedSpaceView.Equals(other.AppliedSpaceView)
                ) && 
                (
                    this.AvailableFrom == other.AvailableFrom ||
                    this.AvailableFrom != null &&
                    this.AvailableFrom.Equals(other.AvailableFrom)
                ) && 
                (
                    this.AvailableUntil == other.AvailableUntil ||
                    this.AvailableUntil != null &&
                    this.AvailableUntil.Equals(other.AvailableUntil)
                ) && 
                (
                    this.BillingAddressRequired == other.BillingAddressRequired ||
                    this.BillingAddressRequired != null &&
                    this.BillingAddressRequired.Equals(other.BillingAddressRequired)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.MaximalNumberOfTransactions == other.MaximalNumberOfTransactions ||
                    this.MaximalNumberOfTransactions != null &&
                    this.MaximalNumberOfTransactions.Equals(other.MaximalNumberOfTransactions)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.ShippingAddressRequired == other.ShippingAddressRequired ||
                    this.ShippingAddressRequired != null &&
                    this.ShippingAddressRequired.Equals(other.ShippingAddressRequired)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.AllowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.AppliedSpaceView != null)
                {
                    hash = hash * 59 + this.AppliedSpaceView.GetHashCode();
                }
                if (this.AvailableFrom != null)
                {
                    hash = hash * 59 + this.AvailableFrom.GetHashCode();
                }
                if (this.AvailableUntil != null)
                {
                    hash = hash * 59 + this.AvailableUntil.GetHashCode();
                }
                if (this.BillingAddressRequired != null)
                {
                    hash = hash * 59 + this.BillingAddressRequired.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hash = hash * 59 + this.Currency.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.MaximalNumberOfTransactions != null)
                {
                    hash = hash * 59 + this.MaximalNumberOfTransactions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.ShippingAddressRequired != null)
                {
                    hash = hash * 59 + this.ShippingAddressRequired.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Url != null)
                {
                    hash = hash * 59 + this.Url.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
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
