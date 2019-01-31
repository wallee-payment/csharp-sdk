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
    /// Space
    /// </summary>
    [DataContract]
    public partial class Space :  IEquatable<Space>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Space" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Space()
        {
        }

        /// <summary>
        /// The account to which the space belongs to.
        /// </summary>
        /// <value>The account to which the space belongs to.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public Account Account { get; private set; }

        /// <summary>
        /// Active means that this account and all accounts in the hierarchy are active.
        /// </summary>
        /// <value>Active means that this account and all accounts in the hierarchy are active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; private set; }

        /// <summary>
        /// This property is true when all accounts in the hierarchy are active or restricted active.
        /// </summary>
        /// <value>This property is true when all accounts in the hierarchy are active or restricted active.</value>
        [DataMember(Name="activeOrRestrictedActive", EmitDefaultValue=false)]
        public bool? ActiveOrRestrictedActive { get; private set; }

        /// <summary>
        /// The database in which the space&#39;s data are stored in.
        /// </summary>
        /// <value>The database in which the space&#39;s data are stored in.</value>
        [DataMember(Name="database", EmitDefaultValue=false)]
        public TenantDatabase Database { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The space name is used internally to identify the space in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The space name is used internally to identify the space in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The address to use in communication with clients for example in email, documents etc.
        /// </summary>
        /// <value>The address to use in communication with clients for example in email, documents etc.</value>
        [DataMember(Name="postalAddress", EmitDefaultValue=false)]
        public SpaceAddress PostalAddress { get; private set; }

        /// <summary>
        /// The request limit defines the maximum number of API request accepted within 2 minutes for this space. This limit can only be changed with special privileges.
        /// </summary>
        /// <value>The request limit defines the maximum number of API request accepted within 2 minutes for this space. This limit can only be changed with special privileges.</value>
        [DataMember(Name="requestLimit", EmitDefaultValue=false)]
        public long? RequestLimit { get; private set; }

        /// <summary>
        /// Restricted active means that at least one account in the hierarchy is only restricted active, but all are either restricted active or active.
        /// </summary>
        /// <value>Restricted active means that at least one account in the hierarchy is only restricted active, but all are either restricted active or active.</value>
        [DataMember(Name="restrictedActive", EmitDefaultValue=false)]
        public bool? RestrictedActive { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }

        /// <summary>
        /// The email address provided as contact addresses will be informed about technical issues or errors triggered by the space.
        /// </summary>
        /// <value>The email address provided as contact addresses will be informed about technical issues or errors triggered by the space.</value>
        [DataMember(Name="technicalContactAddresses", EmitDefaultValue=false)]
        public List<string> TechnicalContactAddresses { get; private set; }

        /// <summary>
        /// The time zone assigned to the space determines the time offset for calculating dates within the space. This is typically used for background processed which needs to be triggered on a specific hour within the day. Changing the space time zone will not change the display of dates.
        /// </summary>
        /// <value>The time zone assigned to the space determines the time offset for calculating dates within the space. This is typically used for background processed which needs to be triggered on a specific hour within the day. Changing the space time zone will not change the display of dates.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

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
            return this.Equals(obj as Space);
        }

        /// <summary>
        /// Returns true if Space instances are equal
        /// </summary>
        /// <param name="other">Instance of Space to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Space other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.ActiveOrRestrictedActive == other.ActiveOrRestrictedActive ||
                    this.ActiveOrRestrictedActive != null &&
                    this.ActiveOrRestrictedActive.Equals(other.ActiveOrRestrictedActive)
                ) && 
                (
                    this.Database == other.Database ||
                    this.Database != null &&
                    this.Database.Equals(other.Database)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
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
                    this.RestrictedActive == other.RestrictedActive ||
                    this.RestrictedActive != null &&
                    this.RestrictedActive.Equals(other.RestrictedActive)
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
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Account != null)
                {
                    hash = hash * 59 + this.Account.GetHashCode();
                }
                if (this.Active != null)
                {
                    hash = hash * 59 + this.Active.GetHashCode();
                }
                if (this.ActiveOrRestrictedActive != null)
                {
                    hash = hash * 59 + this.ActiveOrRestrictedActive.GetHashCode();
                }
                if (this.Database != null)
                {
                    hash = hash * 59 + this.Database.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.PostalAddress != null)
                {
                    hash = hash * 59 + this.PostalAddress.GetHashCode();
                }
                if (this.RequestLimit != null)
                {
                    hash = hash * 59 + this.RequestLimit.GetHashCode();
                }
                if (this.RestrictedActive != null)
                {
                    hash = hash * 59 + this.RestrictedActive.GetHashCode();
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
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
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
