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
    /// ShopifyRecurringOrderUpdateRequest
    /// </summary>
    [DataContract]
    public partial class ShopifyRecurringOrderUpdateRequest :  IEquatable<ShopifyRecurringOrderUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifyRecurringOrderUpdateRequest" /> class.
        /// </summary>
        public ShopifyRecurringOrderUpdateRequest()
        {
        }

        /// <summary>
        /// Gets or Sets ExecutionDate
        /// </summary>
        [DataMember(Name="executionDate", EmitDefaultValue=true)]
        public DateTime? ExecutionDate { get; set; }

        /// <summary>
        /// Gets or Sets RecurringOrderId
        /// </summary>
        [DataMember(Name="recurringOrderId", EmitDefaultValue=true)]
        public long? RecurringOrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifyRecurringOrderUpdateRequest {\n");
            sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
            sb.Append("  RecurringOrderId: ").Append(RecurringOrderId).Append("\n");
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
            return this.Equals(input as ShopifyRecurringOrderUpdateRequest);
        }

        /// <summary>
        /// Returns true if ShopifyRecurringOrderUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifyRecurringOrderUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifyRecurringOrderUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExecutionDate == input.ExecutionDate ||
                    (this.ExecutionDate != null &&
                    this.ExecutionDate.Equals(input.ExecutionDate))
                ) && 
                (
                    this.RecurringOrderId == input.RecurringOrderId ||
                    (this.RecurringOrderId != null &&
                    this.RecurringOrderId.Equals(input.RecurringOrderId))
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
                if (this.ExecutionDate != null)
                    hashCode = hashCode * 59 + this.ExecutionDate.GetHashCode();
                if (this.RecurringOrderId != null)
                    hashCode = hashCode * 59 + this.RecurringOrderId.GetHashCode();
                return hashCode;
            }
        }

    }

}
