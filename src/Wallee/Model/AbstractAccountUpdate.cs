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
        /// The name of the account identifies the account within the administrative interface.
        /// </summary>
        /// <value>The name of the account identifies the account within the administrative interface.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// This property restricts the number of subaccounts which can be created within this account.
        /// </summary>
        /// <value>This property restricts the number of subaccounts which can be created within this account.</value>
        [DataMember(Name="subaccountLimit", EmitDefaultValue=true)]
        public long? SubaccountLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractAccountUpdate {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubaccountLimit != null)
                    hashCode = hashCode * 59 + this.SubaccountLimit.GetHashCode();
                return hashCode;
            }
        }

    }

}
