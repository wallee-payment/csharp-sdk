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
    public partial class RefundBankTransaction : TransactionAwareEntity,  IEquatable<RefundBankTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundBankTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RefundBankTransaction()
        {
        }




        /// <summary>
        /// Gets or Sets BankTransaction
        /// </summary>
        [DataMember(Name="bankTransaction", EmitDefaultValue=true)]
        public BankTransaction BankTransaction { get; private set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; private set; }

        /// <summary>
        /// Gets or Sets Refund
        /// </summary>
        [DataMember(Name="refund", EmitDefaultValue=true)]
        public Refund Refund { get; private set; }

        /// <summary>
        /// Specify the posting amount in the refund&#39;s currency.
        /// </summary>
        /// <value>Specify the posting amount in the refund&#39;s currency.</value>
        [DataMember(Name="refundCurrencyAmount", EmitDefaultValue=true)]
        public decimal? RefundCurrencyAmount { get; private set; }

        /// <summary>
        /// Gets or Sets RefundCurrencyValueAmount
        /// </summary>
        [DataMember(Name="refundCurrencyValueAmount", EmitDefaultValue=true)]
        public decimal? RefundCurrencyValueAmount { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceViewId
        /// </summary>
        [DataMember(Name="spaceViewId", EmitDefaultValue=true)]
        public long? SpaceViewId { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundBankTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  BankTransaction: ").Append(BankTransaction).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
        public override string ToJson()
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

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && base.Equals(input) && 
                (
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && base.Equals(input) && 
                (
                    this.BankTransaction == input.BankTransaction ||
                    (this.BankTransaction != null &&
                    this.BankTransaction.Equals(input.BankTransaction))
                ) && base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.Refund == input.Refund ||
                    (this.Refund != null &&
                    this.Refund.Equals(input.Refund))
                ) && base.Equals(input) && 
                (
                    this.RefundCurrencyAmount == input.RefundCurrencyAmount ||
                    (this.RefundCurrencyAmount != null &&
                    this.RefundCurrencyAmount.Equals(input.RefundCurrencyAmount))
                ) && base.Equals(input) && 
                (
                    this.RefundCurrencyValueAmount == input.RefundCurrencyValueAmount ||
                    (this.RefundCurrencyValueAmount != null &&
                    this.RefundCurrencyValueAmount.Equals(input.RefundCurrencyValueAmount))
                ) && base.Equals(input) && 
                (
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.BankTransaction != null)
                    hashCode = hashCode * 59 + this.BankTransaction.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
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
