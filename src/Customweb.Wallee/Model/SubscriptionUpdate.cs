
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
    /// SubscriptionUpdate model.
    /// </summary>
    [DataContract]
    public partial class SubscriptionUpdate :  IEquatable<SubscriptionUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdate" /> class.
        /// </summary>
        /// <param name="CreatedOn">CreatedOn</param>
        /// <param name="Description">Description</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="InitializedOn">InitializedOn</param>
        /// <param name="Language">Language</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="PlannedTerminationDate">PlannedTerminationDate</param>
        /// <param name="Reference">Reference</param>
        /// <param name="State">State</param>
        /// <param name="Subscriber">Subscriber</param>
        /// <param name="TerminatedOn">TerminatedOn</param>
        /// <param name="TerminatingOn">TerminatingOn</param>
        /// <param name="Token">Token</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public SubscriptionUpdate(DateTime? CreatedOn = default(DateTime?), string Description = default(string), long? Id = default(long?), DateTime? InitializedOn = default(DateTime?), string Language = default(string), long? LinkedSpaceId = default(long?), DateTime? PlannedPurgeDate = default(DateTime?), DateTime? PlannedTerminationDate = default(DateTime?), string Reference = default(string), SubscriptionState State = default(SubscriptionState), Subscriber Subscriber = default(Subscriber), DateTime? TerminatedOn = default(DateTime?), DateTime? TerminatingOn = default(DateTime?), Token Token = default(Token), long? Version = default(long?))
        {
            this.CreatedOn = CreatedOn;
            this.Description = Description;
            this.Id = Id;
            this.InitializedOn = InitializedOn;
            this.Language = Language;
            this.LinkedSpaceId = LinkedSpaceId;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.PlannedTerminationDate = PlannedTerminationDate;
            this.Reference = Reference;
            this.State = State;
            this.Subscriber = Subscriber;
            this.TerminatedOn = TerminatedOn;
            this.TerminatingOn = TerminatingOn;
            this.Token = Token;
            this.Version = Version;
        }

        /// <summary>
        /// CreatedOn
        /// </summary>
        /// <value>CreatedOn</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// InitializedOn
        /// </summary>
        /// <value>InitializedOn</value>
        [DataMember(Name="initializedOn", EmitDefaultValue=false)]
        public DateTime? InitializedOn { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// PlannedTerminationDate
        /// </summary>
        /// <value>PlannedTerminationDate</value>
        [DataMember(Name="plannedTerminationDate", EmitDefaultValue=false)]
        public DateTime? PlannedTerminationDate { get; set; }

        /// <summary>
        /// Reference
        /// </summary>
        /// <value>Reference</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionState State { get; set; }

        /// <summary>
        /// Subscriber
        /// </summary>
        /// <value>Subscriber</value>
        [DataMember(Name="subscriber", EmitDefaultValue=false)]
        public Subscriber Subscriber { get; set; }

        /// <summary>
        /// TerminatedOn
        /// </summary>
        /// <value>TerminatedOn</value>
        [DataMember(Name="terminatedOn", EmitDefaultValue=false)]
        public DateTime? TerminatedOn { get; set; }

        /// <summary>
        /// TerminatingOn
        /// </summary>
        /// <value>TerminatingOn</value>
        [DataMember(Name="terminatingOn", EmitDefaultValue=false)]
        public DateTime? TerminatingOn { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        /// <value>Token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public Token Token { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class SubscriptionUpdate {\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InitializedOn: ").Append(InitializedOn).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  PlannedTerminationDate: ").Append(PlannedTerminationDate).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  TerminatedOn: ").Append(TerminatedOn).Append("\n");
            sb.Append("  TerminatingOn: ").Append(TerminatingOn).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(obj as SubscriptionUpdate);
        }

        /// <summary>
        /// Returns true if SubscriptionUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InitializedOn == other.InitializedOn ||
                    this.InitializedOn != null &&
                    this.InitializedOn.Equals(other.InitializedOn)
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
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Subscriber == other.Subscriber ||
                    this.Subscriber != null &&
                    this.Subscriber.Equals(other.Subscriber)
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
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                // Suitable nullity checks etc, of course :)
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InitializedOn != null)
                    hash = hash * 59 + this.InitializedOn.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.PlannedTerminationDate != null)
                    hash = hash * 59 + this.PlannedTerminationDate.GetHashCode();
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Subscriber != null)
                    hash = hash * 59 + this.Subscriber.GetHashCode();
                if (this.TerminatedOn != null)
                    hash = hash * 59 + this.TerminatedOn.GetHashCode();
                if (this.TerminatingOn != null)
                    hash = hash * 59 + this.TerminatingOn.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
