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
    /// PaymentTerminalTransactionSummary
    /// </summary>
    [DataContract]
    public partial class PaymentTerminalTransactionSummary :  IEquatable<PaymentTerminalTransactionSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalTransactionSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalTransactionSummary()
        {
        }

        /// <summary>
        /// Gets or Sets DccTransactionSums
        /// </summary>
        [DataMember(Name="dccTransactionSums", EmitDefaultValue=false)]
        public List<PaymentTerminalDccTransactionSum> DccTransactionSums { get; private set; }

        /// <summary>
        /// Gets or Sets EndedOn
        /// </summary>
        [DataMember(Name="endedOn", EmitDefaultValue=false)]
        public DateTime? EndedOn { get; private set; }

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
        /// Gets or Sets NumberOfTransactions
        /// </summary>
        [DataMember(Name="numberOfTransactions", EmitDefaultValue=false)]
        public int? NumberOfTransactions { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentTerminal
        /// </summary>
        [DataMember(Name="paymentTerminal", EmitDefaultValue=false)]
        public long? PaymentTerminal { get; private set; }

        /// <summary>
        /// Gets or Sets Receipt
        /// </summary>
        [DataMember(Name="receipt", EmitDefaultValue=false)]
        public string Receipt { get; private set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public long? Reference { get; private set; }

        /// <summary>
        /// Gets or Sets StartedOn
        /// </summary>
        [DataMember(Name="startedOn", EmitDefaultValue=false)]
        public DateTime? StartedOn { get; private set; }

        /// <summary>
        /// Gets or Sets TransactionSums
        /// </summary>
        [DataMember(Name="transactionSums", EmitDefaultValue=false)]
        public List<PaymentTerminalTransactionSum> TransactionSums { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerminalTransactionSummary {\n");
            sb.Append("  DccTransactionSums: ").Append(DccTransactionSums).Append("\n");
            sb.Append("  EndedOn: ").Append(EndedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  NumberOfTransactions: ").Append(NumberOfTransactions).Append("\n");
            sb.Append("  PaymentTerminal: ").Append(PaymentTerminal).Append("\n");
            sb.Append("  Receipt: ").Append(Receipt).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  TransactionSums: ").Append(TransactionSums).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as PaymentTerminalTransactionSummary);
        }

        /// <summary>
        /// Returns true if PaymentTerminalTransactionSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminalTransactionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminalTransactionSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DccTransactionSums == input.DccTransactionSums ||
                    this.DccTransactionSums != null &&
                    input.DccTransactionSums != null &&
                    this.DccTransactionSums.SequenceEqual(input.DccTransactionSums)
                ) && 
                (
                    this.EndedOn == input.EndedOn ||
                    (this.EndedOn != null &&
                    this.EndedOn.Equals(input.EndedOn))
                ) && 
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
                    this.NumberOfTransactions == input.NumberOfTransactions ||
                    (this.NumberOfTransactions != null &&
                    this.NumberOfTransactions.Equals(input.NumberOfTransactions))
                ) && 
                (
                    this.PaymentTerminal == input.PaymentTerminal ||
                    (this.PaymentTerminal != null &&
                    this.PaymentTerminal.Equals(input.PaymentTerminal))
                ) && 
                (
                    this.Receipt == input.Receipt ||
                    (this.Receipt != null &&
                    this.Receipt.Equals(input.Receipt))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.StartedOn == input.StartedOn ||
                    (this.StartedOn != null &&
                    this.StartedOn.Equals(input.StartedOn))
                ) && 
                (
                    this.TransactionSums == input.TransactionSums ||
                    this.TransactionSums != null &&
                    input.TransactionSums != null &&
                    this.TransactionSums.SequenceEqual(input.TransactionSums)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.DccTransactionSums != null)
                    hashCode = hashCode * 59 + this.DccTransactionSums.GetHashCode();
                if (this.EndedOn != null)
                    hashCode = hashCode * 59 + this.EndedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.NumberOfTransactions != null)
                    hashCode = hashCode * 59 + this.NumberOfTransactions.GetHashCode();
                if (this.PaymentTerminal != null)
                    hashCode = hashCode * 59 + this.PaymentTerminal.GetHashCode();
                if (this.Receipt != null)
                    hashCode = hashCode * 59 + this.Receipt.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.StartedOn != null)
                    hashCode = hashCode * 59 + this.StartedOn.GetHashCode();
                if (this.TransactionSums != null)
                    hashCode = hashCode * 59 + this.TransactionSums.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
