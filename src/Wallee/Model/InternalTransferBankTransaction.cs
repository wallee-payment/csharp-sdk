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
    /// InternalTransferBankTransaction
    /// </summary>
    [DataContract]
    public partial class InternalTransferBankTransaction :  IEquatable<InternalTransferBankTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTransferBankTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InternalTransferBankTransaction()
        {
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets SourceBankTransaction
        /// </summary>
        [DataMember(Name="sourceBankTransaction", EmitDefaultValue=true)]
        public BankTransaction SourceBankTransaction { get; private set; }

        /// <summary>
        /// Gets or Sets TargetBankTransaction
        /// </summary>
        [DataMember(Name="targetBankTransaction", EmitDefaultValue=true)]
        public BankTransaction TargetBankTransaction { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InternalTransferBankTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  SourceBankTransaction: ").Append(SourceBankTransaction).Append("\n");
            sb.Append("  TargetBankTransaction: ").Append(TargetBankTransaction).Append("\n");
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
            return this.Equals(input as InternalTransferBankTransaction);
        }

        /// <summary>
        /// Returns true if InternalTransferBankTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of InternalTransferBankTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalTransferBankTransaction input)
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
                    this.SourceBankTransaction == input.SourceBankTransaction ||
                    (this.SourceBankTransaction != null &&
                    this.SourceBankTransaction.Equals(input.SourceBankTransaction))
                ) && 
                (
                    this.TargetBankTransaction == input.TargetBankTransaction ||
                    (this.TargetBankTransaction != null &&
                    this.TargetBankTransaction.Equals(input.TargetBankTransaction))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.SourceBankTransaction != null)
                    hashCode = hashCode * 59 + this.SourceBankTransaction.GetHashCode();
                if (this.TargetBankTransaction != null)
                    hashCode = hashCode * 59 + this.TargetBankTransaction.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
