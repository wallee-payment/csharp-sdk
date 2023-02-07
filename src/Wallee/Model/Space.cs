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
    /// Space
    /// </summary>
    [DataContract]
    public partial class Space :  IEquatable<Space>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }
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
        /// The ID of the user who created this entity.
        /// </summary>
        /// <value>The ID of the user who created this entity.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The date and time when this entity was created.
        /// </summary>
        /// <value>The date and time when this entity was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The database in which the space&#39;s data are stored in.
        /// </summary>
        /// <value>The database in which the space&#39;s data are stored in.</value>
        [DataMember(Name="database", EmitDefaultValue=false)]
        public TenantDatabase Database { get; private set; }

        /// <summary>
        /// The ID of a user that deleted this entity.
        /// </summary>
        /// <value>The ID of a user that deleted this entity.</value>
        [DataMember(Name="deletedBy", EmitDefaultValue=false)]
        public long? DeletedBy { get; private set; }

        /// <summary>
        /// The date and time when this entity was deleted.
        /// </summary>
        /// <value>The date and time when this entity was deleted.</value>
        [DataMember(Name="deletedOn", EmitDefaultValue=false)]
        public DateTime? DeletedOn { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The date and time when the object was last modified.
        /// </summary>
        /// <value>The date and time when the object was last modified.</value>
        [DataMember(Name="lastModifiedDate", EmitDefaultValue=false)]
        public DateTime? LastModifiedDate { get; private set; }

        /// <summary>
        /// The space name is used internally to identify the space in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The space name is used internally to identify the space in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The address to use in communication with clients for example in email, documents etc.
        /// </summary>
        /// <value>The address to use in communication with clients for example in email, documents etc.</value>
        [DataMember(Name="postalAddress", EmitDefaultValue=false)]
        public SpaceAddress PostalAddress { get; private set; }

        /// <summary>
        /// This is the currency that is used to display aggregated amounts in the space.
        /// </summary>
        /// <value>This is the currency that is used to display aggregated amounts in the space.</value>
        [DataMember(Name="primaryCurrency", EmitDefaultValue=false)]
        public string PrimaryCurrency { get; private set; }

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
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Space {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ActiveOrRestrictedActive: ").Append(ActiveOrRestrictedActive).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
            sb.Append("  DeletedBy: ").Append(DeletedBy).Append("\n");
            sb.Append("  DeletedOn: ").Append(DeletedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  PrimaryCurrency: ").Append(PrimaryCurrency).Append("\n");
            sb.Append("  RequestLimit: ").Append(RequestLimit).Append("\n");
            sb.Append("  RestrictedActive: ").Append(RestrictedActive).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TechnicalContactAddresses: ").Append(TechnicalContactAddresses).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as Space);
        }

        /// <summary>
        /// Returns true if Space instances are equal
        /// </summary>
        /// <param name="input">Instance of Space to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Space input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.ActiveOrRestrictedActive == input.ActiveOrRestrictedActive ||
                    (this.ActiveOrRestrictedActive != null &&
                    this.ActiveOrRestrictedActive.Equals(input.ActiveOrRestrictedActive))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
                ) && 
                (
                    this.DeletedBy == input.DeletedBy ||
                    (this.DeletedBy != null &&
                    this.DeletedBy.Equals(input.DeletedBy))
                ) && 
                (
                    this.DeletedOn == input.DeletedOn ||
                    (this.DeletedOn != null &&
                    this.DeletedOn.Equals(input.DeletedOn))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.PostalAddress == input.PostalAddress ||
                    (this.PostalAddress != null &&
                    this.PostalAddress.Equals(input.PostalAddress))
                ) && 
                (
                    this.PrimaryCurrency == input.PrimaryCurrency ||
                    (this.PrimaryCurrency != null &&
                    this.PrimaryCurrency.Equals(input.PrimaryCurrency))
                ) && 
                (
                    this.RequestLimit == input.RequestLimit ||
                    (this.RequestLimit != null &&
                    this.RequestLimit.Equals(input.RequestLimit))
                ) && 
                (
                    this.RestrictedActive == input.RestrictedActive ||
                    (this.RestrictedActive != null &&
                    this.RestrictedActive.Equals(input.RestrictedActive))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TechnicalContactAddresses == input.TechnicalContactAddresses ||
                    this.TechnicalContactAddresses != null &&
                    input.TechnicalContactAddresses != null &&
                    this.TechnicalContactAddresses.SequenceEqual(input.TechnicalContactAddresses)
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
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
                int hashCode = 41;
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.ActiveOrRestrictedActive != null)
                    hashCode = hashCode * 59 + this.ActiveOrRestrictedActive.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.DeletedBy != null)
                    hashCode = hashCode * 59 + this.DeletedBy.GetHashCode();
                if (this.DeletedOn != null)
                    hashCode = hashCode * 59 + this.DeletedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastModifiedDate != null)
                    hashCode = hashCode * 59 + this.LastModifiedDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.PostalAddress != null)
                    hashCode = hashCode * 59 + this.PostalAddress.GetHashCode();
                if (this.PrimaryCurrency != null)
                    hashCode = hashCode * 59 + this.PrimaryCurrency.GetHashCode();
                if (this.RequestLimit != null)
                    hashCode = hashCode * 59 + this.RequestLimit.GetHashCode();
                if (this.RestrictedActive != null)
                    hashCode = hashCode * 59 + this.RestrictedActive.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TechnicalContactAddresses != null)
                    hashCode = hashCode * 59 + this.TechnicalContactAddresses.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
