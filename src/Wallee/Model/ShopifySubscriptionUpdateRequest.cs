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
    /// ShopifySubscriptionUpdateRequest
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionUpdateRequest :  IEquatable<ShopifySubscriptionUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionUpdateRequest" /> class.
        /// </summary>
        public ShopifySubscriptionUpdateRequest()
        {
        }

        /// <summary>
        /// Gets or Sets BillingConfiguration
        /// </summary>
        [DataMember(Name="billingConfiguration", EmitDefaultValue=false)]
        public ShopifySubscriptionModelBillingConfiguration BillingConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ShopifySubscriptionModelItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets StoreOrderConfirmationEmailEnabled
        /// </summary>
        [DataMember(Name="storeOrderConfirmationEmailEnabled", EmitDefaultValue=false)]
        public bool? StoreOrderConfirmationEmailEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberSuspensionAllowed
        /// </summary>
        [DataMember(Name="subscriberSuspensionAllowed", EmitDefaultValue=false)]
        public bool? SubscriberSuspensionAllowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriptionUpdateRequest {\n");
            sb.Append("  BillingConfiguration: ").Append(BillingConfiguration).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  StoreOrderConfirmationEmailEnabled: ").Append(StoreOrderConfirmationEmailEnabled).Append("\n");
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
            return this.Equals(input as ShopifySubscriptionUpdateRequest);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingConfiguration == input.BillingConfiguration ||
                    (this.BillingConfiguration != null &&
                    this.BillingConfiguration.Equals(input.BillingConfiguration))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.StoreOrderConfirmationEmailEnabled == input.StoreOrderConfirmationEmailEnabled ||
                    (this.StoreOrderConfirmationEmailEnabled != null &&
                    this.StoreOrderConfirmationEmailEnabled.Equals(input.StoreOrderConfirmationEmailEnabled))
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
                if (this.BillingConfiguration != null)
                    hashCode = hashCode * 59 + this.BillingConfiguration.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.StoreOrderConfirmationEmailEnabled != null)
                    hashCode = hashCode * 59 + this.StoreOrderConfirmationEmailEnabled.GetHashCode();
                if (this.SubscriberSuspensionAllowed != null)
                    hashCode = hashCode * 59 + this.SubscriberSuspensionAllowed.GetHashCode();
                return hashCode;
            }
        }

    }

}
