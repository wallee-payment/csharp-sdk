/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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
    /// The refund represents a credit back to the customer. It can be issued by the merchant or by the customer (reversal).
    /// </summary>
    [DataContract]
    public partial class RefundCreate :  IEquatable<RefundCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefundCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCreate" /> class.
        /// </summary>
        /// <param name="ExternalId">The external id helps to identify duplicate calls to the refund service. As such the external ID has to be unique per transaction. (required)</param>
        /// <param name="MerchantReference">MerchantReference</param>
        /// <param name="Reductions">Reductions (required)</param>
        /// <param name="Transaction">Transaction (required)</param>
        /// <param name="Type">Type (required)</param>
        public RefundCreate(long? Transaction = default(long?), string ExternalId = default(string), RefundType? Type = default(RefundType?), string MerchantReference = default(string), List<LineItemReductionCreate> Reductions = default(List<LineItemReductionCreate>))
        {
            // to ensure "ExternalId" is required (not null)
            if (ExternalId == null)
            {
                throw new ArgumentNullException("ExternalId is a required property for RefundCreate and cannot be null");
            }
            else
            {
                this.ExternalId = ExternalId;
            }
            // to ensure "Reductions" is required (not null)
            if (Reductions == null)
            {
                throw new ArgumentNullException("Reductions is a required property for RefundCreate and cannot be null");
            }
            else
            {
                this.Reductions = Reductions;
            }
            // to ensure "Transaction" is required (not null)
            if (Transaction == null)
            {
                throw new ArgumentNullException("Transaction is a required property for RefundCreate and cannot be null");
            }
            else
            {
                this.Transaction = Transaction;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new ArgumentNullException("Type is a required property for RefundCreate and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.MerchantReference = MerchantReference;
        }

        /// <summary>
        /// The external id helps to identify duplicate calls to the refund service. As such the external ID has to be unique per transaction.
        /// </summary>
        /// <value>The external id helps to identify duplicate calls to the refund service. As such the external ID has to be unique per transaction.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// MerchantReference
        /// </summary>
        /// <value>MerchantReference</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Reductions
        /// </summary>
        /// <value>Reductions</value>
        [DataMember(Name="reductions", EmitDefaultValue=false)]
        public List<LineItemReductionCreate> Reductions { get; set; }

        /// <summary>
        /// Transaction
        /// </summary>
        /// <value>Transaction</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public long? Transaction { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public RefundType? Type { get; set; }

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
            return this.Equals(obj as RefundCreate);
        }

        /// <summary>
        /// Returns true if RefundCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of RefundCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.Reductions == other.Reductions ||
                    this.Reductions != null &&
                    this.Reductions.SequenceEqual(other.Reductions)
                ) && 
                (
                    this.Transaction == other.Transaction ||
                    this.Transaction != null &&
                    this.Transaction.Equals(other.Transaction)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                }
                if (this.Reductions != null)
                {
                    hash = hash * 59 + this.Reductions.GetHashCode();
                }
                if (this.Transaction != null)
                {
                    hash = hash * 59 + this.Transaction.GetHashCode();
                }
                if (this.Type != null)
                {
                    hash = hash * 59 + this.Type.GetHashCode();
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
