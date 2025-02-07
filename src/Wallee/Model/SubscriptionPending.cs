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
    /// SubscriptionPending
    /// </summary>
    [DataContract]
    public partial class SubscriptionPending : SubscriptionUpdate,  IEquatable<SubscriptionPending>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPending" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionPending() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPending" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public SubscriptionPending(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SubscriptionPending and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for SubscriptionPending and cannot be null");
            }
            this.Version = version;
        }






        /// <summary>
        /// The merchant&#39;s reference used to identify the subscription.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the subscription.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// The subscriber that the subscription belongs to.
        /// </summary>
        /// <value>The subscriber that the subscription belongs to.</value>
        [DataMember(Name="subscriber", EmitDefaultValue=false)]
        public long? Subscriber { get; set; }

        /// <summary>
        /// The payment token that is used to charge the customer.
        /// </summary>
        /// <value>The payment token that is used to charge the customer.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public long? Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPending {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Affiliate: ").Append(Affiliate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PlannedTerminationDate: ").Append(PlannedTerminationDate).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as SubscriptionPending);
        }

        /// <summary>
        /// Returns true if SubscriptionPending instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPending input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && base.Equals(input) && 
                (
                    this.Affiliate == input.Affiliate ||
                    (this.Affiliate != null &&
                    this.Affiliate.Equals(input.Affiliate))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.PlannedTerminationDate == input.PlannedTerminationDate ||
                    (this.PlannedTerminationDate != null &&
                    this.PlannedTerminationDate.Equals(input.PlannedTerminationDate))
                ) && base.Equals(input) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && base.Equals(input) && 
                (
                    this.Subscriber == input.Subscriber ||
                    (this.Subscriber != null &&
                    this.Subscriber.Equals(input.Subscriber))
                ) && base.Equals(input) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                int hashCode = base.GetHashCode();
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
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Subscriber != null)
                    hashCode = hashCode * 59 + this.Subscriber.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }

    }

}
