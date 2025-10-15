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
    /// InvoiceReconciliationRecord
    /// </summary>
    [DataContract]
    public partial class InvoiceReconciliationRecord :  IEquatable<InvoiceReconciliationRecord>
    {
        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public ChargeAttemptEnvironment? Environment { get; private set; }
        /// <summary>
        /// Gets or Sets RejectionStatus
        /// </summary>
        [DataMember(Name="rejectionStatus", EmitDefaultValue=false)]
        public InvoiceReconciliationRecordRejectionStatus? RejectionStatus { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public InvoiceReconciliationRecordState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReconciliationRecord" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InvoiceReconciliationRecord()
        {
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; private set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; private set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets or Sets DiscardedBy
        /// </summary>
        [DataMember(Name="discardedBy", EmitDefaultValue=false)]
        public long? DiscardedBy { get; private set; }

        /// <summary>
        /// The discarded on date indicates when the bank transaction has been discarded.
        /// </summary>
        /// <value>The discarded on date indicates when the bank transaction has been discarded.</value>
        [DataMember(Name="discardedOn", EmitDefaultValue=false)]
        public DateTime? DiscardedOn { get; private set; }


        /// <summary>
        /// Gets or Sets FamilyName
        /// </summary>
        [DataMember(Name="familyName", EmitDefaultValue=false)]
        public string FamilyName { get; private set; }

        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>
        [DataMember(Name="givenName", EmitDefaultValue=false)]
        public string GivenName { get; private set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets LastResolutionFailure
        /// </summary>
        [DataMember(Name="lastResolutionFailure", EmitDefaultValue=false)]
        public FailureReason LastResolutionFailure { get; private set; }

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
        /// Gets or Sets ParticipantNumber
        /// </summary>
        [DataMember(Name="participantNumber", EmitDefaultValue=false)]
        public string ParticipantNumber { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentFeeAmount
        /// </summary>
        [DataMember(Name="paymentFeeAmount", EmitDefaultValue=false)]
        public decimal? PaymentFeeAmount { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentFeeCurrency
        /// </summary>
        [DataMember(Name="paymentFeeCurrency", EmitDefaultValue=false)]
        public string PaymentFeeCurrency { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentReason
        /// </summary>
        [DataMember(Name="paymentReason", EmitDefaultValue=false)]
        public string PaymentReason { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; private set; }

        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; private set; }


        /// <summary>
        /// Gets or Sets ResolvedBy
        /// </summary>
        [DataMember(Name="resolvedBy", EmitDefaultValue=false)]
        public long? ResolvedBy { get; private set; }

        /// <summary>
        /// The resolved on date indicates when the bank transaction has been resolved.
        /// </summary>
        /// <value>The resolved on date indicates when the bank transaction has been resolved.</value>
        [DataMember(Name="resolvedOn", EmitDefaultValue=false)]
        public DateTime? ResolvedOn { get; private set; }

        /// <summary>
        /// Gets or Sets SenderBankAccount
        /// </summary>
        [DataMember(Name="senderBankAccount", EmitDefaultValue=false)]
        public string SenderBankAccount { get; private set; }


        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public InvoiceReconciliationRecordType Type { get; private set; }

        /// <summary>
        /// Gets or Sets UniqueId
        /// </summary>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Gets or Sets ValueDate
        /// </summary>
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
            sb.Append("class InvoiceReconciliationRecord {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DiscardedBy: ").Append(DiscardedBy).Append("\n");
            sb.Append("  DiscardedOn: ").Append(DiscardedOn).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastResolutionFailure: ").Append(LastResolutionFailure).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  ParticipantNumber: ").Append(ParticipantNumber).Append("\n");
            sb.Append("  PaymentFeeAmount: ").Append(PaymentFeeAmount).Append("\n");
            sb.Append("  PaymentFeeCurrency: ").Append(PaymentFeeCurrency).Append("\n");
            sb.Append("  PaymentReason: ").Append(PaymentReason).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  RejectionStatus: ").Append(RejectionStatus).Append("\n");
            sb.Append("  ResolvedBy: ").Append(ResolvedBy).Append("\n");
            sb.Append("  ResolvedOn: ").Append(ResolvedOn).Append("\n");
            sb.Append("  SenderBankAccount: ").Append(SenderBankAccount).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
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
            return this.Equals(input as InvoiceReconciliationRecord);
        }

        /// <summary>
        /// Returns true if InvoiceReconciliationRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceReconciliationRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceReconciliationRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.DiscardedBy == input.DiscardedBy ||
                    (this.DiscardedBy != null &&
                    this.DiscardedBy.Equals(input.DiscardedBy))
                ) && 
                (
                    this.DiscardedOn == input.DiscardedOn ||
                    (this.DiscardedOn != null &&
                    this.DiscardedOn.Equals(input.DiscardedOn))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
                ) && 
                (
                    this.GivenName == input.GivenName ||
                    (this.GivenName != null &&
                    this.GivenName.Equals(input.GivenName))
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastResolutionFailure == input.LastResolutionFailure ||
                    (this.LastResolutionFailure != null &&
                    this.LastResolutionFailure.Equals(input.LastResolutionFailure))
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
                    this.ParticipantNumber == input.ParticipantNumber ||
                    (this.ParticipantNumber != null &&
                    this.ParticipantNumber.Equals(input.ParticipantNumber))
                ) && 
                (
                    this.PaymentFeeAmount == input.PaymentFeeAmount ||
                    (this.PaymentFeeAmount != null &&
                    this.PaymentFeeAmount.Equals(input.PaymentFeeAmount))
                ) && 
                (
                    this.PaymentFeeCurrency == input.PaymentFeeCurrency ||
                    (this.PaymentFeeCurrency != null &&
                    this.PaymentFeeCurrency.Equals(input.PaymentFeeCurrency))
                ) && 
                (
                    this.PaymentReason == input.PaymentReason ||
                    (this.PaymentReason != null &&
                    this.PaymentReason.Equals(input.PaymentReason))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.RejectionStatus == input.RejectionStatus ||
                    (this.RejectionStatus != null &&
                    this.RejectionStatus.Equals(input.RejectionStatus))
                ) && 
                (
                    this.ResolvedBy == input.ResolvedBy ||
                    (this.ResolvedBy != null &&
                    this.ResolvedBy.Equals(input.ResolvedBy))
                ) && 
                (
                    this.ResolvedOn == input.ResolvedOn ||
                    (this.ResolvedOn != null &&
                    this.ResolvedOn.Equals(input.ResolvedOn))
                ) && 
                (
                    this.SenderBankAccount == input.SenderBankAccount ||
                    (this.SenderBankAccount != null &&
                    this.SenderBankAccount.Equals(input.SenderBankAccount))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DiscardedBy != null)
                    hashCode = hashCode * 59 + this.DiscardedBy.GetHashCode();
                if (this.DiscardedOn != null)
                    hashCode = hashCode * 59 + this.DiscardedOn.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.FamilyName != null)
                    hashCode = hashCode * 59 + this.FamilyName.GetHashCode();
                if (this.GivenName != null)
                    hashCode = hashCode * 59 + this.GivenName.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastResolutionFailure != null)
                    hashCode = hashCode * 59 + this.LastResolutionFailure.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.ParticipantNumber != null)
                    hashCode = hashCode * 59 + this.ParticipantNumber.GetHashCode();
                if (this.PaymentFeeAmount != null)
                    hashCode = hashCode * 59 + this.PaymentFeeAmount.GetHashCode();
                if (this.PaymentFeeCurrency != null)
                    hashCode = hashCode * 59 + this.PaymentFeeCurrency.GetHashCode();
                if (this.PaymentReason != null)
                    hashCode = hashCode * 59 + this.PaymentReason.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.ReferenceNumber != null)
                    hashCode = hashCode * 59 + this.ReferenceNumber.GetHashCode();
                if (this.RejectionStatus != null)
                    hashCode = hashCode * 59 + this.RejectionStatus.GetHashCode();
                if (this.ResolvedBy != null)
                    hashCode = hashCode * 59 + this.ResolvedBy.GetHashCode();
                if (this.ResolvedOn != null)
                    hashCode = hashCode * 59 + this.ResolvedOn.GetHashCode();
                if (this.SenderBankAccount != null)
                    hashCode = hashCode * 59 + this.SenderBankAccount.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.ValueDate != null)
                    hashCode = hashCode * 59 + this.ValueDate.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
