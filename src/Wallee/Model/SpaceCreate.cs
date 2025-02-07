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
    /// SpaceCreate
    /// </summary>
    [DataContract]
    public partial class SpaceCreate : AbstractSpaceUpdate,  IEquatable<SpaceCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpaceCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceCreate" /> class.
        /// </summary>
        /// <param name="account">The account that the space belongs to. (required).</param>
        public SpaceCreate(long? account)
        {
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new InvalidDataException("account is a required property for SpaceCreate and cannot be null");
            }
            this.Account = account;
        }









        /// <summary>
        /// The account that the space belongs to.
        /// </summary>
        /// <value>The account that the space belongs to.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public long? Account { get; set; }

        /// <summary>
        /// The database the space is connected to and that holds the space&#39;s data.
        /// </summary>
        /// <value>The database the space is connected to and that holds the space&#39;s data.</value>
        [DataMember(Name="database", EmitDefaultValue=false)]
        public long? Database { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpaceCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  PrimaryCurrency: ").Append(PrimaryCurrency).Append("\n");
            sb.Append("  RequestLimit: ").Append(RequestLimit).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TechnicalContactAddresses: ").Append(TechnicalContactAddresses).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
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
            return this.Equals(input as SpaceCreate);
        }

        /// <summary>
        /// Returns true if SpaceCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SpaceCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpaceCreate input)
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
                    this.PostalAddress == input.PostalAddress ||
                    (this.PostalAddress != null &&
                    this.PostalAddress.Equals(input.PostalAddress))
                ) && base.Equals(input) && 
                (
                    this.PrimaryCurrency == input.PrimaryCurrency ||
                    (this.PrimaryCurrency != null &&
                    this.PrimaryCurrency.Equals(input.PrimaryCurrency))
                ) && base.Equals(input) && 
                (
                    this.RequestLimit == input.RequestLimit ||
                    (this.RequestLimit != null &&
                    this.RequestLimit.Equals(input.RequestLimit))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.TechnicalContactAddresses == input.TechnicalContactAddresses ||
                    this.TechnicalContactAddresses != null &&
                    input.TechnicalContactAddresses != null &&
                    this.TechnicalContactAddresses.SequenceEqual(input.TechnicalContactAddresses)
                ) && base.Equals(input) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
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
                if (this.PostalAddress != null)
                    hashCode = hashCode * 59 + this.PostalAddress.GetHashCode();
                if (this.PrimaryCurrency != null)
                    hashCode = hashCode * 59 + this.PrimaryCurrency.GetHashCode();
                if (this.RequestLimit != null)
                    hashCode = hashCode * 59 + this.RequestLimit.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TechnicalContactAddresses != null)
                    hashCode = hashCode * 59 + this.TechnicalContactAddresses.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                return hashCode;
            }
        }

    }

}
