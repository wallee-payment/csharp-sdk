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
    /// ApplicationUserCreate
    /// </summary>
    [DataContract]
    public partial class ApplicationUserCreate : AbstractApplicationUserUpdate,  IEquatable<ApplicationUserCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUserCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationUserCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUserCreate" /> class.
        /// </summary>
        /// <param name="primaryAccount">The primary account that the user belongs to. (required).</param>
        public ApplicationUserCreate(long? primaryAccount)
        {
            // to ensure "primaryAccount" is required (not null)
            if (primaryAccount == null)
            {
                throw new InvalidDataException("primaryAccount is a required property for ApplicationUserCreate and cannot be null");
            }
            this.PrimaryAccount = primaryAccount;
        }




        /// <summary>
        /// The primary account that the user belongs to.
        /// </summary>
        /// <value>The primary account that the user belongs to.</value>
        [DataMember(Name="primaryAccount", EmitDefaultValue=false)]
        public long? PrimaryAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationUserCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequestLimit: ").Append(RequestLimit).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PrimaryAccount: ").Append(PrimaryAccount).Append("\n");
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
            return this.Equals(input as ApplicationUserCreate);
        }

        /// <summary>
        /// Returns true if ApplicationUserCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationUserCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUserCreate input)
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
                    this.PrimaryAccount == input.PrimaryAccount ||
                    (this.PrimaryAccount != null &&
                    this.PrimaryAccount.Equals(input.PrimaryAccount))
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
                if (this.RequestLimit != null)
                    hashCode = hashCode * 59 + this.RequestLimit.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PrimaryAccount != null)
                    hashCode = hashCode * 59 + this.PrimaryAccount.GetHashCode();
                return hashCode;
            }
        }

    }

}
