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
    /// AccountUpdate
    /// </summary>
    [DataContract]
    public partial class AccountUpdate : AbstractAccountUpdate,  IEquatable<AccountUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUpdate" /> class.
        /// </summary>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        public AccountUpdate(long? version, long? id)
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for AccountUpdate and cannot be null");
            }
            this.Version = version;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AccountUpdate and cannot be null");
            }
            this.Id = id;
        }



        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountUpdate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubaccountLimit: ").Append(SubaccountLimit).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountUpdate);
        }

        /// <summary>
        /// Returns true if AccountUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountUpdate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubaccountLimit != null)
                    hashCode = hashCode * 59 + this.SubaccountLimit.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
