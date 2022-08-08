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
    /// PaymentTerminalTransactionSum
    /// </summary>
    [DataContract]
    public partial class PaymentTerminalTransactionSum :  IEquatable<PaymentTerminalTransactionSum>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalTransactionSum" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalTransactionSum()
        {
        }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; private set; }

        /// <summary>
        /// Gets or Sets DccTipAmount
        /// </summary>
        [DataMember(Name="dccTipAmount", EmitDefaultValue=false)]
        public decimal? DccTipAmount { get; private set; }

        /// <summary>
        /// Gets or Sets DccTransactionAmount
        /// </summary>
        [DataMember(Name="dccTransactionAmount", EmitDefaultValue=false)]
        public decimal? DccTransactionAmount { get; private set; }

        /// <summary>
        /// Gets or Sets DccTransactionCount
        /// </summary>
        [DataMember(Name="dccTransactionCount", EmitDefaultValue=false)]
        public int? DccTransactionCount { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public string Product { get; private set; }

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
        /// Gets or Sets TransactionTipAmount
        /// </summary>
        [DataMember(Name="transactionTipAmount", EmitDefaultValue=false)]
        public decimal? TransactionTipAmount { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerminalTransactionSum {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  DccTipAmount: ").Append(DccTipAmount).Append("\n");
            sb.Append("  DccTransactionAmount: ").Append(DccTransactionAmount).Append("\n");
            sb.Append("  DccTransactionCount: ").Append(DccTransactionCount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionCount: ").Append(TransactionCount).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  TransactionTipAmount: ").Append(TransactionTipAmount).Append("\n");
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
            return this.Equals(input as PaymentTerminalTransactionSum);
        }

        /// <summary>
        /// Returns true if PaymentTerminalTransactionSum instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminalTransactionSum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminalTransactionSum input)
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
                    this.DccTipAmount == input.DccTipAmount ||
                    (this.DccTipAmount != null &&
                    this.DccTipAmount.Equals(input.DccTipAmount))
                ) && 
                (
                    this.DccTransactionAmount == input.DccTransactionAmount ||
                    (this.DccTransactionAmount != null &&
                    this.DccTransactionAmount.Equals(input.DccTransactionAmount))
                ) && 
                (
                    this.DccTransactionCount == input.DccTransactionCount ||
                    (this.DccTransactionCount != null &&
                    this.DccTransactionCount.Equals(input.DccTransactionCount))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
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
                    this.TransactionTipAmount == input.TransactionTipAmount ||
                    (this.TransactionTipAmount != null &&
                    this.TransactionTipAmount.Equals(input.TransactionTipAmount))
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
                if (this.DccTipAmount != null)
                    hashCode = hashCode * 59 + this.DccTipAmount.GetHashCode();
                if (this.DccTransactionAmount != null)
                    hashCode = hashCode * 59 + this.DccTransactionAmount.GetHashCode();
                if (this.DccTransactionCount != null)
                    hashCode = hashCode * 59 + this.DccTransactionCount.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionCount != null)
                    hashCode = hashCode * 59 + this.TransactionCount.GetHashCode();
                if (this.TransactionCurrency != null)
                    hashCode = hashCode * 59 + this.TransactionCurrency.GetHashCode();
                if (this.TransactionTipAmount != null)
                    hashCode = hashCode * 59 + this.TransactionTipAmount.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
