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
    public partial class DebtCollectionCaseUpdate : AbstractDebtCollectionCaseUpdate,  IEquatable<DebtCollectionCaseUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DebtCollectionCaseUpdate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseUpdate" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required)</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required)</param>
        public DebtCollectionCaseUpdate(DateTime? ContractDate = default(DateTime?), long? Id = default(long?), DebtCollectionEnvironment? Environment = default(DebtCollectionEnvironment?), string Language = default(string), List<LineItemCreate> LineItems = default(List<LineItemCreate>), long? Version = default(long?), string Currency = default(string), DateTime? DueDate = default(DateTime?), long? SpaceViewId = default(long?), AddressCreate BillingAddress = default(AddressCreate))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new ArgumentNullException("Id is a required property for DebtCollectionCaseUpdate and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new ArgumentNullException("Version is a required property for DebtCollectionCaseUpdate and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
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
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

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
            return this.Equals(obj as DebtCollectionCaseUpdate);
        }

        /// <summary>
        /// Returns true if DebtCollectionCaseUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of DebtCollectionCaseUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtCollectionCaseUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
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
