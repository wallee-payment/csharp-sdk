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
    /// Subscription Version
    /// </summary>
    [DataContract]
    public partial class SubscriptionVersion :  IEquatable<SubscriptionVersion>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionVersion()
        {
        }

        /// <summary>
        /// ActivatedOn
        /// </summary>
        /// <value>ActivatedOn</value>
        [DataMember(Name="activatedOn", EmitDefaultValue=false)]
        public DateTime? ActivatedOn { get; private set; }

        /// <summary>
        /// The subscriber is charged in the billing currency. The billing currency has to be one of the enabled currencies on the subscription product.
        /// </summary>
        /// <value>The subscriber is charged in the billing currency. The billing currency has to be one of the enabled currencies on the subscription product.</value>
        [DataMember(Name="billingCurrency", EmitDefaultValue=false)]
        public string BillingCurrency { get; private set; }

        /// <summary>
        /// CreatedOn
        /// </summary>
        /// <value>CreatedOn</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The expected last period end is the date on which the projected end date of the last period is. This is only a projection and as such the actual date may be different.
        /// </summary>
        /// <value>The expected last period end is the date on which the projected end date of the last period is. This is only a projection and as such the actual date may be different.</value>
        [DataMember(Name="expectedLastPeriodEnd", EmitDefaultValue=false)]
        public DateTime? ExpectedLastPeriodEnd { get; private set; }

        /// <summary>
        /// FailedOn
        /// </summary>
        /// <value>FailedOn</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

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
        /// PlannedTerminationDate
        /// </summary>
        /// <value>PlannedTerminationDate</value>
        [DataMember(Name="plannedTerminationDate", EmitDefaultValue=false)]
        public DateTime? PlannedTerminationDate { get; private set; }

        /// <summary>
        /// ProductVersion
        /// </summary>
        /// <value>ProductVersion</value>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public SubscriptionProductVersion ProductVersion { get; private set; }

        /// <summary>
        /// SelectedComponents
        /// </summary>
        /// <value>SelectedComponents</value>
        [DataMember(Name="selectedComponents", EmitDefaultValue=false)]
        public List<SubscriptionProductComponent> SelectedComponents { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionVersionState? State { get; private set; }

        /// <summary>
        /// Subscription
        /// </summary>
        /// <value>Subscription</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public Subscription Subscription { get; private set; }

        /// <summary>
        /// TerminatedOn
        /// </summary>
        /// <value>TerminatedOn</value>
        [DataMember(Name="terminatedOn", EmitDefaultValue=false)]
        public DateTime? TerminatedOn { get; private set; }

        /// <summary>
        /// TerminatingOn
        /// </summary>
        /// <value>TerminatingOn</value>
        [DataMember(Name="terminatingOn", EmitDefaultValue=false)]
        public DateTime? TerminatingOn { get; private set; }

        /// <summary>
        /// TerminationIssuedOn
        /// </summary>
        /// <value>TerminationIssuedOn</value>
        [DataMember(Name="terminationIssuedOn", EmitDefaultValue=false)]
        public DateTime? TerminationIssuedOn { get; private set; }

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
            return this.Equals(obj as SubscriptionVersion);
        }

        /// <summary>
        /// Returns true if SubscriptionVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionVersion other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ActivatedOn == other.ActivatedOn ||
                    this.ActivatedOn != null &&
                    this.ActivatedOn.Equals(other.ActivatedOn)
                ) && 
                (
                    this.BillingCurrency == other.BillingCurrency ||
                    this.BillingCurrency != null &&
                    this.BillingCurrency.Equals(other.BillingCurrency)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.ExpectedLastPeriodEnd == other.ExpectedLastPeriodEnd ||
                    this.ExpectedLastPeriodEnd != null &&
                    this.ExpectedLastPeriodEnd.Equals(other.ExpectedLastPeriodEnd)
                ) && 
                (
                    this.FailedOn == other.FailedOn ||
                    this.FailedOn != null &&
                    this.FailedOn.Equals(other.FailedOn)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.PlannedTerminationDate == other.PlannedTerminationDate ||
                    this.PlannedTerminationDate != null &&
                    this.PlannedTerminationDate.Equals(other.PlannedTerminationDate)
                ) && 
                (
                    this.ProductVersion == other.ProductVersion ||
                    this.ProductVersion != null &&
                    this.ProductVersion.Equals(other.ProductVersion)
                ) && 
                (
                    this.SelectedComponents == other.SelectedComponents ||
                    this.SelectedComponents != null &&
                    this.SelectedComponents.SequenceEqual(other.SelectedComponents)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.TerminatedOn == other.TerminatedOn ||
                    this.TerminatedOn != null &&
                    this.TerminatedOn.Equals(other.TerminatedOn)
                ) && 
                (
                    this.TerminatingOn == other.TerminatingOn ||
                    this.TerminatingOn != null &&
                    this.TerminatingOn.Equals(other.TerminatingOn)
                ) && 
                (
                    this.TerminationIssuedOn == other.TerminationIssuedOn ||
                    this.TerminationIssuedOn != null &&
                    this.TerminationIssuedOn.Equals(other.TerminationIssuedOn)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.ActivatedOn != null)
                {
                    hash = hash * 59 + this.ActivatedOn.GetHashCode();
                }
                if (this.BillingCurrency != null)
                {
                    hash = hash * 59 + this.BillingCurrency.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.ExpectedLastPeriodEnd != null)
                {
                    hash = hash * 59 + this.ExpectedLastPeriodEnd.GetHashCode();
                }
                if (this.FailedOn != null)
                {
                    hash = hash * 59 + this.FailedOn.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.PlannedTerminationDate != null)
                {
                    hash = hash * 59 + this.PlannedTerminationDate.GetHashCode();
                }
                if (this.ProductVersion != null)
                {
                    hash = hash * 59 + this.ProductVersion.GetHashCode();
                }
                if (this.SelectedComponents != null)
                {
                    hash = hash * 59 + this.SelectedComponents.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Subscription != null)
                {
                    hash = hash * 59 + this.Subscription.GetHashCode();
                }
                if (this.TerminatedOn != null)
                {
                    hash = hash * 59 + this.TerminatedOn.GetHashCode();
                }
                if (this.TerminatingOn != null)
                {
                    hash = hash * 59 + this.TerminatingOn.GetHashCode();
                }
                if (this.TerminationIssuedOn != null)
                {
                    hash = hash * 59 + this.TerminationIssuedOn.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
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
