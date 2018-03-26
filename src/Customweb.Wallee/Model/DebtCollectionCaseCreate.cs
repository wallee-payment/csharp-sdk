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
    /// The debt collection case represents a try to collect the money from the debtor.
    /// </summary>
    [DataContract]
    public partial class DebtCollectionCaseCreate : AbstractDebtCollectionCaseUpdate,  IEquatable<DebtCollectionCaseCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DebtCollectionCaseCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseCreate" /> class.
        /// </summary>
        /// <param name="CollectorConfiguration">The collector configuration determines how the debt collection case is processed.</param>
        /// <param name="ExternalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required)</param>
        /// <param name="Reference">The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case. (required)</param>
        public DebtCollectionCaseCreate(DateTime? ContractDate = default(DateTime?), DebtCollectionEnvironment? Environment = default(DebtCollectionEnvironment?), string Language = default(string), List<LineItemCreate> LineItems = default(List<LineItemCreate>), string Reference = default(string), string Currency = default(string), DateTime? DueDate = default(DateTime?), long? CollectorConfiguration = default(long?), long? SpaceViewId = default(long?), string ExternalId = default(string), AddressCreate BillingAddress = default(AddressCreate))
        {
            // to ensure "ExternalId" is required (not null)
            if (ExternalId == null)
            {
                throw new ArgumentNullException("ExternalId is a required property for DebtCollectionCaseCreate and cannot be null");
            }
            else
            {
                this.ExternalId = ExternalId;
            }
            // to ensure "Reference" is required (not null)
            if (Reference == null)
            {
                throw new ArgumentNullException("Reference is a required property for DebtCollectionCaseCreate and cannot be null");
            }
            else
            {
                this.Reference = Reference;
            }
            this.CollectorConfiguration = CollectorConfiguration;
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
        /// The collector configuration determines how the debt collection case is processed.
        /// </summary>
        /// <value>The collector configuration determines how the debt collection case is processed.</value>
        [DataMember(Name="collectorConfiguration", EmitDefaultValue=false)]
        public long? CollectorConfiguration { get; set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case.
        /// </summary>
        /// <value>The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

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
        public new string ToJson()
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
            return this.Equals(obj as DebtCollectionCaseCreate);
        }

        /// <summary>
        /// Returns true if DebtCollectionCaseCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of DebtCollectionCaseCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtCollectionCaseCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CollectorConfiguration == other.CollectorConfiguration ||
                    this.CollectorConfiguration != null &&
                    this.CollectorConfiguration.Equals(other.CollectorConfiguration)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
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
                if (this.CollectorConfiguration != null)
                {
                    hash = hash * 59 + this.CollectorConfiguration.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hash = hash * 59 + this.Reference.GetHashCode();
                }
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
