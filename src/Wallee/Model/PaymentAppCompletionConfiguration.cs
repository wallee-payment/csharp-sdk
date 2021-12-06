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
    /// PaymentAppCompletionConfiguration
    /// </summary>
    [DataContract]
    public partial class PaymentAppCompletionConfiguration :  IEquatable<PaymentAppCompletionConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppCompletionConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentAppCompletionConfiguration()
        {
        }

        /// <summary>
        /// The completion endpoint is invoked to request the payment service provider to execute a completion.
        /// </summary>
        /// <value>The completion endpoint is invoked to request the payment service provider to execute a completion.</value>
        [DataMember(Name="completionEndpoint", EmitDefaultValue=true)]
        public string CompletionEndpoint { get; private set; }

        /// <summary>
        /// When the completion or the void is triggered we expect a feedback about the state of it. This timeout defines after how long we consider the void resp. completion as failed without receiving a final state update.
        /// </summary>
        /// <value>When the completion or the void is triggered we expect a feedback about the state of it. This timeout defines after how long we consider the void resp. completion as failed without receiving a final state update.</value>
        [DataMember(Name="completionTimeoutInMinutes", EmitDefaultValue=true)]
        public int? CompletionTimeoutInMinutes { get; private set; }

        /// <summary>
        /// The completion resp. the void can be triggered a while after the authorization of the transaction has been executed. This delay defines how many days after the authorization the void resp. completion must be triggered at the latest.
        /// </summary>
        /// <value>The completion resp. the void can be triggered a while after the authorization of the transaction has been executed. This delay defines how many days after the authorization the void resp. completion must be triggered at the latest.</value>
        [DataMember(Name="maximalCompletionDelayInDays", EmitDefaultValue=true)]
        public int? MaximalCompletionDelayInDays { get; private set; }

        /// <summary>
        /// This flag indicates whether the connector supports multiple completions for a single transaction or not.
        /// </summary>
        /// <value>This flag indicates whether the connector supports multiple completions for a single transaction or not.</value>
        [DataMember(Name="multipleCompletionsSupported", EmitDefaultValue=true)]
        public bool? MultipleCompletionsSupported { get; private set; }

        /// <summary>
        /// The void endpoint is invoked to request the payment service provider to execute a void.
        /// </summary>
        /// <value>The void endpoint is invoked to request the payment service provider to execute a void.</value>
        [DataMember(Name="voidEndpoint", EmitDefaultValue=true)]
        public string VoidEndpoint { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppCompletionConfiguration {\n");
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
            return this.Equals(input as PaymentAppCompletionConfiguration);
        }

        /// <summary>
        /// Returns true if PaymentAppCompletionConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppCompletionConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppCompletionConfiguration input)
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
