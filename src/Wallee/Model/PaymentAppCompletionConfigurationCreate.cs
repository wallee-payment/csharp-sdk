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
    /// PaymentAppCompletionConfigurationCreate
    /// </summary>
    [DataContract]
    public partial class PaymentAppCompletionConfigurationCreate :  IEquatable<PaymentAppCompletionConfigurationCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppCompletionConfigurationCreate" /> class.
        /// </summary>
        public PaymentAppCompletionConfigurationCreate()
        {
        }

        /// <summary>
        /// The URL that the payment service provider will invoke to process a completion request. This endpoint handles communication with the provider for initiating and managing completions.
        /// </summary>
        /// <value>The URL that the payment service provider will invoke to process a completion request. This endpoint handles communication with the provider for initiating and managing completions.</value>
        [DataMember(Name="completionEndpoint", EmitDefaultValue=false)]
        public string CompletionEndpoint { get; set; }

        /// <summary>
        /// The maximum time (in minutes) to wait for a response from the payment service provider after a completion request is triggered. If no feedback or final status is received within this period, the completion is considered failed.
        /// </summary>
        /// <value>The maximum time (in minutes) to wait for a response from the payment service provider after a completion request is triggered. If no feedback or final status is received within this period, the completion is considered failed.</value>
        [DataMember(Name="completionTimeoutInMinutes", EmitDefaultValue=false)]
        public int? CompletionTimeoutInMinutes { get; set; }

        /// <summary>
        /// The maximum number of days after a transaction&#39;s authorization during which a completion or void action can be triggered. Once this period has passed, neither action can be executed.
        /// </summary>
        /// <value>The maximum number of days after a transaction&#39;s authorization during which a completion or void action can be triggered. Once this period has passed, neither action can be executed.</value>
        [DataMember(Name="maximalCompletionDelayInDays", EmitDefaultValue=false)]
        public int? MaximalCompletionDelayInDays { get; set; }

        /// <summary>
        /// Whether the payment connector can process multiple completions for a single transaction.
        /// </summary>
        /// <value>Whether the payment connector can process multiple completions for a single transaction.</value>
        [DataMember(Name="multipleCompletionsSupported", EmitDefaultValue=false)]
        public bool? MultipleCompletionsSupported { get; set; }

        /// <summary>
        /// The URL that the payment service provider will invoke to process a void request. This endpoint handles communication with the provider for initiating and managing voids.
        /// </summary>
        /// <value>The URL that the payment service provider will invoke to process a void request. This endpoint handles communication with the provider for initiating and managing voids.</value>
        [DataMember(Name="voidEndpoint", EmitDefaultValue=false)]
        public string VoidEndpoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppCompletionConfigurationCreate {\n");
            sb.Append("  CompletionEndpoint: ").Append(CompletionEndpoint).Append("\n");
            sb.Append("  CompletionTimeoutInMinutes: ").Append(CompletionTimeoutInMinutes).Append("\n");
            sb.Append("  MaximalCompletionDelayInDays: ").Append(MaximalCompletionDelayInDays).Append("\n");
            sb.Append("  MultipleCompletionsSupported: ").Append(MultipleCompletionsSupported).Append("\n");
            sb.Append("  VoidEndpoint: ").Append(VoidEndpoint).Append("\n");
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
            return this.Equals(input as PaymentAppCompletionConfigurationCreate);
        }

        /// <summary>
        /// Returns true if PaymentAppCompletionConfigurationCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppCompletionConfigurationCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppCompletionConfigurationCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompletionEndpoint == input.CompletionEndpoint ||
                    (this.CompletionEndpoint != null &&
                    this.CompletionEndpoint.Equals(input.CompletionEndpoint))
                ) && 
                (
                    this.CompletionTimeoutInMinutes == input.CompletionTimeoutInMinutes ||
                    (this.CompletionTimeoutInMinutes != null &&
                    this.CompletionTimeoutInMinutes.Equals(input.CompletionTimeoutInMinutes))
                ) && 
                (
                    this.MaximalCompletionDelayInDays == input.MaximalCompletionDelayInDays ||
                    (this.MaximalCompletionDelayInDays != null &&
                    this.MaximalCompletionDelayInDays.Equals(input.MaximalCompletionDelayInDays))
                ) && 
                (
                    this.MultipleCompletionsSupported == input.MultipleCompletionsSupported ||
                    (this.MultipleCompletionsSupported != null &&
                    this.MultipleCompletionsSupported.Equals(input.MultipleCompletionsSupported))
                ) && 
                (
                    this.VoidEndpoint == input.VoidEndpoint ||
                    (this.VoidEndpoint != null &&
                    this.VoidEndpoint.Equals(input.VoidEndpoint))
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
                if (this.CompletionEndpoint != null)
                    hashCode = hashCode * 59 + this.CompletionEndpoint.GetHashCode();
                if (this.CompletionTimeoutInMinutes != null)
                    hashCode = hashCode * 59 + this.CompletionTimeoutInMinutes.GetHashCode();
                if (this.MaximalCompletionDelayInDays != null)
                    hashCode = hashCode * 59 + this.MaximalCompletionDelayInDays.GetHashCode();
                if (this.MultipleCompletionsSupported != null)
                    hashCode = hashCode * 59 + this.MultipleCompletionsSupported.GetHashCode();
                if (this.VoidEndpoint != null)
                    hashCode = hashCode * 59 + this.VoidEndpoint.GetHashCode();
                return hashCode;
            }
        }

    }

}
