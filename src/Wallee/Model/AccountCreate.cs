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
    /// AccountCreate
    /// </summary>
    [DataContract]
    public partial class AccountCreate : AbstractAccountUpdate,  IEquatable<AccountCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreate" /> class.
        /// </summary>
        /// <param name="scope">The scope that the account belongs to. (required).</param>
        public AccountCreate(long? scope)
        {
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new InvalidDataException("scope is a required property for AccountCreate and cannot be null");
            }
            this.Scope = scope;
        }




        /// <summary>
        /// The parent account responsible for administering this account.
        /// </summary>
        /// <value>The parent account responsible for administering this account.</value>
        [DataMember(Name="parentAccount", EmitDefaultValue=false)]
        public long? ParentAccount { get; set; }

        /// <summary>
        /// The scope that the account belongs to.
        /// </summary>
        /// <value>The scope that the account belongs to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public long? Scope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubaccountLimit: ").Append(SubaccountLimit).Append("\n");
            sb.Append("  ParentAccount: ").Append(ParentAccount).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as AccountCreate);
        }

        /// <summary>
        /// Returns true if AccountCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.SubaccountLimit == input.SubaccountLimit ||
                    (this.SubaccountLimit != null &&
                    this.SubaccountLimit.Equals(input.SubaccountLimit))
                ) && base.Equals(input) && 
                (
                    this.ParentAccount == input.ParentAccount ||
                    (this.ParentAccount != null &&
                    this.ParentAccount.Equals(input.ParentAccount))
                ) && base.Equals(input) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
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
                int hashCode = base.GetHashCode();
                if (this.LastModifiedDate != null)
                    hashCode = hashCode * 59 + this.LastModifiedDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubaccountLimit != null)
                    hashCode = hashCode * 59 + this.SubaccountLimit.GetHashCode();
                if (this.ParentAccount != null)
                    hashCode = hashCode * 59 + this.ParentAccount.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                return hashCode;
            }
        }

    }

}
