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
    /// ShopifySubscriptionModelBillingConfiguration
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionModelBillingConfiguration :  IEquatable<ShopifySubscriptionModelBillingConfiguration>
    {
        /// <summary>
        /// Define how frequently recurring orders should be created.
        /// </summary>
        /// <value>Define how frequently recurring orders should be created.</value>
        [DataMember(Name="billingIntervalUnit", EmitDefaultValue=false)]
        public ShopifySubscriptionBillingIntervalUnit? BillingIntervalUnit { get; set; }
        /// <summary>
        /// Define the weekday on which the recurring orders should be created.
        /// </summary>
        /// <value>Define the weekday on which the recurring orders should be created.</value>
        [DataMember(Name="billingWeekday", EmitDefaultValue=false)]
        public ShopifySubscriptionWeekday? BillingWeekday { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionModelBillingConfiguration" /> class.
        /// </summary>
        public ShopifySubscriptionModelBillingConfiguration()
        {
        }

        /// <summary>
        /// Define the day of the month on which the recurring orders should be created.
        /// </summary>
        /// <value>Define the day of the month on which the recurring orders should be created.</value>
        [DataMember(Name="billingDayOfMonth", EmitDefaultValue=false)]
        public int? BillingDayOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets BillingIntervalAmount
        /// </summary>
        [DataMember(Name="billingIntervalAmount", EmitDefaultValue=false)]
        public int? BillingIntervalAmount { get; set; }


        /// <summary>
        /// This date will be used as basis to calculate the dates of recurring orders.
        /// </summary>
        /// <value>This date will be used as basis to calculate the dates of recurring orders.</value>
        [DataMember(Name="billingReferenceDate", EmitDefaultValue=false)]
        public DateTime? BillingReferenceDate { get; set; }


        /// <summary>
        /// Define the maximum number of orders the subscription will run for.
        /// </summary>
        /// <value>Define the maximum number of orders the subscription will run for.</value>
        [DataMember(Name="maximalBillingCycles", EmitDefaultValue=false)]
        public int? MaximalBillingCycles { get; set; }

        /// <summary>
        /// Define the maximum number of orders the subscription can be suspended for at a time.
        /// </summary>
        /// <value>Define the maximum number of orders the subscription can be suspended for at a time.</value>
        [DataMember(Name="maximalSuspendableCycles", EmitDefaultValue=false)]
        public int? MaximalSuspendableCycles { get; set; }

        /// <summary>
        /// Define the minimal number of orders the subscription will run for.
        /// </summary>
        /// <value>Define the minimal number of orders the subscription will run for.</value>
        [DataMember(Name="minimalBillingCycles", EmitDefaultValue=false)]
        public int? MinimalBillingCycles { get; set; }

        /// <summary>
        /// Define the number of orders the subscription will keep running for after its termination has been requested.
        /// </summary>
        /// <value>Define the number of orders the subscription will keep running for after its termination has been requested.</value>
        [DataMember(Name="terminationBillingCycles", EmitDefaultValue=false)]
        public int? TerminationBillingCycles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriptionModelBillingConfiguration {\n");
            sb.Append("  BillingDayOfMonth: ").Append(BillingDayOfMonth).Append("\n");
            sb.Append("  BillingIntervalAmount: ").Append(BillingIntervalAmount).Append("\n");
            sb.Append("  BillingIntervalUnit: ").Append(BillingIntervalUnit).Append("\n");
            sb.Append("  BillingReferenceDate: ").Append(BillingReferenceDate).Append("\n");
            sb.Append("  BillingWeekday: ").Append(BillingWeekday).Append("\n");
            sb.Append("  MaximalBillingCycles: ").Append(MaximalBillingCycles).Append("\n");
            sb.Append("  MaximalSuspendableCycles: ").Append(MaximalSuspendableCycles).Append("\n");
            sb.Append("  MinimalBillingCycles: ").Append(MinimalBillingCycles).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShopifySubscriptionModelBillingConfiguration);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionModelBillingConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionModelBillingConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionModelBillingConfiguration input)
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
                    this.BillingReferenceDate == input.BillingReferenceDate ||
                    (this.BillingReferenceDate != null &&
                    this.BillingReferenceDate.Equals(input.BillingReferenceDate))
                ) && 
                (
                    this.BillingWeekday == input.BillingWeekday ||
                    (this.BillingWeekday != null &&
                    this.BillingWeekday.Equals(input.BillingWeekday))
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
                if (this.BillingReferenceDate != null)
                    hashCode = hashCode * 59 + this.BillingReferenceDate.GetHashCode();
                if (this.BillingWeekday != null)
                    hashCode = hashCode * 59 + this.BillingWeekday.GetHashCode();
                if (this.MaximalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MaximalBillingCycles.GetHashCode();
                if (this.MaximalSuspendableCycles != null)
                    hashCode = hashCode * 59 + this.MaximalSuspendableCycles.GetHashCode();
                if (this.MinimalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MinimalBillingCycles.GetHashCode();
                if (this.TerminationBillingCycles != null)
                    hashCode = hashCode * 59 + this.TerminationBillingCycles.GetHashCode();
                return hashCode;
            }
        }

    }

}
