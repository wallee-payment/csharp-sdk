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
    /// Abstract Debt Collection Case
    /// </summary>
    [DataContract]
    public partial class AbstractDebtCollectionCaseUpdate :  IEquatable<AbstractDebtCollectionCaseUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractDebtCollectionCaseUpdate" /> class.
        /// </summary>
        /// <param name="BillingAddress">The billing address of the case identifies the debtor.</param>
        /// <param name="ContractDate">The contract date is the date on which the contract with the debtor was signed on.</param>
        /// <param name="Currency">The currency defines the billing currency of the debt collection case.</param>
        /// <param name="DueDate">The due date indicates the date on which the amount receivable was due. This date has to be always in the past.</param>
        /// <param name="Environment">The environment in which this case will be processed. There must be a debt collector configuration present which supports the chosen environment.</param>
        /// <param name="Language">The language indicates the language to be used in the communication with the debtor.</param>
        /// <param name="LineItems">The line items of the debt collection case will be shown on documents sent to the debtor and the total of them makes up total amount to collect.</param>
        /// <param name="SpaceViewId">SpaceViewId</param>
        public AbstractDebtCollectionCaseUpdate(long? SpaceViewId = default(long?), DateTime? ContractDate = default(DateTime?), DebtCollectionEnvironment? Environment = default(DebtCollectionEnvironment?), string Language = default(string), List<LineItemCreate> LineItems = default(List<LineItemCreate>), string Currency = default(string), DateTime? DueDate = default(DateTime?), AddressCreate BillingAddress = default(AddressCreate))
        {
            this.BillingAddress = BillingAddress;
            this.ContractDate = ContractDate;
            this.Currency = Currency;
            this.DueDate = DueDate;
            this.Environment = Environment;
            this.Language = Language;
            this.LineItems = LineItems;
            this.SpaceViewId = SpaceViewId;
        }

        /// <summary>
        /// The billing address of the case identifies the debtor.
        /// </summary>
        /// <value>The billing address of the case identifies the debtor.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// The contract date is the date on which the contract with the debtor was signed on.
        /// </summary>
        /// <value>The contract date is the date on which the contract with the debtor was signed on.</value>
        [DataMember(Name="contractDate", EmitDefaultValue=false)]
        public DateTime? ContractDate { get; set; }

        /// <summary>
        /// The currency defines the billing currency of the debt collection case.
        /// </summary>
        /// <value>The currency defines the billing currency of the debt collection case.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The due date indicates the date on which the amount receivable was due. This date has to be always in the past.
        /// </summary>
        /// <value>The due date indicates the date on which the amount receivable was due. This date has to be always in the past.</value>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The environment in which this case will be processed. There must be a debt collector configuration present which supports the chosen environment.
        /// </summary>
        /// <value>The environment in which this case will be processed. There must be a debt collector configuration present which supports the chosen environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public DebtCollectionEnvironment? Environment { get; set; }

        /// <summary>
        /// The language indicates the language to be used in the communication with the debtor.
        /// </summary>
        /// <value>The language indicates the language to be used in the communication with the debtor.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The line items of the debt collection case will be shown on documents sent to the debtor and the total of them makes up total amount to collect.
        /// </summary>
        /// <value>The line items of the debt collection case will be shown on documents sent to the debtor and the total of them makes up total amount to collect.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// SpaceViewId
        /// </summary>
        /// <value>SpaceViewId</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
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
            return this.Equals(obj as AbstractDebtCollectionCaseUpdate);
        }

        /// <summary>
        /// Returns true if AbstractDebtCollectionCaseUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractDebtCollectionCaseUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractDebtCollectionCaseUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.ContractDate == other.ContractDate ||
                    this.ContractDate != null &&
                    this.ContractDate.Equals(other.ContractDate)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.DueDate == other.DueDate ||
                    this.DueDate != null &&
                    this.DueDate.Equals(other.DueDate)
                ) && 
                (
                    this.Environment == other.Environment ||
                    this.Environment != null &&
                    this.Environment.Equals(other.Environment)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.SpaceViewId == other.SpaceViewId ||
                    this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(other.SpaceViewId)
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
                if (this.BillingAddress != null)
                {
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                }
                if (this.ContractDate != null)
                {
                    hash = hash * 59 + this.ContractDate.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hash = hash * 59 + this.Currency.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hash = hash * 59 + this.DueDate.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hash = hash * 59 + this.Environment.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                if (this.SpaceViewId != null)
                {
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
