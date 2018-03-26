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
    /// Transaction Line Item Update Request
    /// </summary>
    [DataContract]
    public partial class TransactionLineItemUpdateRequest :  IEquatable<TransactionLineItemUpdateRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLineItemUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionLineItemUpdateRequest() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLineItemUpdateRequest" /> class.
        /// </summary>
        /// <param name="NewLineItems">NewLineItems</param>
        /// <param name="TransactionId">TransactionId (required)</param>
        public TransactionLineItemUpdateRequest(long? TransactionId = default(long?), List<LineItemCreate> NewLineItems = default(List<LineItemCreate>))
        {
            // to ensure "TransactionId" is required (not null)
            if (TransactionId == null)
            {
                throw new ArgumentNullException("TransactionId is a required property for TransactionLineItemUpdateRequest and cannot be null");
            }
            else
            {
                this.TransactionId = TransactionId;
            }
            this.NewLineItems = NewLineItems;
        }

        /// <summary>
        /// NewLineItems
        /// </summary>
        /// <value>NewLineItems</value>
        [DataMember(Name="newLineItems", EmitDefaultValue=false)]
        public List<LineItemCreate> NewLineItems { get; set; }

        /// <summary>
        /// TransactionId
        /// </summary>
        /// <value>TransactionId</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
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
            return this.Equals(obj as TransactionLineItemUpdateRequest);
        }

        /// <summary>
        /// Returns true if TransactionLineItemUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionLineItemUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionLineItemUpdateRequest other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.NewLineItems == other.NewLineItems ||
                    this.NewLineItems != null &&
                    this.NewLineItems.SequenceEqual(other.NewLineItems)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
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
                if (this.NewLineItems != null)
                {
                    hash = hash * 59 + this.NewLineItems.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
