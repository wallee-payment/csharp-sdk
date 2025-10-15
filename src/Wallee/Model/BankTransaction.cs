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
        /// Indicates the direction of a bank transaction, specifying whether the amount flows into or out of the bank account.
        /// </summary>
        /// <value>Indicates the direction of a bank transaction, specifying whether the amount flows into or out of the bank account.</value>
        [DataMember(Name="flowDirection", EmitDefaultValue=false)]
        public BankTransactionFlowDirection? FlowDirection { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public BankTransactionState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BankTransaction()
        {
        }

        /// <summary>
        /// Adjustments are changes made to the initial transaction amount, such as fees or corrections.
        /// </summary>
        /// <value>Adjustments are changes made to the initial transaction amount, such as fees or corrections.</value>
        [DataMember(Name="adjustments", EmitDefaultValue=false)]
        public List<PaymentAdjustment> Adjustments { get; private set; }

        /// <summary>
        /// The ID of the user the bank transaction was created by.
        /// </summary>
        /// <value>The ID of the user the bank transaction was created by.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The currency bank account that sends or receives money based on the bank transaction&#39;s flow direction.
        /// </summary>
        /// <value>The currency bank account that sends or receives money based on the bank transaction&#39;s flow direction.</value>
        [DataMember(Name="currencyBankAccount", EmitDefaultValue=false)]
        public CurrencyBankAccount CurrencyBankAccount { get; private set; }

        /// <summary>
        /// A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.
        /// </summary>
        /// <value>A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }


        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The payment date specifies the date on which the payment was processed.
        /// </summary>
        /// <value>The payment date specifies the date on which the payment was processed.</value>
        [DataMember(Name="paymentDate", EmitDefaultValue=false)]
        public DateTime? PaymentDate { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The posting amount refers to the monetary value recorded for the bank transaction prior to any adjustments.
        /// </summary>
        /// <value>The posting amount refers to the monetary value recorded for the bank transaction prior to any adjustments.</value>
        [DataMember(Name="postingAmount", EmitDefaultValue=false)]
        public decimal? PostingAmount { get; private set; }

        /// <summary>
        /// A unique reference to identify the bank transaction.
        /// </summary>
        /// <value>A unique reference to identify the bank transaction.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; private set; }

        /// <summary>
        /// The source indicates how the bank transaction was created.
        /// </summary>
        /// <value>The source indicates how the bank transaction was created.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public long? Source { get; private set; }


        /// <summary>
        /// Represents the total value of all adjustments to the bank transaction, including tax.
        /// </summary>
        /// <value>Represents the total value of all adjustments to the bank transaction, including tax.</value>
        [DataMember(Name="totalAdjustmentAmountIncludingTax", EmitDefaultValue=false)]
        public decimal? TotalAdjustmentAmountIncludingTax { get; private set; }

        /// <summary>
        /// The bank transaction&#39;s type.
        /// </summary>
        /// <value>The bank transaction&#39;s type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public long? Type { get; private set; }

        /// <summary>
        /// The value amount represents the net monetary value of the transaction after applicable deductions.
        /// </summary>
        /// <value>The value amount represents the net monetary value of the transaction after applicable deductions.</value>
        [DataMember(Name="valueAmount", EmitDefaultValue=false)]
        public decimal? ValueAmount { get; private set; }

        /// <summary>
        /// The value date indicates the date on which the transaction amount becomes effective.
        /// </summary>
        /// <value>The value date indicates the date on which the transaction amount becomes effective.</value>
        [DataMember(Name="valueDate", EmitDefaultValue=false)]
        public DateTime? ValueDate { get; private set; }

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
            sb.Append("class BankTransaction {\n");
            sb.Append("  Adjustments: ").Append(Adjustments).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  CurrencyBankAccount: ").Append(CurrencyBankAccount).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FlowDirection: ").Append(FlowDirection).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
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
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
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
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
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
