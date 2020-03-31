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
    /// ShopifySubscription
    /// </summary>
    [DataContract]
    public partial class ShopifySubscription :  IEquatable<ShopifySubscription>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public ShopifySubscriptionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifySubscription()
        {
        }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=true)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="createdOn", EmitDefaultValue=true)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets InitialTransaction
        /// </summary>
        [DataMember(Name="initialTransaction", EmitDefaultValue=true)]
        public long? InitialTransaction { get; private set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets OrderRecurrenceNumber
        /// </summary>
        [DataMember(Name="orderRecurrenceNumber", EmitDefaultValue=true)]
        public int? OrderRecurrenceNumber { get; private set; }

        /// <summary>
        /// Gets or Sets Shop
        /// </summary>
        [DataMember(Name="shop", EmitDefaultValue=true)]
        public long? Shop { get; private set; }


        /// <summary>
        /// Gets or Sets Subscriber
        /// </summary>
        [DataMember(Name="subscriber", EmitDefaultValue=true)]
        public ShopifySubscriber Subscriber { get; private set; }

        /// <summary>
        /// Gets or Sets TerminatedBy
        /// </summary>
        [DataMember(Name="terminatedBy", EmitDefaultValue=true)]
        public long? TerminatedBy { get; private set; }

        /// <summary>
        /// Gets or Sets TerminatedOn
        /// </summary>
        [DataMember(Name="terminatedOn", EmitDefaultValue=true)]
        public DateTime? TerminatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets TerminationRequestDate
        /// </summary>
        [DataMember(Name="terminationRequestDate", EmitDefaultValue=true)]
        public DateTime? TerminationRequestDate { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscription {\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InitialTransaction: ").Append(InitialTransaction).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  OrderRecurrenceNumber: ").Append(OrderRecurrenceNumber).Append("\n");
            sb.Append("  Shop: ").Append(Shop).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  TerminatedBy: ").Append(TerminatedBy).Append("\n");
            sb.Append("  TerminatedOn: ").Append(TerminatedOn).Append("\n");
            sb.Append("  TerminationRequestDate: ").Append(TerminationRequestDate).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShopifySubscription);
        }

        /// <summary>
        /// Returns true if ShopifySubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InitialTransaction == input.InitialTransaction ||
                    (this.InitialTransaction != null &&
                    this.InitialTransaction.Equals(input.InitialTransaction))
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
                    this.OrderRecurrenceNumber == input.OrderRecurrenceNumber ||
                    (this.OrderRecurrenceNumber != null &&
                    this.OrderRecurrenceNumber.Equals(input.OrderRecurrenceNumber))
                ) && 
                (
                    this.Shop == input.Shop ||
                    (this.Shop != null &&
                    this.Shop.Equals(input.Shop))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Subscriber == input.Subscriber ||
                    (this.Subscriber != null &&
                    this.Subscriber.Equals(input.Subscriber))
                ) && 
                (
                    this.TerminatedBy == input.TerminatedBy ||
                    (this.TerminatedBy != null &&
                    this.TerminatedBy.Equals(input.TerminatedBy))
                ) && 
                (
                    this.TerminatedOn == input.TerminatedOn ||
                    (this.TerminatedOn != null &&
                    this.TerminatedOn.Equals(input.TerminatedOn))
                ) && 
                (
                    this.TerminationRequestDate == input.TerminationRequestDate ||
                    (this.TerminationRequestDate != null &&
                    this.TerminationRequestDate.Equals(input.TerminationRequestDate))
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
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InitialTransaction != null)
                    hashCode = hashCode * 59 + this.InitialTransaction.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.OrderRecurrenceNumber != null)
                    hashCode = hashCode * 59 + this.OrderRecurrenceNumber.GetHashCode();
                if (this.Shop != null)
                    hashCode = hashCode * 59 + this.Shop.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Subscriber != null)
                    hashCode = hashCode * 59 + this.Subscriber.GetHashCode();
                if (this.TerminatedBy != null)
                    hashCode = hashCode * 59 + this.TerminatedBy.GetHashCode();
                if (this.TerminatedOn != null)
                    hashCode = hashCode * 59 + this.TerminatedOn.GetHashCode();
                if (this.TerminationRequestDate != null)
                    hashCode = hashCode * 59 + this.TerminationRequestDate.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
