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
        /// Define how frequently recurring orders should be created.
        /// </summary>
        /// <value>Define how frequently recurring orders should be created.</value>
        [DataMember(Name="billingIntervalUnit", EmitDefaultValue=true)]
        public ShopifySubscriptionBillingIntervalUnit? BillingIntervalUnit { get; set; }
        /// <summary>
        /// Define the weekday on which the recurring orders should be created.
        /// </summary>
        /// <value>Define the weekday on which the recurring orders should be created.</value>
        [DataMember(Name="billingWeekday", EmitDefaultValue=true)]
        public ShopifySubscriptionWeekday? BillingWeekday { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionUpdateRequest" /> class.
        /// </summary>
        public ShopifySubscriptionUpdateRequest()
        {
        }

        /// <summary>
        /// Define the day of the month on which the recurring orders should be created.
        /// </summary>
        /// <value>Define the day of the month on which the recurring orders should be created.</value>
        [DataMember(Name="billingDayOfMonth", EmitDefaultValue=true)]
        public int? BillingDayOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets BillingIntervalAmount
        /// </summary>
        [DataMember(Name="billingIntervalAmount", EmitDefaultValue=true)]
        public int? BillingIntervalAmount { get; set; }



        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public List<ShopifySubscriptionEditModelItem> Items { get; set; }

        /// <summary>
        /// Define the maximum number of orders the subscription will run for.
        /// </summary>
        /// <value>Define the maximum number of orders the subscription will run for.</value>
        [DataMember(Name="maximalBillingCycles", EmitDefaultValue=true)]
        public int? MaximalBillingCycles { get; set; }

        /// <summary>
        /// Define the maximum number of orders the subscription can be suspended for at a time.
        /// </summary>
        /// <value>Define the maximum number of orders the subscription can be suspended for at a time.</value>
        [DataMember(Name="maximalSuspendableCycles", EmitDefaultValue=true)]
        public int? MaximalSuspendableCycles { get; set; }

        /// <summary>
        /// Define the minimal number of orders the subscription will run for.
        /// </summary>
        /// <value>Define the minimal number of orders the subscription will run for.</value>
        [DataMember(Name="minimalBillingCycles", EmitDefaultValue=true)]
        public int? MinimalBillingCycles { get; set; }

        /// <summary>
        /// Gets or Sets StoreOrderConfirmationEmailEnabled
        /// </summary>
        [DataMember(Name="storeOrderConfirmationEmailEnabled", EmitDefaultValue=true)]
        public bool? StoreOrderConfirmationEmailEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberSuspensionAllowed
        /// </summary>
        [DataMember(Name="subscriberSuspensionAllowed", EmitDefaultValue=true)]
        public bool? SubscriberSuspensionAllowed { get; set; }

        /// <summary>
        /// Define the number of orders the subscription will keep running for after its termination has been requested.
        /// </summary>
        /// <value>Define the number of orders the subscription will keep running for after its termination has been requested.</value>
        [DataMember(Name="terminationBillingCycles", EmitDefaultValue=true)]
        public int? TerminationBillingCycles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriptionUpdateRequest {\n");
            sb.Append("  BillingDayOfMonth: ").Append(BillingDayOfMonth).Append("\n");
            sb.Append("  BillingIntervalAmount: ").Append(BillingIntervalAmount).Append("\n");
            sb.Append("  BillingIntervalUnit: ").Append(BillingIntervalUnit).Append("\n");
            sb.Append("  BillingWeekday: ").Append(BillingWeekday).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  MaximalBillingCycles: ").Append(MaximalBillingCycles).Append("\n");
            sb.Append("  MaximalSuspendableCycles: ").Append(MaximalSuspendableCycles).Append("\n");
            sb.Append("  MinimalBillingCycles: ").Append(MinimalBillingCycles).Append("\n");
            sb.Append("  StoreOrderConfirmationEmailEnabled: ").Append(StoreOrderConfirmationEmailEnabled).Append("\n");
            sb.Append("  SubscriberSuspensionAllowed: ").Append(SubscriberSuspensionAllowed).Append("\n");
            sb.Append("  TerminationBillingCycles: ").Append(TerminationBillingCycles).Append("\n");
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
                    this.BillingDayOfMonth == input.BillingDayOfMonth ||
                    (this.BillingDayOfMonth != null &&
                    this.BillingDayOfMonth.Equals(input.BillingDayOfMonth))
                ) && 
                (
                    this.BillingIntervalAmount == input.BillingIntervalAmount ||
                    (this.BillingIntervalAmount != null &&
                    this.BillingIntervalAmount.Equals(input.BillingIntervalAmount))
                ) && 
                (
                    this.BillingIntervalUnit == input.BillingIntervalUnit ||
                    (this.BillingIntervalUnit != null &&
                    this.BillingIntervalUnit.Equals(input.BillingIntervalUnit))
                ) && 
                (
                    this.BillingWeekday == input.BillingWeekday ||
                    (this.BillingWeekday != null &&
                    this.BillingWeekday.Equals(input.BillingWeekday))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.MaximalBillingCycles == input.MaximalBillingCycles ||
                    (this.MaximalBillingCycles != null &&
                    this.MaximalBillingCycles.Equals(input.MaximalBillingCycles))
                ) && 
                (
                    this.MaximalSuspendableCycles == input.MaximalSuspendableCycles ||
                    (this.MaximalSuspendableCycles != null &&
                    this.MaximalSuspendableCycles.Equals(input.MaximalSuspendableCycles))
                ) && 
                (
                    this.MinimalBillingCycles == input.MinimalBillingCycles ||
                    (this.MinimalBillingCycles != null &&
                    this.MinimalBillingCycles.Equals(input.MinimalBillingCycles))
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
                ) && 
                (
                    this.TerminationBillingCycles == input.TerminationBillingCycles ||
                    (this.TerminationBillingCycles != null &&
                    this.TerminationBillingCycles.Equals(input.TerminationBillingCycles))
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
                if (this.BillingDayOfMonth != null)
                    hashCode = hashCode * 59 + this.BillingDayOfMonth.GetHashCode();
                if (this.BillingIntervalAmount != null)
                    hashCode = hashCode * 59 + this.BillingIntervalAmount.GetHashCode();
                if (this.BillingIntervalUnit != null)
                    hashCode = hashCode * 59 + this.BillingIntervalUnit.GetHashCode();
                if (this.BillingWeekday != null)
                    hashCode = hashCode * 59 + this.BillingWeekday.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.MaximalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MaximalBillingCycles.GetHashCode();
                if (this.MaximalSuspendableCycles != null)
                    hashCode = hashCode * 59 + this.MaximalSuspendableCycles.GetHashCode();
                if (this.MinimalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MinimalBillingCycles.GetHashCode();
                if (this.StoreOrderConfirmationEmailEnabled != null)
                    hashCode = hashCode * 59 + this.StoreOrderConfirmationEmailEnabled.GetHashCode();
                if (this.SubscriberSuspensionAllowed != null)
                    hashCode = hashCode * 59 + this.SubscriberSuspensionAllowed.GetHashCode();
                if (this.TerminationBillingCycles != null)
                    hashCode = hashCode * 59 + this.TerminationBillingCycles.GetHashCode();
                return hashCode;
            }
        }

    }

}
