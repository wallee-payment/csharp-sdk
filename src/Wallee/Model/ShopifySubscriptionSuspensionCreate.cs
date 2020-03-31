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
    /// ShopifySubscriptionSuspensionCreate
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionSuspensionCreate :  IEquatable<ShopifySubscriptionSuspensionCreate>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public ShopifySubscriptionSuspensionType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionSuspensionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShopifySubscriptionSuspensionCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionSuspensionCreate" /> class.
        /// </summary>
        /// <param name="plannedEndDate">plannedEndDate (required).</param>
        /// <param name="subscription">subscription (required).</param>
        /// <param name="type">type (required).</param>
        public ShopifySubscriptionSuspensionCreate(DateTime? plannedEndDate, long? subscription, ShopifySubscriptionSuspensionType type)
        {
            // to ensure "plannedEndDate" is required (not null)
            if (plannedEndDate == null)
            {
                throw new InvalidDataException("plannedEndDate is a required property for ShopifySubscriptionSuspensionCreate and cannot be null");
            }
            this.PlannedEndDate = plannedEndDate;
            // to ensure "subscription" is required (not null)
            if (subscription == null)
            {
                throw new InvalidDataException("subscription is a required property for ShopifySubscriptionSuspensionCreate and cannot be null");
            }
            this.Subscription = subscription;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ShopifySubscriptionSuspensionCreate and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets PlannedEndDate
        /// </summary>
        [DataMember(Name="plannedEndDate", EmitDefaultValue=true)]
        public DateTime? PlannedEndDate { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=true)]
        public long? Subscription { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriptionSuspensionCreate {\n");
            sb.Append("  PlannedEndDate: ").Append(PlannedEndDate).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShopifySubscriptionSuspensionCreate);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionSuspensionCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionSuspensionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionSuspensionCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlannedEndDate == input.PlannedEndDate ||
                    (this.PlannedEndDate != null &&
                    this.PlannedEndDate.Equals(input.PlannedEndDate))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.PlannedEndDate != null)
                    hashCode = hashCode * 59 + this.PlannedEndDate.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}
