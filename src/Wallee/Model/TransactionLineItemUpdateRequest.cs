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
    /// TransactionLineItemUpdateRequest
    /// </summary>
    [DataContract]
    public partial class TransactionLineItemUpdateRequest :  IEquatable<TransactionLineItemUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLineItemUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionLineItemUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLineItemUpdateRequest" /> class.
        /// </summary>
        /// <param name="transactionId">transactionId (required).</param>
        public TransactionLineItemUpdateRequest(long? transactionId)
        {
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new InvalidDataException("transactionId is a required property for TransactionLineItemUpdateRequest and cannot be null");
            }
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Gets or Sets NewLineItems
        /// </summary>
        [DataMember(Name="newLineItems", EmitDefaultValue=true)]
        public List<LineItemCreate> NewLineItems { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transactionId", EmitDefaultValue=true)]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionLineItemUpdateRequest {\n");
            sb.Append("  NewLineItems: ").Append(NewLineItems).Append("\n");
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
            return this.Equals(input as TransactionLineItemUpdateRequest);
        }

        /// <summary>
        /// Returns true if TransactionLineItemUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionLineItemUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionLineItemUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewLineItems == input.NewLineItems ||
                    this.NewLineItems != null &&
                    this.NewLineItems.SequenceEqual(input.NewLineItems)
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
                if (this.NewLineItems != null)
                    hashCode = hashCode * 59 + this.NewLineItems.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                return hashCode;
            }
        }

    }

}
