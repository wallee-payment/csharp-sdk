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
    /// PaymentTerminalDccTransactionSum
    /// </summary>
    [DataContract]
    public partial class PaymentTerminalDccTransactionSum :  IEquatable<PaymentTerminalDccTransactionSum>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalDccTransactionSum" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalDccTransactionSum()
        {
        }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; private set; }

        /// <summary>
        /// Gets or Sets DccAmount
        /// </summary>
        [DataMember(Name="dccAmount", EmitDefaultValue=false)]
        public decimal? DccAmount { get; private set; }

        /// <summary>
        /// Gets or Sets DccCurrency
        /// </summary>
        [DataMember(Name="dccCurrency", EmitDefaultValue=false)]
        public string DccCurrency { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public decimal? TransactionAmount { get; private set; }

        /// <summary>
        /// Gets or Sets TransactionCount
        /// </summary>
        [DataMember(Name="transactionCount", EmitDefaultValue=false)]
        public int? TransactionCount { get; private set; }

        /// <summary>
        /// Gets or Sets TransactionCurrency
        /// </summary>
        [DataMember(Name="transactionCurrency", EmitDefaultValue=false)]
        public string TransactionCurrency { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerminalDccTransactionSum {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  DccAmount: ").Append(DccAmount).Append("\n");
            sb.Append("  DccCurrency: ").Append(DccCurrency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionCount: ").Append(TransactionCount).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as PaymentTerminalDccTransactionSum);
        }

        /// <summary>
        /// Returns true if PaymentTerminalDccTransactionSum instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminalDccTransactionSum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminalDccTransactionSum input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.DccAmount == input.DccAmount ||
                    (this.DccAmount != null &&
                    this.DccAmount.Equals(input.DccAmount))
                ) && 
                (
                    this.DccCurrency == input.DccCurrency ||
                    (this.DccCurrency != null &&
                    this.DccCurrency.Equals(input.DccCurrency))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransactionCount == input.TransactionCount ||
                    (this.TransactionCount != null &&
                    this.TransactionCount.Equals(input.TransactionCount))
                ) && 
                (
                    this.TransactionCurrency == input.TransactionCurrency ||
                    (this.TransactionCurrency != null &&
                    this.TransactionCurrency.Equals(input.TransactionCurrency))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.DccAmount != null)
                    hashCode = hashCode * 59 + this.DccAmount.GetHashCode();
                if (this.DccCurrency != null)
                    hashCode = hashCode * 59 + this.DccCurrency.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionCount != null)
                    hashCode = hashCode * 59 + this.TransactionCount.GetHashCode();
                if (this.TransactionCurrency != null)
                    hashCode = hashCode * 59 + this.TransactionCurrency.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
