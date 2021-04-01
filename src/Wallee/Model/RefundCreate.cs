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
    /// The refund represents a credit back to the customer. It can be issued by the merchant or by the customer (reversal).
    /// </summary>
    [DataContract]
    public partial class RefundCreate :  IEquatable<RefundCreate>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public RefundType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefundCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCreate" /> class.
        /// </summary>
        /// <param name="externalId">The external id helps to identify duplicate calls to the refund service. As such the external ID has to be unique per transaction. (required).</param>
        /// <param name="type">type (required).</param>
        public RefundCreate(string externalId, RefundType type)
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for RefundCreate and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for RefundCreate and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Completion
        /// </summary>
        [DataMember(Name="completion", EmitDefaultValue=true)]
        public long? Completion { get; set; }

        /// <summary>
        /// The external id helps to identify duplicate calls to the refund service. As such the external ID has to be unique per transaction.
        /// </summary>
        /// <value>The external id helps to identify duplicate calls to the refund service. As such the external ID has to be unique per transaction.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets MerchantReference
        /// </summary>
        [DataMember(Name="merchantReference", EmitDefaultValue=true)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Gets or Sets Reductions
        /// </summary>
        [DataMember(Name="reductions", EmitDefaultValue=true)]
        public List<LineItemReductionCreate> Reductions { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=true)]
        public long? Transaction { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundCreate {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  Reductions: ").Append(Reductions).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as RefundCreate);
        }

        /// <summary>
        /// Returns true if RefundCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundCreate input)
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
                    this.Completion == input.Completion ||
                    (this.Completion != null &&
                    this.Completion.Equals(input.Completion))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.Reductions == input.Reductions ||
                    this.Reductions != null &&
                    input.Reductions != null &&
                    this.Reductions.SequenceEqual(input.Reductions)
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Completion != null)
                    hashCode = hashCode * 59 + this.Completion.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.Reductions != null)
                    hashCode = hashCode * 59 + this.Reductions.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}
