
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
    /// HumanUserCreate model.
    /// </summary>
    [DataContract]
    public partial class HumanUserCreate :  IEquatable<HumanUserCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HumanUserCreate" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="Scope">The scope to which the user belongs to.</param>
        /// <param name="State">State</param>
        /// <param name="UserType">UserType</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        /// <param name="EmailAddress">The email address of the user.</param>
        /// <param name="EmailAddressVerified">Defines whether a user is verified or not.</param>
        /// <param name="Firstname">The first name of the user.</param>
        /// <param name="Language">The preferred language of the user.</param>
        /// <param name="Lastname">The last name of the user.</param>
        /// <param name="PrimaryAccount">The primary account links the user to a specific account.</param>
        /// <param name="TimeZone">The time zone which is applied for the user. If no timezone is specified the browser is used to determine an appropriate time zone.</param>
        public HumanUserCreate(long? Id = default(long?), DateTime? PlannedPurgeDate = default(DateTime?), Scope Scope = default(Scope), CreationEntityState State = default(CreationEntityState), UserType UserType = default(UserType), long? Version = default(long?), string EmailAddress = default(string), bool? EmailAddressVerified = default(bool?), string Firstname = default(string), string Language = default(string), string Lastname = default(string), Account PrimaryAccount = default(Account), string TimeZone = default(string))
        {
            this.Id = Id;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.Scope = Scope;
            this.State = State;
            this.UserType = UserType;
            this.Version = Version;
            this.EmailAddress = EmailAddress;
            this.EmailAddressVerified = EmailAddressVerified;
            this.Firstname = Firstname;
            this.Language = Language;
            this.Lastname = Lastname;
            this.PrimaryAccount = PrimaryAccount;
            this.TimeZone = TimeZone;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// The scope to which the user belongs to.
        /// </summary>
        /// <value>The scope to which the user belongs to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public Scope Scope { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState State { get; set; }

        /// <summary>
        /// UserType
        /// </summary>
        /// <value>UserType</value>
        [DataMember(Name="userType", EmitDefaultValue=false)]
        public UserType UserType { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// The email address of the user.
        /// </summary>
        /// <value>The email address of the user.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Defines whether a user is verified or not.
        /// </summary>
        /// <value>Defines whether a user is verified or not.</value>
        [DataMember(Name="emailAddressVerified", EmitDefaultValue=false)]
        public bool? EmailAddressVerified { get; set; }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        /// <value>The first name of the user.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The preferred language of the user.
        /// </summary>
        /// <value>The preferred language of the user.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        /// <value>The last name of the user.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// The primary account links the user to a specific account.
        /// </summary>
        /// <value>The primary account links the user to a specific account.</value>
        [DataMember(Name="primaryAccount", EmitDefaultValue=false)]
        public Account PrimaryAccount { get; set; }

        /// <summary>
        /// The time zone which is applied for the user. If no timezone is specified the browser is used to determine an appropriate time zone.
        /// </summary>
        /// <value>The time zone which is applied for the user. If no timezone is specified the browser is used to determine an appropriate time zone.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HumanUserCreate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  EmailAddressVerified: ").Append(EmailAddressVerified).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  PrimaryAccount: ").Append(PrimaryAccount).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(obj as HumanUserCreate);
        }

        /// <summary>
        /// Returns true if HumanUserCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of HumanUserCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HumanUserCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.UserType == other.UserType ||
                    this.UserType != null &&
                    this.UserType.Equals(other.UserType)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.EmailAddressVerified == other.EmailAddressVerified ||
                    this.EmailAddressVerified != null &&
                    this.EmailAddressVerified.Equals(other.EmailAddressVerified)
                ) && 
                (
                    this.Firstname == other.Firstname ||
                    this.Firstname != null &&
                    this.Firstname.Equals(other.Firstname)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Lastname == other.Lastname ||
                    this.Lastname != null &&
                    this.Lastname.Equals(other.Lastname)
                ) && 
                (
                    this.PrimaryAccount == other.PrimaryAccount ||
                    this.PrimaryAccount != null &&
                    this.PrimaryAccount.Equals(other.PrimaryAccount)
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
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.UserType != null)
                    hash = hash * 59 + this.UserType.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                if (this.EmailAddressVerified != null)
                    hash = hash * 59 + this.EmailAddressVerified.GetHashCode();
                if (this.Firstname != null)
                    hash = hash * 59 + this.Firstname.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.Lastname != null)
                    hash = hash * 59 + this.Lastname.GetHashCode();
                if (this.PrimaryAccount != null)
                    hash = hash * 59 + this.PrimaryAccount.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                return hash;
            }
        }

    }

}
