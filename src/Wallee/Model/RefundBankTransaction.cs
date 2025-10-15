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
    /// RefundBankTransaction
    /// </summary>
    [DataContract]
    public partial class RefundBankTransaction :  IEquatable<RefundBankTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundBankTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RefundBankTransaction()
        {
        }

        /// <summary>
        /// Provides general information about the bank transaction.
        /// </summary>
        /// <value>Provides general information about the bank transaction.</value>
        [DataMember(Name="bankTransaction", EmitDefaultValue=false)]
        public BankTransaction BankTransaction { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The payment transaction this object is linked to.
        /// </summary>
        /// <value>The payment transaction this object is linked to.</value>
        [DataMember(Name="linkedTransaction", EmitDefaultValue=false)]
        public long? LinkedTransaction { get; private set; }

        /// <summary>
        /// The refund this bank transaction belongs to.
        /// </summary>
        /// <value>The refund this bank transaction belongs to.</value>
        [DataMember(Name="refund", EmitDefaultValue=false)]
        public Refund Refund { get; private set; }

        /// <summary>
        /// The posting amount represents the monetary value of the bank transaction, recorded in the refund&#39;s currency, before applying any adjustments.
        /// </summary>
        /// <value>The posting amount represents the monetary value of the bank transaction, recorded in the refund&#39;s currency, before applying any adjustments.</value>
        [DataMember(Name="refundCurrencyAmount", EmitDefaultValue=false)]
        public decimal? RefundCurrencyAmount { get; private set; }

        /// <summary>
        /// The value amount represents the net monetary value of the bank transaction, recorded in the refund&#39;s currency, after applicable deductions.
        /// </summary>
        /// <value>The value amount represents the net monetary value of the bank transaction, recorded in the refund&#39;s currency, after applicable deductions.</value>
        [DataMember(Name="refundCurrencyValueAmount", EmitDefaultValue=false)]
        public decimal? RefundCurrencyValueAmount { get; private set; }

        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }

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
            sb.Append("class RefundBankTransaction {\n");
            sb.Append("  BankTransaction: ").Append(BankTransaction).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  Refund: ").Append(Refund).Append("\n");
            sb.Append("  RefundCurrencyAmount: ").Append(RefundCurrencyAmount).Append("\n");
            sb.Append("  RefundCurrencyValueAmount: ").Append(RefundCurrencyValueAmount).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
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
            return this.Equals(input as RefundBankTransaction);
        }

        /// <summary>
        /// Returns true if RefundBankTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundBankTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundBankTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BankTransaction == input.BankTransaction ||
                    (this.BankTransaction != null &&
                    this.BankTransaction.Equals(input.BankTransaction))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && 
                (
                    this.Refund == input.Refund ||
                    (this.Refund != null &&
                    this.Refund.Equals(input.Refund))
                ) && 
                (
                    this.RefundCurrencyAmount == input.RefundCurrencyAmount ||
                    (this.RefundCurrencyAmount != null &&
                    this.RefundCurrencyAmount.Equals(input.RefundCurrencyAmount))
                ) && 
                (
                    this.RefundCurrencyValueAmount == input.RefundCurrencyValueAmount ||
                    (this.RefundCurrencyValueAmount != null &&
                    this.RefundCurrencyValueAmount.Equals(input.RefundCurrencyValueAmount))
                ) && 
                (
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
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
                if (this.BankTransaction != null)
                    hashCode = hashCode * 59 + this.BankTransaction.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.Refund != null)
                    hashCode = hashCode * 59 + this.Refund.GetHashCode();
                if (this.RefundCurrencyAmount != null)
                    hashCode = hashCode * 59 + this.RefundCurrencyAmount.GetHashCode();
                if (this.RefundCurrencyValueAmount != null)
                    hashCode = hashCode * 59 + this.RefundCurrencyValueAmount.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
