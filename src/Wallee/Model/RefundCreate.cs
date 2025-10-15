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
    /// A refund is a credit issued to the customer, which can be initiated either by the merchant or by the customer as a reversal.
    /// </summary>
    [DataContract]
    public partial class RefundCreate :  IEquatable<RefundCreate>
    {
        /// <summary>
        /// The type specifying the method and origin of the refund (e.g., initiated by the customer or merchant).
        /// </summary>
        /// <value>The type specifying the method and origin of the refund (e.g., initiated by the customer or merchant).</value>
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
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="type">The type specifying the method and origin of the refund (e.g., initiated by the customer or merchant). (required).</param>
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
        /// The total monetary amount of the refund, representing the exact credit issued to the customer.
        /// </summary>
        /// <value>The total monetary amount of the refund, representing the exact credit issued to the customer.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The transaction completion that the refund belongs to.
        /// </summary>
        /// <value>The transaction completion that the refund belongs to.</value>
        [DataMember(Name="completion", EmitDefaultValue=false)]
        public long? Completion { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the refund.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the refund.</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The reductions applied on the original transaction items, detailing specific adjustments associated with the refund.
        /// </summary>
        /// <value>The reductions applied on the original transaction items, detailing specific adjustments associated with the refund.</value>
        [DataMember(Name="reductions", EmitDefaultValue=false)]
        public List<LineItemReductionCreate> Reductions { get; set; }

        /// <summary>
        /// The transaction that the refund belongs to.
        /// </summary>
        /// <value>The transaction that the refund belongs to.</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
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
