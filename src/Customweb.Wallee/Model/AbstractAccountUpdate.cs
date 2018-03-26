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
    /// Abstract Account
    /// </summary>
    [DataContract]
    public partial class AbstractAccountUpdate :  IEquatable<AbstractAccountUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractAccountUpdate" /> class.
        /// </summary>
        /// <param name="Name">The name of the account identifies the account within the administrative interface.</param>
        /// <param name="SubaccountLimit">This property restricts the number of subaccounts which can be created within this account.</param>
        public AbstractAccountUpdate(string Name = default(string), long? SubaccountLimit = default(long?))
        {
            this.Name = Name;
            this.SubaccountLimit = SubaccountLimit;
        }

        /// <summary>
        /// The name of the account identifies the account within the administrative interface.
        /// </summary>
        /// <value>The name of the account identifies the account within the administrative interface.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// This property restricts the number of subaccounts which can be created within this account.
        /// </summary>
        /// <value>This property restricts the number of subaccounts which can be created within this account.</value>
        [DataMember(Name="subaccountLimit", EmitDefaultValue=false)]
        public long? SubaccountLimit { get; set; }

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
            return this.Equals(obj as AbstractAccountUpdate);
        }

        /// <summary>
        /// Returns true if AbstractAccountUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractAccountUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractAccountUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SubaccountLimit == other.SubaccountLimit ||
                    this.SubaccountLimit != null &&
                    this.SubaccountLimit.Equals(other.SubaccountLimit)
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
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.SubaccountLimit != null)
                {
                    hash = hash * 59 + this.SubaccountLimit.GetHashCode();
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
