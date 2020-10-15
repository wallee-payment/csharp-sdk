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
    /// The subscription charge represents a single charge carried out for a particular subscription.
    /// </summary>
    [DataContract]
    public partial class SubscriptionChargeCreate :  IEquatable<SubscriptionChargeCreate>
    {
        /// <summary>
        /// Gets or Sets ProcessingType
        /// </summary>
        [DataMember(Name="processingType", EmitDefaultValue=true)]
        public SubscriptionChargeProcessingType ProcessingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionChargeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionChargeCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionChargeCreate" /> class.
        /// </summary>
        /// <param name="externalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required).</param>
        /// <param name="processingType">processingType (required).</param>
        /// <param name="subscription">The field subscription indicates the subscription to which the charge belongs to. (required).</param>
        public SubscriptionChargeCreate(string externalId, SubscriptionChargeProcessingType processingType, long? subscription)
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for SubscriptionChargeCreate and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "processingType" is required (not null)
            if (processingType == null)
            {
                throw new InvalidDataException("processingType is a required property for SubscriptionChargeCreate and cannot be null");
            }
            this.ProcessingType = processingType;
            // to ensure "subscription" is required (not null)
            if (subscription == null)
            {
                throw new InvalidDataException("subscription is a required property for SubscriptionChargeCreate and cannot be null");
            }
            this.Subscription = subscription;
        }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=true)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// Gets or Sets PlannedExecutionDate
        /// </summary>
        [DataMember(Name="plannedExecutionDate", EmitDefaultValue=true)]
        public DateTime? PlannedExecutionDate { get; set; }


        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// The field subscription indicates the subscription to which the charge belongs to.
        /// </summary>
        /// <value>The field subscription indicates the subscription to which the charge belongs to.</value>
        [DataMember(Name="subscription", EmitDefaultValue=true)]
        public long? Subscription { get; set; }

        /// <summary>
        /// The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=true)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionChargeCreate {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
            sb.Append("  PlannedExecutionDate: ").Append(PlannedExecutionDate).Append("\n");
            sb.Append("  ProcessingType: ").Append(ProcessingType).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
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
            return this.Equals(input as SubscriptionChargeCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionChargeCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionChargeCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionChargeCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.FailedUrl == input.FailedUrl ||
                    (this.FailedUrl != null &&
                    this.FailedUrl.Equals(input.FailedUrl))
                ) && 
                (
                    this.PlannedExecutionDate == input.PlannedExecutionDate ||
                    (this.PlannedExecutionDate != null &&
                    this.PlannedExecutionDate.Equals(input.PlannedExecutionDate))
                ) && 
                (
                    this.ProcessingType == input.ProcessingType ||
                    (this.ProcessingType != null &&
                    this.ProcessingType.Equals(input.ProcessingType))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.SuccessUrl == input.SuccessUrl ||
                    (this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(input.SuccessUrl))
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.FailedUrl != null)
                    hashCode = hashCode * 59 + this.FailedUrl.GetHashCode();
                if (this.PlannedExecutionDate != null)
                    hashCode = hashCode * 59 + this.PlannedExecutionDate.GetHashCode();
                if (this.ProcessingType != null)
                    hashCode = hashCode * 59 + this.ProcessingType.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.SuccessUrl != null)
                    hashCode = hashCode * 59 + this.SuccessUrl.GetHashCode();
                return hashCode;
            }
        }

    }

}
