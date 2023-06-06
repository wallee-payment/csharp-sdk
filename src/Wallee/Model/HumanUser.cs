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
    /// HumanUser
    /// </summary>
    [DataContract]
    public partial class HumanUser :  IEquatable<HumanUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HumanUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public HumanUser()
        {
        }

        /// <summary>
        /// The user&#39;s email address.
        /// </summary>
        /// <value>The user&#39;s email address.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; private set; }

        /// <summary>
        /// Whether the user&#39;s email address has been verified.
        /// </summary>
        /// <value>Whether the user&#39;s email address has been verified.</value>
        [DataMember(Name="emailAddressVerified", EmitDefaultValue=false)]
        public bool? EmailAddressVerified { get; private set; }

        /// <summary>
        /// The user&#39;s first name.
        /// </summary>
        /// <value>The user&#39;s first name.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; private set; }

        /// <summary>
        /// The user&#39;s preferred language.
        /// </summary>
        /// <value>The user&#39;s preferred language.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The user&#39;s last name.
        /// </summary>
        /// <value>The user&#39;s last name.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; private set; }

        /// <summary>
        /// The user&#39;s mobile phone number.
        /// </summary>
        /// <value>The user&#39;s mobile phone number.</value>
        [DataMember(Name="mobilePhoneNumber", EmitDefaultValue=false)]
        public string MobilePhoneNumber { get; private set; }

        /// <summary>
        /// Whether the user&#39;s mobile phone number has been verified.
        /// </summary>
        /// <value>Whether the user&#39;s mobile phone number has been verified.</value>
        [DataMember(Name="mobilePhoneVerified", EmitDefaultValue=false)]
        public bool? MobilePhoneVerified { get; private set; }

        /// <summary>
        /// The primary account that the user belongs to.
        /// </summary>
        /// <value>The primary account that the user belongs to.</value>
        [DataMember(Name="primaryAccount", EmitDefaultValue=false)]
        public long? PrimaryAccount { get; private set; }

        /// <summary>
        /// The scope that the user belongs to.
        /// </summary>
        /// <value>The scope that the user belongs to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public long? Scope { get; private set; }

        /// <summary>
        /// The user&#39;s time zone. If none is specified, the one provided by the browser will be used.
        /// </summary>
        /// <value>The user&#39;s time zone. If none is specified, the one provided by the browser will be used.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// Whether two-factor authentication is enabled for this user.
        /// </summary>
        /// <value>Whether two-factor authentication is enabled for this user.</value>
        [DataMember(Name="twoFactorEnabled", EmitDefaultValue=false)]
        public bool? TwoFactorEnabled { get; private set; }

        /// <summary>
        /// The type of two-factor authentication that is enabled for the user.
        /// </summary>
        /// <value>The type of two-factor authentication that is enabled for the user.</value>
        [DataMember(Name="twoFactorType", EmitDefaultValue=false)]
        public TwoFactorAuthenticationType TwoFactorType { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HumanUser {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  EmailAddressVerified: ").Append(EmailAddressVerified).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  MobilePhoneVerified: ").Append(MobilePhoneVerified).Append("\n");
            sb.Append("  PrimaryAccount: ").Append(PrimaryAccount).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  TwoFactorEnabled: ").Append(TwoFactorEnabled).Append("\n");
            sb.Append("  TwoFactorType: ").Append(TwoFactorType).Append("\n");
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
            return this.Equals(input as HumanUser);
        }

        /// <summary>
        /// Returns true if HumanUser instances are equal
        /// </summary>
        /// <param name="input">Instance of HumanUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HumanUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.EmailAddressVerified == input.EmailAddressVerified ||
                    (this.EmailAddressVerified != null &&
                    this.EmailAddressVerified.Equals(input.EmailAddressVerified))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.MobilePhoneNumber == input.MobilePhoneNumber ||
                    (this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(input.MobilePhoneNumber))
                ) && 
                (
                    this.MobilePhoneVerified == input.MobilePhoneVerified ||
                    (this.MobilePhoneVerified != null &&
                    this.MobilePhoneVerified.Equals(input.MobilePhoneVerified))
                ) && 
                (
                    this.PrimaryAccount == input.PrimaryAccount ||
                    (this.PrimaryAccount != null &&
                    this.PrimaryAccount.Equals(input.PrimaryAccount))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.TwoFactorEnabled == input.TwoFactorEnabled ||
                    (this.TwoFactorEnabled != null &&
                    this.TwoFactorEnabled.Equals(input.TwoFactorEnabled))
                ) && 
                (
                    this.TwoFactorType == input.TwoFactorType ||
                    (this.TwoFactorType != null &&
                    this.TwoFactorType.Equals(input.TwoFactorType))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.EmailAddressVerified != null)
                    hashCode = hashCode * 59 + this.EmailAddressVerified.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.MobilePhoneNumber != null)
                    hashCode = hashCode * 59 + this.MobilePhoneNumber.GetHashCode();
                if (this.MobilePhoneVerified != null)
                    hashCode = hashCode * 59 + this.MobilePhoneVerified.GetHashCode();
                if (this.PrimaryAccount != null)
                    hashCode = hashCode * 59 + this.PrimaryAccount.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TwoFactorEnabled != null)
                    hashCode = hashCode * 59 + this.TwoFactorEnabled.GetHashCode();
                if (this.TwoFactorType != null)
                    hashCode = hashCode * 59 + this.TwoFactorType.GetHashCode();
                return hashCode;
            }
        }

    }

}
