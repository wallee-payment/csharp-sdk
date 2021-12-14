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
    /// CompletionLineItem
    /// </summary>
    [DataContract]
    public partial class CompletionLineItem :  IEquatable<CompletionLineItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CompletionLineItem()
        {
        }

        /// <summary>
        /// The total amount of the line item including any tax.
        /// </summary>
        /// <value>The total amount of the line item including any tax.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The quantity of the line item which should be completed.
        /// </summary>
        /// <value>The quantity of the line item which should be completed.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; private set; }

        /// <summary>
        /// The unique id identifies the line item on which the capture is applied on.
        /// </summary>
        /// <value>The unique id identifies the line item on which the capture is applied on.</value>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletionLineItem {\n");
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
            return this.Equals(input as CompletionLineItem);
        }

        /// <summary>
        /// Returns true if CompletionLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CompletionLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletionLineItem input)
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
