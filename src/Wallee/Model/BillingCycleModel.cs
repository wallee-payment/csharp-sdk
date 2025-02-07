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
    /// BillingCycleModel
    /// </summary>
    [DataContract]
    public partial class BillingCycleModel :  IEquatable<BillingCycleModel>
    {
        /// <summary>
        /// Gets or Sets BillingCycleType
        /// </summary>
        [DataMember(Name="billingCycleType", EmitDefaultValue=false)]
        public BillingCycleType? BillingCycleType { get; set; }
        /// <summary>
        /// Gets or Sets Customization
        /// </summary>
        [DataMember(Name="customization", EmitDefaultValue=false)]
        public BillingDayCustomization? Customization { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCycleModel" /> class.
        /// </summary>
        public BillingCycleModel()
        {
        }



        /// <summary>
        /// Gets or Sets DayOfMonth
        /// </summary>
        [DataMember(Name="dayOfMonth", EmitDefaultValue=false)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public string Month { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPeriods
        /// </summary>
        [DataMember(Name="numberOfPeriods", EmitDefaultValue=false)]
        public int? NumberOfPeriods { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyDay
        /// </summary>
        [DataMember(Name="weeklyDay", EmitDefaultValue=false)]
        public string WeeklyDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingCycleModel {\n");
            sb.Append("  BillingCycleType: ").Append(BillingCycleType).Append("\n");
            sb.Append("  Customization: ").Append(Customization).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
            sb.Append("  WeeklyDay: ").Append(WeeklyDay).Append("\n");
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
            return this.Equals(input as BillingCycleModel);
        }

        /// <summary>
        /// Returns true if BillingCycleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingCycleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingCycleModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingCycleType == input.BillingCycleType ||
                    (this.BillingCycleType != null &&
                    this.BillingCycleType.Equals(input.BillingCycleType))
                ) && 
                (
                    this.Customization == input.Customization ||
                    (this.Customization != null &&
                    this.Customization.Equals(input.Customization))
                ) && 
                (
                    this.DayOfMonth == input.DayOfMonth ||
                    (this.DayOfMonth != null &&
                    this.DayOfMonth.Equals(input.DayOfMonth))
                ) && 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.NumberOfPeriods == input.NumberOfPeriods ||
                    (this.NumberOfPeriods != null &&
                    this.NumberOfPeriods.Equals(input.NumberOfPeriods))
                ) && 
                (
                    this.WeeklyDay == input.WeeklyDay ||
                    (this.WeeklyDay != null &&
                    this.WeeklyDay.Equals(input.WeeklyDay))
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
                if (this.BillingCycleType != null)
                    hashCode = hashCode * 59 + this.BillingCycleType.GetHashCode();
                if (this.Customization != null)
                    hashCode = hashCode * 59 + this.Customization.GetHashCode();
                if (this.DayOfMonth != null)
                    hashCode = hashCode * 59 + this.DayOfMonth.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.NumberOfPeriods != null)
                    hashCode = hashCode * 59 + this.NumberOfPeriods.GetHashCode();
                if (this.WeeklyDay != null)
                    hashCode = hashCode * 59 + this.WeeklyDay.GetHashCode();
                return hashCode;
            }
        }

    }

}
