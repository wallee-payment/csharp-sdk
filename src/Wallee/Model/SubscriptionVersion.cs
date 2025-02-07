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
    /// SubscriptionVersion
    /// </summary>
    [DataContract]
    public partial class SubscriptionVersion :  IEquatable<SubscriptionVersion>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionVersionState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionVersion()
        {
        }

        /// <summary>
        /// The date and time when the subscription version was activated.
        /// </summary>
        /// <value>The date and time when the subscription version was activated.</value>
        [DataMember(Name="activatedOn", EmitDefaultValue=false)]
        public DateTime? ActivatedOn { get; private set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) of the currency used to invoice the customer. Must be one of the currencies supported by the product.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the currency used to invoice the customer. Must be one of the currencies supported by the product.</value>
        [DataMember(Name="billingCurrency", EmitDefaultValue=false)]
        public string BillingCurrency { get; private set; }

        /// <summary>
        /// Gets or Sets BillingCycleModel
        /// </summary>
        [DataMember(Name="billingCycleModel", EmitDefaultValue=false)]
        public BillingCycleModel BillingCycleModel { get; private set; }

        /// <summary>
        /// The configurations of the subscription&#39;s components.
        /// </summary>
        /// <value>The configurations of the subscription&#39;s components.</value>
        [DataMember(Name="componentConfigurations", EmitDefaultValue=false)]
        public List<SubscriptionComponentConfiguration> ComponentConfigurations { get; private set; }

        /// <summary>
        /// The date and time when the subscription version was created.
        /// </summary>
        /// <value>The date and time when the subscription version was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The date and time when the last period is expected to end.
        /// </summary>
        /// <value>The date and time when the last period is expected to end.</value>
        [DataMember(Name="expectedLastPeriodEnd", EmitDefaultValue=false)]
        public DateTime? ExpectedLastPeriodEnd { get; private set; }

        /// <summary>
        /// The date and time when the subscription version failed.
        /// </summary>
        /// <value>The date and time when the subscription version failed.</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The date and time when the termination of the subscription version is planned.
        /// </summary>
        /// <value>The date and time when the termination of the subscription version is planned.</value>
        [DataMember(Name="plannedTerminationDate", EmitDefaultValue=false)]
        public DateTime? PlannedTerminationDate { get; private set; }

        /// <summary>
        /// The product version that is subscribed to.
        /// </summary>
        /// <value>The product version that is subscribed to.</value>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public SubscriptionProductVersion ProductVersion { get; private set; }


        /// <summary>
        /// The subscription that this version belongs to.
        /// </summary>
        /// <value>The subscription that this version belongs to.</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public Subscription Subscription { get; private set; }

        /// <summary>
        /// The date and time when the subscription version was terminated.
        /// </summary>
        /// <value>The date and time when the subscription version was terminated.</value>
        [DataMember(Name="terminatedOn", EmitDefaultValue=false)]
        public DateTime? TerminatedOn { get; private set; }

        /// <summary>
        /// The date and time when the termination of the subscription version started.
        /// </summary>
        /// <value>The date and time when the termination of the subscription version started.</value>
        [DataMember(Name="terminatingOn", EmitDefaultValue=false)]
        public DateTime? TerminatingOn { get; private set; }

        /// <summary>
        /// The date and time when the termination of the subscription version was issued.
        /// </summary>
        /// <value>The date and time when the termination of the subscription version was issued.</value>
        [DataMember(Name="terminationIssuedOn", EmitDefaultValue=false)]
        public DateTime? TerminationIssuedOn { get; private set; }

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
            sb.Append("class SubscriptionVersion {\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  BillingCurrency: ").Append(BillingCurrency).Append("\n");
            sb.Append("  BillingCycleModel: ").Append(BillingCycleModel).Append("\n");
            sb.Append("  ComponentConfigurations: ").Append(ComponentConfigurations).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ExpectedLastPeriodEnd: ").Append(ExpectedLastPeriodEnd).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  PlannedTerminationDate: ").Append(PlannedTerminationDate).Append("\n");
            sb.Append("  ProductVersion: ").Append(ProductVersion).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  TerminatedOn: ").Append(TerminatedOn).Append("\n");
            sb.Append("  TerminatingOn: ").Append(TerminatingOn).Append("\n");
            sb.Append("  TerminationIssuedOn: ").Append(TerminationIssuedOn).Append("\n");
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
            return this.Equals(input as SubscriptionVersion);
        }

        /// <summary>
        /// Returns true if SubscriptionVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivatedOn == input.ActivatedOn ||
                    (this.ActivatedOn != null &&
                    this.ActivatedOn.Equals(input.ActivatedOn))
                ) && 
                (
                    this.BillingCurrency == input.BillingCurrency ||
                    (this.BillingCurrency != null &&
                    this.BillingCurrency.Equals(input.BillingCurrency))
                ) && 
                (
                    this.BillingCycleModel == input.BillingCycleModel ||
                    (this.BillingCycleModel != null &&
                    this.BillingCycleModel.Equals(input.BillingCycleModel))
                ) && 
                (
                    this.ComponentConfigurations == input.ComponentConfigurations ||
                    this.ComponentConfigurations != null &&
                    input.ComponentConfigurations != null &&
                    this.ComponentConfigurations.SequenceEqual(input.ComponentConfigurations)
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.ExpectedLastPeriodEnd == input.ExpectedLastPeriodEnd ||
                    (this.ExpectedLastPeriodEnd != null &&
                    this.ExpectedLastPeriodEnd.Equals(input.ExpectedLastPeriodEnd))
                ) && 
                (
                    this.FailedOn == input.FailedOn ||
                    (this.FailedOn != null &&
                    this.FailedOn.Equals(input.FailedOn))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                    this.PlannedTerminationDate == input.PlannedTerminationDate ||
                    (this.PlannedTerminationDate != null &&
                    this.PlannedTerminationDate.Equals(input.PlannedTerminationDate))
                ) && 
                (
                    this.ProductVersion == input.ProductVersion ||
                    (this.ProductVersion != null &&
                    this.ProductVersion.Equals(input.ProductVersion))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.TerminatedOn == input.TerminatedOn ||
                    (this.TerminatedOn != null &&
                    this.TerminatedOn.Equals(input.TerminatedOn))
                ) && 
                (
                    this.TerminatingOn == input.TerminatingOn ||
                    (this.TerminatingOn != null &&
                    this.TerminatingOn.Equals(input.TerminatingOn))
                ) && 
                (
                    this.TerminationIssuedOn == input.TerminationIssuedOn ||
                    (this.TerminationIssuedOn != null &&
                    this.TerminationIssuedOn.Equals(input.TerminationIssuedOn))
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
                if (this.ActivatedOn != null)
                    hashCode = hashCode * 59 + this.ActivatedOn.GetHashCode();
                if (this.BillingCurrency != null)
                    hashCode = hashCode * 59 + this.BillingCurrency.GetHashCode();
                if (this.BillingCycleModel != null)
                    hashCode = hashCode * 59 + this.BillingCycleModel.GetHashCode();
                if (this.ComponentConfigurations != null)
                    hashCode = hashCode * 59 + this.ComponentConfigurations.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.ExpectedLastPeriodEnd != null)
                    hashCode = hashCode * 59 + this.ExpectedLastPeriodEnd.GetHashCode();
                if (this.FailedOn != null)
                    hashCode = hashCode * 59 + this.FailedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.PlannedTerminationDate != null)
                    hashCode = hashCode * 59 + this.PlannedTerminationDate.GetHashCode();
                if (this.ProductVersion != null)
                    hashCode = hashCode * 59 + this.ProductVersion.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.TerminatedOn != null)
                    hashCode = hashCode * 59 + this.TerminatedOn.GetHashCode();
                if (this.TerminatingOn != null)
                    hashCode = hashCode * 59 + this.TerminatingOn.GetHashCode();
                if (this.TerminationIssuedOn != null)
                    hashCode = hashCode * 59 + this.TerminationIssuedOn.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
