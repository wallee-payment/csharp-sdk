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
    /// SubscriptionUpdate
    /// </summary>
    [DataContract]
    public partial class SubscriptionUpdate :  IEquatable<SubscriptionUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdate" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public SubscriptionUpdate(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SubscriptionUpdate and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for SubscriptionUpdate and cannot be null");
            }
            this.Version = version;
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
        /// The affiliate that led to the creation of the subscription.
        /// </summary>
        /// <value>The affiliate that led to the creation of the subscription.</value>
        [DataMember(Name="affiliate", EmitDefaultValue=false)]
        public long? Affiliate { get; set; }

        /// <summary>
        /// A description used to identify the subscription.
        /// </summary>
        /// <value>A description used to identify the subscription.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the subscription is planned to be terminated.
        /// </summary>
        /// <value>The date and time when the subscription is planned to be terminated.</value>
        [DataMember(Name="plannedTerminationDate", EmitDefaultValue=false)]
        public DateTime? PlannedTerminationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Affiliate: ").Append(Affiliate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PlannedTerminationDate: ").Append(PlannedTerminationDate).Append("\n");
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
            return this.Equals(input as SubscriptionUpdate);
        }

        /// <summary>
        /// Returns true if SubscriptionUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Affiliate == input.Affiliate ||
                    (this.Affiliate != null &&
                    this.Affiliate.Equals(input.Affiliate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PlannedTerminationDate == input.PlannedTerminationDate ||
                    (this.PlannedTerminationDate != null &&
                    this.PlannedTerminationDate.Equals(input.PlannedTerminationDate))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Affiliate != null)
                    hashCode = hashCode * 59 + this.Affiliate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PlannedTerminationDate != null)
                    hashCode = hashCode * 59 + this.PlannedTerminationDate.GetHashCode();
                return hashCode;
            }
        }

    }

}
