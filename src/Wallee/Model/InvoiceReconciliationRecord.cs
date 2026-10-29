/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// InvoiceReconciliationRecord
    /// </summary>
    [DataContract(Name = "InvoiceReconciliationRecord")]
    public partial class InvoiceReconciliationRecord : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RejectionStatus
        /// </summary>
        [DataMember(Name = "rejectionStatus", EmitDefaultValue = false)]
        public InvoiceReconciliationRecordRejectionStatus? RejectionStatus { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public InvoiceReconciliationRecordState? State { get; set; }

        /// <summary>
        /// Gets or Sets BankPaymentType
        /// </summary>
        [DataMember(Name = "bankPaymentType", EmitDefaultValue = false)]
        public BankPaymentType? BankPaymentType { get; set; }

        /// <summary>
        /// Gets or Sets VarEnvironment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public ChargeAttemptEnvironment? VarEnvironment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReconciliationRecord" /> class.
        /// </summary>
        /// <param name="lastResolutionFailure">lastResolutionFailure.</param>
        /// <param name="rejectionStatus">rejectionStatus.</param>
        /// <param name="type">type.</param>
        /// <param name="state">state.</param>
        /// <param name="bankPaymentType">bankPaymentType.</param>
        /// <param name="varEnvironment">varEnvironment.</param>
        public InvoiceReconciliationRecord(FailureReason lastResolutionFailure = default, InvoiceReconciliationRecordRejectionStatus? rejectionStatus = default, InvoiceReconciliationRecordType type = default, InvoiceReconciliationRecordState? state = default, BankPaymentType? bankPaymentType = default, ChargeAttemptEnvironment? varEnvironment = default)
        {
            this.LastResolutionFailure = lastResolutionFailure;
            this.RejectionStatus = rejectionStatus;
            this.Type = type;
            this.State = state;
            this.BankPaymentType = bankPaymentType;
            this.VarEnvironment = varEnvironment;
        }

        /// <summary>
        /// The discarded on date indicates when the bank transaction has been discarded.
        /// </summary>
        /// <value>The discarded on date indicates when the bank transaction has been discarded.</value>
        [DataMember(Name = "discardedOn", EmitDefaultValue = false)]
        public DateTime DiscardedOn { get; private set; }

        /// <summary>
        /// Returns false as DiscardedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscardedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastResolutionFailure
        /// </summary>
        [DataMember(Name = "lastResolutionFailure", EmitDefaultValue = false)]
        public FailureReason LastResolutionFailure { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; private set; }

        /// <summary>
        /// Returns false as Country should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCountry()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; private set; }

        /// <summary>
        /// Returns false as City should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCity()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ResolvedBy
        /// </summary>
        [DataMember(Name = "resolvedBy", EmitDefaultValue = false)]
        public long ResolvedBy { get; private set; }

        /// <summary>
        /// Returns false as ResolvedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResolvedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DiscardedBy
        /// </summary>
        [DataMember(Name = "discardedBy", EmitDefaultValue = false)]
        public long DiscardedBy { get; private set; }

        /// <summary>
        /// Returns false as DiscardedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscardedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public InvoiceReconciliationRecordType Type { get; set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Returns false as CreatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PaymentFeeCurrency
        /// </summary>
        [DataMember(Name = "paymentFeeCurrency", EmitDefaultValue = false)]
        public string PaymentFeeCurrency { get; private set; }

        /// <summary>
        /// Returns false as PaymentFeeCurrency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentFeeCurrency()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PaymentReason
        /// </summary>
        [DataMember(Name = "paymentReason", EmitDefaultValue = false)]
        public string PaymentReason { get; private set; }

        /// <summary>
        /// Returns false as PaymentReason should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentReason()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public string ReferenceNumber { get; private set; }

        /// <summary>
        /// Returns false as ReferenceNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReferenceNumber()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; private set; }

        /// <summary>
        /// Returns false as Street should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStreet()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FamilyName
        /// </summary>
        [DataMember(Name = "familyName", EmitDefaultValue = false)]
        public string FamilyName { get; private set; }

        /// <summary>
        /// Returns false as FamilyName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFamilyName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; private set; }

        /// <summary>
        /// Returns false as Currency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrency()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The payment transaction this object is linked to.
        /// </summary>
        /// <value>The payment transaction this object is linked to.</value>
        [DataMember(Name = "linkedTransaction", EmitDefaultValue = false)]
        public long LinkedTransaction { get; private set; }

        /// <summary>
        /// Returns false as LinkedTransaction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedTransaction()
        {
            return false;
        }
        /// <summary>
        /// The resolved on date indicates when the bank transaction has been resolved.
        /// </summary>
        /// <value>The resolved on date indicates when the bank transaction has been resolved.</value>
        [DataMember(Name = "resolvedOn", EmitDefaultValue = false)]
        public DateTime ResolvedOn { get; private set; }

        /// <summary>
        /// Returns false as ResolvedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResolvedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; private set; }

        /// <summary>
        /// Returns false as Amount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; private set; }

        /// <summary>
        /// Returns false as Address should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddress()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>
        [DataMember(Name = "givenName", EmitDefaultValue = false)]
        public string GivenName { get; private set; }

        /// <summary>
        /// Returns false as GivenName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGivenName()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name = "plannedPurgeDate", EmitDefaultValue = false)]
        public DateTime PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedPurgeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedPurgeDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ValueDate
        /// </summary>
        [DataMember(Name = "valueDate", EmitDefaultValue = false)]
        public DateTime ValueDate { get; private set; }

        /// <summary>
        /// Returns false as ValueDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValueDate()
        {
            return false;
        }
        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PaymentFeeAmount
        /// </summary>
        [DataMember(Name = "paymentFeeAmount", EmitDefaultValue = false)]
        public decimal PaymentFeeAmount { get; private set; }

        /// <summary>
        /// Returns false as PaymentFeeAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentFeeAmount()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "linkedSpaceId", EmitDefaultValue = false)]
        public long LinkedSpaceId { get; private set; }

        /// <summary>
        /// Returns false as LinkedSpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedSpaceId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SenderBankAccount
        /// </summary>
        [DataMember(Name = "senderBankAccount", EmitDefaultValue = false)]
        public string SenderBankAccount { get; private set; }

        /// <summary>
        /// Returns false as SenderBankAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSenderBankAccount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ParticipantNumber
        /// </summary>
        [DataMember(Name = "participantNumber", EmitDefaultValue = false)]
        public string ParticipantNumber { get; private set; }

        /// <summary>
        /// Returns false as ParticipantNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParticipantNumber()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; private set; }

        /// <summary>
        /// Returns false as Iban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIban()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name = "postCode", EmitDefaultValue = false)]
        public string PostCode { get; private set; }

        /// <summary>
        /// Returns false as PostCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostCode()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UniqueId
        /// </summary>
        [DataMember(Name = "uniqueId", EmitDefaultValue = false)]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Returns false as UniqueId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUniqueId()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceReconciliationRecord {\n");
            sb.Append("  DiscardedOn: ").Append(DiscardedOn).Append("\n");
            sb.Append("  LastResolutionFailure: ").Append(LastResolutionFailure).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  RejectionStatus: ").Append(RejectionStatus).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  ResolvedBy: ").Append(ResolvedBy).Append("\n");
            sb.Append("  DiscardedBy: ").Append(DiscardedBy).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  PaymentFeeCurrency: ").Append(PaymentFeeCurrency).Append("\n");
            sb.Append("  PaymentReason: ").Append(PaymentReason).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  ResolvedOn: ").Append(ResolvedOn).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  BankPaymentType: ").Append(BankPaymentType).Append("\n");
            sb.Append("  ValueDate: ").Append(ValueDate).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  PaymentFeeAmount: ").Append(PaymentFeeAmount).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  SenderBankAccount: ").Append(SenderBankAccount).Append("\n");
            sb.Append("  ParticipantNumber: ").Append(ParticipantNumber).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ReferenceNumber (string) maxLength
            if (this.ReferenceNumber != null && this.ReferenceNumber.Length > 255)
            {
                yield return new ValidationResult("Invalid value for ReferenceNumber, length must be less than 255.", new [] { "ReferenceNumber" });
            }

            // ParticipantNumber (string) maxLength
            if (this.ParticipantNumber != null && this.ParticipantNumber.Length > 100)
            {
                yield return new ValidationResult("Invalid value for ParticipantNumber, length must be less than 100.", new [] { "ParticipantNumber" });
            }

            // Iban (string) maxLength
            if (this.Iban != null && this.Iban.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Iban, length must be less than 100.", new [] { "Iban" });
            }

            // UniqueId (string) maxLength
            if (this.UniqueId != null && this.UniqueId.Length > 500)
            {
                yield return new ValidationResult("Invalid value for UniqueId, length must be less than 500.", new [] { "UniqueId" });
            }

            yield break;
        }
    }

}
