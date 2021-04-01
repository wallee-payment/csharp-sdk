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
    /// InstallmentCalculatedPlan
    /// </summary>
    [DataContract]
    public partial class InstallmentCalculatedPlan :  IEquatable<InstallmentCalculatedPlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentCalculatedPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InstallmentCalculatedPlan()
        {
        }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=true)]
        public InstallmentPlanConfiguration Configuration { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentMethodConfigurations
        /// </summary>
        [DataMember(Name="paymentMethodConfigurations", EmitDefaultValue=true)]
        public List<PaymentMethodConfiguration> PaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// Gets or Sets Slices
        /// </summary>
        [DataMember(Name="slices", EmitDefaultValue=true)]
        public List<InstallmentCalculatedSlice> Slices { get; private set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name="totalAmount", EmitDefaultValue=true)]
        public decimal? TotalAmount { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=true)]
        public Transaction Transaction { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallmentCalculatedPlan {\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  PaymentMethodConfigurations: ").Append(PaymentMethodConfigurations).Append("\n");
            sb.Append("  Slices: ").Append(Slices).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
            return this.Equals(input as InstallmentCalculatedPlan);
        }

        /// <summary>
        /// Returns true if InstallmentCalculatedPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of InstallmentCalculatedPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentCalculatedPlan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
                ) && 
                (
                    this.PaymentMethodConfigurations == input.PaymentMethodConfigurations ||
                    this.PaymentMethodConfigurations != null &&
                    input.PaymentMethodConfigurations != null &&
                    this.PaymentMethodConfigurations.SequenceEqual(input.PaymentMethodConfigurations)
                ) && 
                (
                    this.Slices == input.Slices ||
                    this.Slices != null &&
                    input.Slices != null &&
                    this.Slices.SequenceEqual(input.Slices)
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
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
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.PaymentMethodConfigurations != null)
                    hashCode = hashCode * 59 + this.PaymentMethodConfigurations.GetHashCode();
                if (this.Slices != null)
                    hashCode = hashCode * 59 + this.Slices.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                return hashCode;
            }
        }

    }

}
