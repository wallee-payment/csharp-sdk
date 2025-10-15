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
        /// The processing type specifies how the charge is to be processed.
        /// </summary>
        /// <value>The processing type specifies how the charge is to be processed.</value>
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
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="processingType">The processing type specifies how the charge is to be processed. (required).</param>
        /// <param name="subscription">The subscription that the charge belongs to. (required).</param>
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
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The URL to redirect the customer back to after they canceled or failed to authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they canceled or failed to authenticated their payment.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// The date and time when the execution of the charge is planned.
        /// </summary>
        /// <value>The date and time when the execution of the charge is planned.</value>
        [DataMember(Name="plannedExecutionDate", EmitDefaultValue=false)]
        public DateTime? PlannedExecutionDate { get; set; }


        /// <summary>
        /// The merchant&#39;s reference used to identify the charge.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the charge.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// The subscription that the charge belongs to.
        /// </summary>
        /// <value>The subscription that the charge belongs to.</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; set; }

        /// <summary>
        /// The URL to redirect the customer back to after they successfully authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they successfully authenticated their payment.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
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
