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
    /// The subscription create request holds all the data required to create a new subscription.
    /// </summary>
    [DataContract]
    public partial class SubscriptionCreateRequest :  IEquatable<SubscriptionCreateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreateRequest" /> class.
        /// </summary>
        /// <param name="currency">currency (required).</param>
        /// <param name="product">The subscription has to be linked with a product. (required).</param>
        /// <param name="subscription">subscription (required).</param>
        public SubscriptionCreateRequest(string currency, long? product, SubscriptionPending subscription)
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for SubscriptionCreateRequest and cannot be null");
            }
            this.Currency = currency;
            // to ensure "product" is required (not null)
            if (product == null)
            {
                throw new InvalidDataException("product is a required property for SubscriptionCreateRequest and cannot be null");
            }
            this.Product = product;
            // to ensure "subscription" is required (not null)
            if (subscription == null)
            {
                throw new InvalidDataException("subscription is a required property for SubscriptionCreateRequest and cannot be null");
            }
            this.Subscription = subscription;
        }

        /// <summary>
        /// Gets or Sets ComponentConfigurations
        /// </summary>
        [DataMember(Name="componentConfigurations", EmitDefaultValue=false)]
        public List<SubscriptionComponentReferenceConfiguration> ComponentConfigurations { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The subscription has to be linked with a product.
        /// </summary>
        /// <value>The subscription has to be linked with a product.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public long? Product { get; set; }

        /// <summary>
        /// Gets or Sets SelectedComponents
        /// </summary>
        [DataMember(Name="selectedComponents", EmitDefaultValue=false)]
        public List<SubscriptionProductComponentReference> SelectedComponents { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public SubscriptionPending Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionCreateRequest {\n");
            sb.Append("  ComponentConfigurations: ").Append(ComponentConfigurations).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  SelectedComponents: ").Append(SelectedComponents).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
            return this.Equals(input as SubscriptionCreateRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComponentConfigurations == input.ComponentConfigurations ||
                    this.ComponentConfigurations != null &&
                    input.ComponentConfigurations != null &&
                    this.ComponentConfigurations.SequenceEqual(input.ComponentConfigurations)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.SelectedComponents == input.SelectedComponents ||
                    this.SelectedComponents != null &&
                    input.SelectedComponents != null &&
                    this.SelectedComponents.SequenceEqual(input.SelectedComponents)
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
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
                if (this.ComponentConfigurations != null)
                    hashCode = hashCode * 59 + this.ComponentConfigurations.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.SelectedComponents != null)
                    hashCode = hashCode * 59 + this.SelectedComponents.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                return hashCode;
            }
        }

    }

}
