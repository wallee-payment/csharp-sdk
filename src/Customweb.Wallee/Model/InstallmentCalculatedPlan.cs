
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
    /// InstallmentCalculatedPlan model.
    /// </summary>
    [DataContract]
    public partial class InstallmentCalculatedPlan :  IEquatable<InstallmentCalculatedPlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentCalculatedPlan" /> class.
        /// </summary>
        /// <param name="Configuration">Configuration</param>
        /// <param name="PaymentMethodConfigurations">PaymentMethodConfigurations</param>
        /// <param name="Slices">Slices</param>
        /// <param name="TotalAmount">TotalAmount</param>
        /// <param name="Transaction">Transaction</param>
        public InstallmentCalculatedPlan(InstallmentPlanConfiguration Configuration = default(InstallmentPlanConfiguration), List<PaymentMethodConfiguration> PaymentMethodConfigurations = default(List<PaymentMethodConfiguration>), List<InstallmentCalculatedSlice> Slices = default(List<InstallmentCalculatedSlice>), decimal? TotalAmount = default(decimal?), Transaction Transaction = default(Transaction))
        {
            this.Configuration = Configuration;
            this.PaymentMethodConfigurations = PaymentMethodConfigurations;
            this.Slices = Slices;
            this.TotalAmount = TotalAmount;
            this.Transaction = Transaction;
        }

        /// <summary>
        /// Configuration
        /// </summary>
        /// <value>Configuration</value>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public InstallmentPlanConfiguration Configuration { get; set; }

        /// <summary>
        /// PaymentMethodConfigurations
        /// </summary>
        /// <value>PaymentMethodConfigurations</value>
        [DataMember(Name="paymentMethodConfigurations", EmitDefaultValue=false)]
        public List<PaymentMethodConfiguration> PaymentMethodConfigurations { get; set; }

        /// <summary>
        /// Slices
        /// </summary>
        /// <value>Slices</value>
        [DataMember(Name="slices", EmitDefaultValue=false)]
        public List<InstallmentCalculatedSlice> Slices { get; set; }

        /// <summary>
        /// TotalAmount
        /// </summary>
        /// <value>TotalAmount</value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Transaction
        /// </summary>
        /// <value>Transaction</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; set; }

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
            return this.Equals(obj as InstallmentCalculatedPlan);
        }

        /// <summary>
        /// Returns true if InstallmentCalculatedPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of InstallmentCalculatedPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentCalculatedPlan other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Configuration == other.Configuration ||
                    this.Configuration != null &&
                    this.Configuration.Equals(other.Configuration)
                ) && 
                (
                    this.PaymentMethodConfigurations == other.PaymentMethodConfigurations ||
                    this.PaymentMethodConfigurations != null &&
                    this.PaymentMethodConfigurations.SequenceEqual(other.PaymentMethodConfigurations)
                ) && 
                (
                    this.Slices == other.Slices ||
                    this.Slices != null &&
                    this.Slices.SequenceEqual(other.Slices)
                ) && 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.Transaction == other.Transaction ||
                    this.Transaction != null &&
                    this.Transaction.Equals(other.Transaction)
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
                // Suitable nullity checks etc, of course :)
                if (this.Configuration != null)
                    hash = hash * 59 + this.Configuration.GetHashCode();
                if (this.PaymentMethodConfigurations != null)
                    hash = hash * 59 + this.PaymentMethodConfigurations.GetHashCode();
                if (this.Slices != null)
                    hash = hash * 59 + this.Slices.GetHashCode();
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.Transaction != null)
                    hash = hash * 59 + this.Transaction.GetHashCode();
                return hash;
            }
        }

    }

}
