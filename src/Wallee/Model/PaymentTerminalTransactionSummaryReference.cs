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
    /// PaymentTerminalTransactionSummaryReference
    /// </summary>
    [DataContract]
    public partial class PaymentTerminalTransactionSummaryReference :  IEquatable<PaymentTerminalTransactionSummaryReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalTransactionSummaryReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalTransactionSummaryReference()
        {
        }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The unique identifier of the terminal.
        /// </summary>
        /// <value>The unique identifier of the terminal.</value>
        [DataMember(Name="terminalId", EmitDefaultValue=false)]
        public long? TerminalId { get; private set; }

        /// <summary>
        /// The unique identifier of the terminal, that is displayed on the device.
        /// </summary>
        /// <value>The unique identifier of the terminal, that is displayed on the device.</value>
        [DataMember(Name="terminalIdentifier", EmitDefaultValue=false)]
        public string TerminalIdentifier { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerminalTransactionSummaryReference {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  TerminalIdentifier: ").Append(TerminalIdentifier).Append("\n");
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
            return this.Equals(input as PaymentTerminalTransactionSummaryReference);
        }

        /// <summary>
        /// Returns true if PaymentTerminalTransactionSummaryReference instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminalTransactionSummaryReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminalTransactionSummaryReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
                ) && 
                (
                    this.TerminalIdentifier == input.TerminalIdentifier ||
                    (this.TerminalIdentifier != null &&
                    this.TerminalIdentifier.Equals(input.TerminalIdentifier))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.TerminalId != null)
                    hashCode = hashCode * 59 + this.TerminalId.GetHashCode();
                if (this.TerminalIdentifier != null)
                    hashCode = hashCode * 59 + this.TerminalIdentifier.GetHashCode();
                return hashCode;
            }
        }

    }

}
