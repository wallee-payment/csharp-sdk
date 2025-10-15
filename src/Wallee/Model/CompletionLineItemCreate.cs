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
    /// CompletionLineItemCreate
    /// </summary>
    [DataContract]
    public partial class CompletionLineItemCreate :  IEquatable<CompletionLineItemCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionLineItemCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompletionLineItemCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionLineItemCreate" /> class.
        /// </summary>
        /// <param name="amount">The total amount of the line item to be captured, including taxes. (required).</param>
        /// <param name="quantity">The number of items to be captured. (required).</param>
        /// <param name="uniqueId">The unique identifier of the line item within the set of line items. (required).</param>
        public CompletionLineItemCreate(decimal? amount, decimal? quantity, string uniqueId)
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for CompletionLineItemCreate and cannot be null");
            }
            this.Amount = amount;
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for CompletionLineItemCreate and cannot be null");
            }
            this.Quantity = quantity;
            // to ensure "uniqueId" is required (not null)
            if (uniqueId == null)
            {
                throw new InvalidDataException("uniqueId is a required property for CompletionLineItemCreate and cannot be null");
            }
            this.UniqueId = uniqueId;
        }

        /// <summary>
        /// The total amount of the line item to be captured, including taxes.
        /// </summary>
        /// <value>The total amount of the line item to be captured, including taxes.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The number of items to be captured.
        /// </summary>
        /// <value>The number of items to be captured.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The unique identifier of the line item within the set of line items.
        /// </summary>
        /// <value>The unique identifier of the line item within the set of line items.</value>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletionLineItemCreate {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
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
            return this.Equals(input as CompletionLineItemCreate);
        }

        /// <summary>
        /// Returns true if CompletionLineItemCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of CompletionLineItemCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletionLineItemCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                return hashCode;
            }
        }

    }

}
