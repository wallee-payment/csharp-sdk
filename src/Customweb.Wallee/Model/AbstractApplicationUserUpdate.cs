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
    /// Abstract Application User
    /// </summary>
    [DataContract]
    public partial class AbstractApplicationUserUpdate :  IEquatable<AbstractApplicationUserUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractApplicationUserUpdate" /> class.
        /// </summary>
        /// <param name="Name">The user name is used to identify the application user in administrative interfaces.</param>
        /// <param name="State">State</param>
        public AbstractApplicationUserUpdate(string Name = default(string), CreationEntityState? State = default(CreationEntityState?))
        {
            this.Name = Name;
            this.State = State;
        }

        /// <summary>
        /// The user name is used to identify the application user in administrative interfaces.
        /// </summary>
        /// <value>The user name is used to identify the application user in administrative interfaces.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }

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
            return this.Equals(obj as AbstractApplicationUserUpdate);
        }

        /// <summary>
        /// Returns true if AbstractApplicationUserUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractApplicationUserUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractApplicationUserUpdate other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
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
