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
    /// BankTransaction
    /// </summary>
    [DataContract]
    public partial class BankTransaction :  IEquatable<BankTransaction>
    {
        /// <summary>
        /// Gets or Sets FlowDirection
        /// </summary>
        [DataMember(Name="flowDirection", EmitDefaultValue=false)]
        public BankTransactionFlowDirection? FlowDirection { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public BankTransactionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BankTransaction()
        {
        }

        /// <summary>
        /// The adjustments applied on this bank transaction.
        /// </summary>
        /// <value>The adjustments applied on this bank transaction.</value>
        [DataMember(Name="adjustments", EmitDefaultValue=false)]
        public List<PaymentAdjustment> Adjustments { get; private set; }

        /// <summary>
        /// The created by indicates the user which has created the bank transaction.
        /// </summary>
        /// <value>The created by indicates the user which has created the bank transaction.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The currency bank account which is used to handle money flow.
        /// </summary>
        /// <value>The currency bank account which is used to handle money flow.</value>
        [DataMember(Name="currencyBankAccount", EmitDefaultValue=false)]
        public CurrencyBankAccount CurrencyBankAccount { get; private set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }


        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The posting amount indicates the amount including adjustments.
        /// </summary>
        /// <value>The posting amount indicates the amount including adjustments.</value>
        [DataMember(Name="postingAmount", EmitDefaultValue=false)]
        public decimal? PostingAmount { get; private set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; private set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public long? Source { get; private set; }


        /// <summary>
        /// Gets or Sets TotalAdjustmentAmountIncludingTax
        /// </summary>
        [DataMember(Name="totalAdjustmentAmountIncludingTax", EmitDefaultValue=false)]
        public decimal? TotalAdjustmentAmountIncludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public long? Type { get; private set; }

        /// <summary>
        /// Gets or Sets ValueAmount
        /// </summary>
        [DataMember(Name="valueAmount", EmitDefaultValue=false)]
        public decimal? ValueAmount { get; private set; }

        /// <summary>
        /// The value date describes the date the amount is effective on the account.
        /// </summary>
        /// <value>The value date describes the date the amount is effective on the account.</value>
        [DataMember(Name="valueDate", EmitDefaultValue=false)]
        public DateTime? ValueDate { get; private set; }

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
            sb.Append("class BankTransaction {\n");
            sb.Append("  Adjustments: ").Append(Adjustments).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  CurrencyBankAccount: ").Append(CurrencyBankAccount).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FlowDirection: ").Append(FlowDirection).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  PostingAmount: ").Append(PostingAmount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TotalAdjustmentAmountIncludingTax: ").Append(TotalAdjustmentAmountIncludingTax).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValueAmount: ").Append(ValueAmount).Append("\n");
            sb.Append("  ValueDate: ").Append(ValueDate).Append("\n");
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
            return this.Equals(input as BankTransaction);
        }

        /// <summary>
        /// Returns true if BankTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of BankTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Adjustments == input.Adjustments ||
                    this.Adjustments != null &&
                    input.Adjustments != null &&
                    this.Adjustments.SequenceEqual(input.Adjustments)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.CurrencyBankAccount == input.CurrencyBankAccount ||
                    (this.CurrencyBankAccount != null &&
                    this.CurrencyBankAccount.Equals(input.CurrencyBankAccount))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.FlowDirection == input.FlowDirection ||
                    (this.FlowDirection != null &&
                    this.FlowDirection.Equals(input.FlowDirection))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.PostingAmount == input.PostingAmount ||
                    (this.PostingAmount != null &&
                    this.PostingAmount.Equals(input.PostingAmount))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TotalAdjustmentAmountIncludingTax == input.TotalAdjustmentAmountIncludingTax ||
                    (this.TotalAdjustmentAmountIncludingTax != null &&
                    this.TotalAdjustmentAmountIncludingTax.Equals(input.TotalAdjustmentAmountIncludingTax))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ValueAmount == input.ValueAmount ||
                    (this.ValueAmount != null &&
                    this.ValueAmount.Equals(input.ValueAmount))
                ) && 
                (
                    this.ValueDate == input.ValueDate ||
                    (this.ValueDate != null &&
                    this.ValueDate.Equals(input.ValueDate))
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
                if (this.Adjustments != null)
                    hashCode = hashCode * 59 + this.Adjustments.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.CurrencyBankAccount != null)
                    hashCode = hashCode * 59 + this.CurrencyBankAccount.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.FlowDirection != null)
                    hashCode = hashCode * 59 + this.FlowDirection.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.PostingAmount != null)
                    hashCode = hashCode * 59 + this.PostingAmount.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TotalAdjustmentAmountIncludingTax != null)
                    hashCode = hashCode * 59 + this.TotalAdjustmentAmountIncludingTax.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValueAmount != null)
                    hashCode = hashCode * 59 + this.ValueAmount.GetHashCode();
                if (this.ValueDate != null)
                    hashCode = hashCode * 59 + this.ValueDate.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
