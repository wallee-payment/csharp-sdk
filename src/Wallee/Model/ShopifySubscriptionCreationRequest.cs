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
    /// ShopifySubscriptionCreationRequest
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionCreationRequest :  IEquatable<ShopifySubscriptionCreationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShopifySubscriptionCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionCreationRequest" /> class.
        /// </summary>
        /// <param name="billingAddress">billingAddress (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="externalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required).</param>
        /// <param name="integration">integration (required).</param>
        /// <param name="items">items (required).</param>
        /// <param name="language">language (required).</param>
        /// <param name="shippingAddress">shippingAddress (required).</param>
        /// <param name="subscriber">subscriber (required).</param>
        public ShopifySubscriptionCreationRequest(ShopifySubscriptionAddressCreate billingAddress, string currency, string externalId, long? integration, List<ShopifySubscriptionModelItem> items, string language, ShopifySubscriptionAddressCreate shippingAddress, ShopifySubscriberCreation subscriber)
        {
            // to ensure "billingAddress" is required (not null)
            if (billingAddress == null)
            {
                throw new InvalidDataException("billingAddress is a required property for ShopifySubscriptionCreationRequest and cannot be null");
            }
            this.BillingAddress = billingAddress;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for ShopifySubscriptionCreationRequest and cannot be null");
            }
            this.Currency = currency;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for ShopifySubscriptionCreationRequest and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "integration" is required (not null)
            if (integration == null)
            {
                throw new InvalidDataException("integration is a required property for ShopifySubscriptionCreationRequest and cannot be null");
            }
            this.Integration = integration;
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for ShopifySubscriptionCreationRequest and cannot be null");
            }
            this.Items = items;
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new InvalidDataException("language is a required property for ShopifySubscriptionCreationRequest and cannot be null");
            }
            this.Language = language;
            // to ensure "shippingAddress" is required (not null)
            if (shippingAddress == null)
            {
                throw new InvalidDataException("shippingAddress is a required property for ShopifySubscriptionCreationRequest and cannot be null");
            }
            this.ShippingAddress = shippingAddress;
            // to ensure "subscriber" is required (not null)
            if (subscriber == null)
            {
                throw new InvalidDataException("subscriber is a required property for ShopifySubscriptionCreationRequest and cannot be null");
            }
            this.Subscriber = subscriber;
        }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress", EmitDefaultValue=true)]
        public ShopifySubscriptionAddressCreate BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets BillingConfiguration
        /// </summary>
        [DataMember(Name="billingConfiguration", EmitDefaultValue=true)]
        public ShopifySubscriptionModelBillingConfiguration BillingConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Integration
        /// </summary>
        [DataMember(Name="integration", EmitDefaultValue=true)]
        public long? Integration { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public List<ShopifySubscriptionModelItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shippingAddress", EmitDefaultValue=true)]
        public ShopifySubscriptionAddressCreate ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShippingMethodName
        /// </summary>
        [DataMember(Name="shippingMethodName", EmitDefaultValue=true)]
        public string ShippingMethodName { get; set; }

        /// <summary>
        /// Gets or Sets SpaceViewId
        /// </summary>
        [DataMember(Name="spaceViewId", EmitDefaultValue=true)]
        public long? SpaceViewId { get; set; }

        /// <summary>
        /// Gets or Sets StoreOrderConfirmationEmailEnabled
        /// </summary>
        [DataMember(Name="storeOrderConfirmationEmailEnabled", EmitDefaultValue=true)]
        public bool? StoreOrderConfirmationEmailEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Subscriber
        /// </summary>
        [DataMember(Name="subscriber", EmitDefaultValue=true)]
        public ShopifySubscriberCreation Subscriber { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberSuspensionAllowed
        /// </summary>
        [DataMember(Name="subscriberSuspensionAllowed", EmitDefaultValue=true)]
        public bool? SubscriberSuspensionAllowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriptionCreationRequest {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BillingConfiguration: ").Append(BillingConfiguration).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ShippingMethodName: ").Append(ShippingMethodName).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  StoreOrderConfirmationEmailEnabled: ").Append(StoreOrderConfirmationEmailEnabled).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  SubscriberSuspensionAllowed: ").Append(SubscriberSuspensionAllowed).Append("\n");
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
            return this.Equals(input as ShopifySubscriptionCreationRequest);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionCreationRequest input)
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
                    this.BillingConfiguration == input.BillingConfiguration ||
                    (this.BillingConfiguration != null &&
                    this.BillingConfiguration.Equals(input.BillingConfiguration))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Integration == input.Integration ||
                    (this.Integration != null &&
                    this.Integration.Equals(input.Integration))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.ShippingMethodName == input.ShippingMethodName ||
                    (this.ShippingMethodName != null &&
                    this.ShippingMethodName.Equals(input.ShippingMethodName))
                ) && 
                (
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
                ) && 
                (
                    this.StoreOrderConfirmationEmailEnabled == input.StoreOrderConfirmationEmailEnabled ||
                    (this.StoreOrderConfirmationEmailEnabled != null &&
                    this.StoreOrderConfirmationEmailEnabled.Equals(input.StoreOrderConfirmationEmailEnabled))
                ) && 
                (
                    this.Subscriber == input.Subscriber ||
                    (this.Subscriber != null &&
                    this.Subscriber.Equals(input.Subscriber))
                ) && 
                (
                    this.SubscriberSuspensionAllowed == input.SubscriberSuspensionAllowed ||
                    (this.SubscriberSuspensionAllowed != null &&
                    this.SubscriberSuspensionAllowed.Equals(input.SubscriberSuspensionAllowed))
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
                if (this.BillingConfiguration != null)
                    hashCode = hashCode * 59 + this.BillingConfiguration.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Integration != null)
                    hashCode = hashCode * 59 + this.Integration.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.ShippingMethodName != null)
                    hashCode = hashCode * 59 + this.ShippingMethodName.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                if (this.StoreOrderConfirmationEmailEnabled != null)
                    hashCode = hashCode * 59 + this.StoreOrderConfirmationEmailEnabled.GetHashCode();
                if (this.Subscriber != null)
                    hashCode = hashCode * 59 + this.Subscriber.GetHashCode();
                if (this.SubscriberSuspensionAllowed != null)
                    hashCode = hashCode * 59 + this.SubscriberSuspensionAllowed.GetHashCode();
                return hashCode;
            }
        }

    }

}
