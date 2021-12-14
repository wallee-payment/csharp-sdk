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
    /// TransactionLineItemVersionCreate
    /// </summary>
    [DataContract]
    public partial class TransactionLineItemVersionCreate :  IEquatable<TransactionLineItemVersionCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLineItemVersionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionLineItemVersionCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLineItemVersionCreate" /> class.
        /// </summary>
        /// <param name="externalId">A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead. (required).</param>
        /// <param name="lineItems">lineItems (required).</param>
        /// <param name="transaction">transaction (required).</param>
        public TransactionLineItemVersionCreate(string externalId, List<LineItemCreate> lineItems, long? transaction)
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for TransactionLineItemVersionCreate and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "lineItems" is required (not null)
            if (lineItems == null)
            {
                throw new InvalidDataException("lineItems is a required property for TransactionLineItemVersionCreate and cannot be null");
            }
            this.LineItems = lineItems;
            // to ensure "transaction" is required (not null)
            if (transaction == null)
            {
                throw new InvalidDataException("transaction is a required property for TransactionLineItemVersionCreate and cannot be null");
            }
            this.Transaction = transaction;
        }

        /// <summary>
        /// A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.
        /// </summary>
        /// <value>A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public long? Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionLineItemVersionCreate {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
            return this.Equals(input as TransactionLineItemVersionCreate);
        }

        /// <summary>
        /// Returns true if TransactionLineItemVersionCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionLineItemVersionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionLineItemVersionCreate input)
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
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
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
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                return hashCode;
            }
        }

    }

}
