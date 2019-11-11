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
    /// HumanUserCreate
    /// </summary>
    [DataContract]
    public partial class HumanUserCreate : AbstractHumanUserUpdate,  IEquatable<HumanUserCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HumanUserCreate" /> class.
        /// </summary>
        public HumanUserCreate()
        {
        }









        /// <summary>
        /// The primary account links the user to a specific account.
        /// </summary>
        /// <value>The primary account links the user to a specific account.</value>
        [DataMember(Name="primaryAccount", EmitDefaultValue=false)]
        public long? PrimaryAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HumanUserCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  TwoFactorEnabled: ").Append(TwoFactorEnabled).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HumanUserCreate);
        }

        /// <summary>
        /// Returns true if HumanUserCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of HumanUserCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HumanUserCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && base.Equals(input) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && base.Equals(input) && 
                (
                    this.MobilePhoneNumber == input.MobilePhoneNumber ||
                    (this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(input.MobilePhoneNumber))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && base.Equals(input) && 
                (
                    this.TwoFactorEnabled == input.TwoFactorEnabled ||
                    (this.TwoFactorEnabled != null &&
                    this.TwoFactorEnabled.Equals(input.TwoFactorEnabled))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.MobilePhoneNumber != null)
                    hashCode = hashCode * 59 + this.MobilePhoneNumber.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TwoFactorEnabled != null)
                    hashCode = hashCode * 59 + this.TwoFactorEnabled.GetHashCode();
                if (this.PrimaryAccount != null)
                    hashCode = hashCode * 59 + this.PrimaryAccount.GetHashCode();
                return hashCode;
            }
        }

    }

}
