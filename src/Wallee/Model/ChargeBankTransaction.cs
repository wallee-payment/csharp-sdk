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
    /// ChargeBankTransaction
    /// </summary>
    [DataContract]
    public partial class ChargeBankTransaction : TransactionAwareEntity,  IEquatable<ChargeBankTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeBankTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ChargeBankTransaction()
        {
        }




        /// <summary>
        /// Gets or Sets BankTransaction
        /// </summary>
        [DataMember(Name="bankTransaction", EmitDefaultValue=true)]
        public BankTransaction BankTransaction { get; private set; }

        /// <summary>
        /// Gets or Sets Completion
        /// </summary>
        [DataMember(Name="completion", EmitDefaultValue=true)]
        public long? Completion { get; private set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceViewId
        /// </summary>
        [DataMember(Name="spaceViewId", EmitDefaultValue=true)]
        public long? SpaceViewId { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=true)]
        public Transaction Transaction { get; private set; }

        /// <summary>
        /// Specify the posting amount in the transaction&#39;s currency.
        /// </summary>
        /// <value>Specify the posting amount in the transaction&#39;s currency.</value>
        [DataMember(Name="transactionCurrencyAmount", EmitDefaultValue=true)]
        public decimal? TransactionCurrencyAmount { get; private set; }

        /// <summary>
        /// Gets or Sets TransactionCurrencyValueAmount
        /// </summary>
        [DataMember(Name="transactionCurrencyValueAmount", EmitDefaultValue=true)]
        public decimal? TransactionCurrencyValueAmount { get; private set; }

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
            sb.Append("class ChargeBankTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  BankTransaction: ").Append(BankTransaction).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  TransactionCurrencyAmount: ").Append(TransactionCurrencyAmount).Append("\n");
            sb.Append("  TransactionCurrencyValueAmount: ").Append(TransactionCurrencyValueAmount).Append("\n");
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
            return this.Equals(input as ChargeBankTransaction);
        }

        /// <summary>
        /// Returns true if ChargeBankTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeBankTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeBankTransaction input)
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
                    this.Completion == input.Completion ||
                    (this.Completion != null &&
                    this.Completion.Equals(input.Completion))
                ) && base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
                ) && base.Equals(input) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && base.Equals(input) && 
                (
                    this.TransactionCurrencyAmount == input.TransactionCurrencyAmount ||
                    (this.TransactionCurrencyAmount != null &&
                    this.TransactionCurrencyAmount.Equals(input.TransactionCurrencyAmount))
                ) && base.Equals(input) && 
                (
                    this.TransactionCurrencyValueAmount == input.TransactionCurrencyValueAmount ||
                    (this.TransactionCurrencyValueAmount != null &&
                    this.TransactionCurrencyValueAmount.Equals(input.TransactionCurrencyValueAmount))
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
                if (this.Completion != null)
                    hashCode = hashCode * 59 + this.Completion.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.TransactionCurrencyAmount != null)
                    hashCode = hashCode * 59 + this.TransactionCurrencyAmount.GetHashCode();
                if (this.TransactionCurrencyValueAmount != null)
                    hashCode = hashCode * 59 + this.TransactionCurrencyValueAmount.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
