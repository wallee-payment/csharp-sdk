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
    /// AbstractAccountUpdate
    /// </summary>
    [DataContract]
    public partial class AbstractAccountUpdate :  IEquatable<AbstractAccountUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractAccountUpdate" /> class.
        /// </summary>
        public AbstractAccountUpdate()
        {
        }

        /// <summary>
        /// The date and time when the object was last modified.
        /// </summary>
        /// <value>The date and time when the object was last modified.</value>
        [DataMember(Name="lastModifiedDate", EmitDefaultValue=false)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// The name used to identify the account.
        /// </summary>
        /// <value>The name used to identify the account.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of sub-accounts that can be created within this account.
        /// </summary>
        /// <value>The number of sub-accounts that can be created within this account.</value>
        [DataMember(Name="subaccountLimit", EmitDefaultValue=false)]
        public long? SubaccountLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractAccountUpdate {\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubaccountLimit: ").Append(SubaccountLimit).Append("\n");
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
            return this.Equals(input as AbstractAccountUpdate);
        }

        /// <summary>
        /// Returns true if AbstractAccountUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractAccountUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractAccountUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubaccountLimit == input.SubaccountLimit ||
                    (this.SubaccountLimit != null &&
                    this.SubaccountLimit.Equals(input.SubaccountLimit))
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
                if (this.LastModifiedDate != null)
                    hashCode = hashCode * 59 + this.LastModifiedDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubaccountLimit != null)
                    hashCode = hashCode * 59 + this.SubaccountLimit.GetHashCode();
                return hashCode;
            }
        }

    }

}
