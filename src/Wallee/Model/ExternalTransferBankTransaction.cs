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
    /// ExternalTransferBankTransaction
    /// </summary>
    [DataContract]
    public partial class ExternalTransferBankTransaction :  IEquatable<ExternalTransferBankTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalTransferBankTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ExternalTransferBankTransaction()
        {
        }

        /// <summary>
        /// Gets or Sets BankTransaction
        /// </summary>
        [DataMember(Name="bankTransaction", EmitDefaultValue=true)]
        public BankTransaction BankTransaction { get; private set; }

        /// <summary>
        /// Gets or Sets ExternalAccountIdentifier
        /// </summary>
        [DataMember(Name="externalAccountIdentifier", EmitDefaultValue=true)]
        public string ExternalAccountIdentifier { get; private set; }

        /// <summary>
        /// Gets or Sets ExternalAccountType
        /// </summary>
        [DataMember(Name="externalAccountType", EmitDefaultValue=true)]
        public string ExternalAccountType { get; private set; }

        /// <summary>
        /// Gets or Sets ExternalBankName
        /// </summary>
        [DataMember(Name="externalBankName", EmitDefaultValue=true)]
        public string ExternalBankName { get; private set; }

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
            sb.Append("class ExternalTransferBankTransaction {\n");
            sb.Append("  BankTransaction: ").Append(BankTransaction).Append("\n");
            sb.Append("  ExternalAccountIdentifier: ").Append(ExternalAccountIdentifier).Append("\n");
            sb.Append("  ExternalAccountType: ").Append(ExternalAccountType).Append("\n");
            sb.Append("  ExternalBankName: ").Append(ExternalBankName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
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
            return this.Equals(input as ExternalTransferBankTransaction);
        }

        /// <summary>
        /// Returns true if ExternalTransferBankTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalTransferBankTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalTransferBankTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BankTransaction == input.BankTransaction ||
                    (this.BankTransaction != null &&
                    this.BankTransaction.Equals(input.BankTransaction))
                ) && 
                (
                    this.ExternalAccountIdentifier == input.ExternalAccountIdentifier ||
                    (this.ExternalAccountIdentifier != null &&
                    this.ExternalAccountIdentifier.Equals(input.ExternalAccountIdentifier))
                ) && 
                (
                    this.ExternalAccountType == input.ExternalAccountType ||
                    (this.ExternalAccountType != null &&
                    this.ExternalAccountType.Equals(input.ExternalAccountType))
                ) && 
                (
                    this.ExternalBankName == input.ExternalBankName ||
                    (this.ExternalBankName != null &&
                    this.ExternalBankName.Equals(input.ExternalBankName))
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
                if (this.BankTransaction != null)
                    hashCode = hashCode * 59 + this.BankTransaction.GetHashCode();
                if (this.ExternalAccountIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalAccountIdentifier.GetHashCode();
                if (this.ExternalAccountType != null)
                    hashCode = hashCode * 59 + this.ExternalAccountType.GetHashCode();
                if (this.ExternalBankName != null)
                    hashCode = hashCode * 59 + this.ExternalBankName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
