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
    /// CurrencyBankAccount
    /// </summary>
    [DataContract]
    public partial class CurrencyBankAccount :  IEquatable<CurrencyBankAccount>
    {
        /// <summary>
        /// Whether the bank account operates in a test or production environment.
        /// </summary>
        /// <value>Whether the bank account operates in a test or production environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public BankAccountEnvironment? Environment { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyBankAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CurrencyBankAccount()
        {
        }

        /// <summary>
        /// The bank account this currency bank account belongs to.
        /// </summary>
        /// <value>The bank account this currency bank account belongs to.</value>
        [DataMember(Name="bankAccount", EmitDefaultValue=false)]
        public BankAccount BankAccount { get; private set; }

        /// <summary>
        /// The currency associated with the bank account.
        /// </summary>
        /// <value>The currency associated with the bank account.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }


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
            sb.Append("class CurrencyBankAccount {\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
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
            return this.Equals(input as CurrencyBankAccount);
        }

        /// <summary>
        /// Returns true if CurrencyBankAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyBankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyBankAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
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
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
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
