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
    /// TransactionCompletionRequest
    /// </summary>
    [DataContract]
    public partial class TransactionCompletionRequest :  IEquatable<TransactionCompletionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCompletionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionCompletionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCompletionRequest" /> class.
        /// </summary>
        /// <param name="externalId">The external ID helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required).</param>
        /// <param name="lastCompletion">The last completion flag indicates if this is the last completion. After the last completion is created no further completions can be issued. (required).</param>
        /// <param name="transactionId">The ID of the transaction which should be completed. (required).</param>
        public TransactionCompletionRequest(string externalId, bool? lastCompletion, long? transactionId)
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for TransactionCompletionRequest and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "lastCompletion" is required (not null)
            if (lastCompletion == null)
            {
                throw new InvalidDataException("lastCompletion is a required property for TransactionCompletionRequest and cannot be null");
            }
            this.LastCompletion = lastCompletion;
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new InvalidDataException("transactionId is a required property for TransactionCompletionRequest and cannot be null");
            }
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// The external ID helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external ID helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The last completion flag indicates if this is the last completion. After the last completion is created no further completions can be issued.
        /// </summary>
        /// <value>The last completion flag indicates if this is the last completion. After the last completion is created no further completions can be issued.</value>
        [DataMember(Name="lastCompletion", EmitDefaultValue=false)]
        public bool? LastCompletion { get; set; }

        /// <summary>
        /// The line items which will be used to complete the transaction.
        /// </summary>
        /// <value>The line items which will be used to complete the transaction.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<CompletionLineItemCreate> LineItems { get; set; }

        /// <summary>
        /// The ID of the transaction which should be completed.
        /// </summary>
        /// <value>The ID of the transaction which should be completed.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionCompletionRequest {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  LastCompletion: ").Append(LastCompletion).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as TransactionCompletionRequest);
        }

        /// <summary>
        /// Returns true if TransactionCompletionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionCompletionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionCompletionRequest input)
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
                    this.LastCompletion == input.LastCompletion ||
                    (this.LastCompletion != null &&
                    this.LastCompletion.Equals(input.LastCompletion))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.LastCompletion != null)
                    hashCode = hashCode * 59 + this.LastCompletion.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                return hashCode;
            }
        }

    }

}
