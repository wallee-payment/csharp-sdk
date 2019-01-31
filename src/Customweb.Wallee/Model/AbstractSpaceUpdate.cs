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
    /// Abstract Space
    /// </summary>
    [DataContract]
    public partial class AbstractSpaceUpdate :  IEquatable<AbstractSpaceUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractSpaceUpdate" /> class.
        /// </summary>
        /// <param name="Name">The space name is used internally to identify the space in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</param>
        /// <param name="PostalAddress">The address to use in communication with clients for example in email, documents etc.</param>
        /// <param name="RequestLimit">The request limit defines the maximum number of API request accepted within 2 minutes for this space. This limit can only be changed with special privileges.</param>
        /// <param name="State">State</param>
        /// <param name="TechnicalContactAddresses">The email address provided as contact addresses will be informed about technical issues or errors triggered by the space.</param>
        /// <param name="TimeZone">The time zone assigned to the space determines the time offset for calculating dates within the space. This is typically used for background processed which needs to be triggered on a specific hour within the day. Changing the space time zone will not change the display of dates.</param>
        public AbstractSpaceUpdate(string Name = default(string), SpaceAddressCreate PostalAddress = default(SpaceAddressCreate), CreationEntityState? State = default(CreationEntityState?), List<string> TechnicalContactAddresses = default(List<string>), string TimeZone = default(string), long? RequestLimit = default(long?))
        {
            this.Name = Name;
            this.PostalAddress = PostalAddress;
            this.RequestLimit = RequestLimit;
            this.State = State;
            this.TechnicalContactAddresses = TechnicalContactAddresses;
            this.TimeZone = TimeZone;
        }

        /// <summary>
        /// The space name is used internally to identify the space in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The space name is used internally to identify the space in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The address to use in communication with clients for example in email, documents etc.
        /// </summary>
        /// <value>The address to use in communication with clients for example in email, documents etc.</value>
        [DataMember(Name="postalAddress", EmitDefaultValue=false)]
        public SpaceAddressCreate PostalAddress { get; set; }

        /// <summary>
        /// The request limit defines the maximum number of API request accepted within 2 minutes for this space. This limit can only be changed with special privileges.
        /// </summary>
        /// <value>The request limit defines the maximum number of API request accepted within 2 minutes for this space. This limit can only be changed with special privileges.</value>
        [DataMember(Name="requestLimit", EmitDefaultValue=false)]
        public long? RequestLimit { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }

        /// <summary>
        /// The email address provided as contact addresses will be informed about technical issues or errors triggered by the space.
        /// </summary>
        /// <value>The email address provided as contact addresses will be informed about technical issues or errors triggered by the space.</value>
        [DataMember(Name="technicalContactAddresses", EmitDefaultValue=false)]
        public List<string> TechnicalContactAddresses { get; set; }

        /// <summary>
        /// The time zone assigned to the space determines the time offset for calculating dates within the space. This is typically used for background processed which needs to be triggered on a specific hour within the day. Changing the space time zone will not change the display of dates.
        /// </summary>
        /// <value>The time zone assigned to the space determines the time offset for calculating dates within the space. This is typically used for background processed which needs to be triggered on a specific hour within the day. Changing the space time zone will not change the display of dates.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

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
            return this.Equals(obj as AbstractSpaceUpdate);
        }

        /// <summary>
        /// Returns true if AbstractSpaceUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractSpaceUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractSpaceUpdate other)
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
                    this.PostalAddress == other.PostalAddress ||
                    this.PostalAddress != null &&
                    this.PostalAddress.Equals(other.PostalAddress)
                ) && 
                (
                    this.RequestLimit == other.RequestLimit ||
                    this.RequestLimit != null &&
                    this.RequestLimit.Equals(other.RequestLimit)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.TechnicalContactAddresses == other.TechnicalContactAddresses ||
                    this.TechnicalContactAddresses != null &&
                    this.TechnicalContactAddresses.SequenceEqual(other.TechnicalContactAddresses)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
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
                if (this.PostalAddress != null)
                {
                    hash = hash * 59 + this.PostalAddress.GetHashCode();
                }
                if (this.RequestLimit != null)
                {
                    hash = hash * 59 + this.RequestLimit.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.TechnicalContactAddresses != null)
                {
                    hash = hash * 59 + this.TechnicalContactAddresses.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hash = hash * 59 + this.TimeZone.GetHashCode();
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
